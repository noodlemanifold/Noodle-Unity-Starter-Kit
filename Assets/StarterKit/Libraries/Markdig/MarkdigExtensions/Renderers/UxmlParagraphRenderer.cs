using Markdig.Renderers.Uxml;
using Markdig.Syntax;
using NoodleKit;
using UnityEngine;

namespace Markdig.Renderers.Html {

/// <summary>
/// A HTML renderer for a <see cref="ParagraphBlock"/>.
/// </summary>
/// <seealso cref="HtmlObjectRenderer{ParagraphBlock}" />
public class UxmlParagraphRenderer : UxmlObjectRenderer<ParagraphBlock> {

    private MarkdownSettings renderSettings;

    public UxmlParagraphRenderer(MarkdownSettings renderSettings) {
        this.renderSettings = renderSettings;
    }
    
    protected override void Write(UxmlRenderer renderer, ParagraphBlock obj) {
        
        string opener = "<line-indent=" + renderSettings.tabSize +">";
        string closer = "</line-indent>";

        //implicit paragraph means that this is an embedded paragraph in a list or something
        //and it should not get paragraph formatting. how elegant -_-
        if (!renderer.ImplicitParagraph) {
            renderer.WriteLinesBefore(obj);
            renderer.WriteRaw(opener);
        }

        renderer.WriteLeafInline(obj);

        if (!renderer.ImplicitParagraph) {
            renderer.WriteLine(closer);
            renderer.WriteLine();//paragraphs are always followed by a blank space
        }
        
    }
}
}
