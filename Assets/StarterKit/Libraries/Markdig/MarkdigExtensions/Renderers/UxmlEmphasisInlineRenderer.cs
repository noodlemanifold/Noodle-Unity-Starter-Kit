using Markdig.Syntax.Inlines;
using System.Diagnostics;
using Markdig.Renderers.Uxml;
using NoodleKit;
using Debug = UnityEngine.Debug;

namespace Markdig.Renderers.Html {

/// <summary>
/// A HTML renderer for an <see cref="EmphasisInline"/>.
/// </summary>
/// <seealso cref="HtmlObjectRenderer{EmphasisInline}" />
public class UxmlEmphasisInlineRenderer : UxmlObjectRenderer<EmphasisInline> {

    private MarkdownSettings renderSettings;

    public UxmlEmphasisInlineRenderer(MarkdownSettings renderSettings) {
        this.renderSettings = renderSettings;
    }

    protected override void Write(UxmlRenderer renderer, EmphasisInline obj) {
        string opener = (obj.DelimiterChar switch {
            '*' => "<b>",
            '_' => "<i>",
            '~' => "<s>",
            _ => ""
        });
        string closer = (obj.DelimiterChar switch {
            '*' => "</b>",
            '_' => "</i>",
            '~' => "</s>",
            _ => ""
        });


        renderer.WriteRaw(opener);

        renderer.WriteChildren(obj);
        
        renderer.WriteRaw(closer);

    }
}
}