using Markdig.Renderers.Html;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using Unity.VisualScripting;
using UnityEngine;

namespace Markdig.Renderers.Uxml {
/// <summary>
/// An HTML renderer for a <see cref="HeadingBlock"/>.
/// </summary>
/// <seealso cref="HtmlObjectRenderer{TObject}" />
public class UxmlHeadingRenderer : UxmlObjectRenderer<HeadingBlock> {
    
    private MarkdownSettings renderSettings;
    private MarkdownSettings.HeaderSettings[] headerSettingses;

    public UxmlHeadingRenderer(MarkdownSettings renderSettings) {
        this.renderSettings = renderSettings;
        headerSettingses = new MarkdownSettings.HeaderSettings[]{
            this.renderSettings.h1,
            this.renderSettings.h2,
            this.renderSettings.h3,
            this.renderSettings.h4,
            this.renderSettings.h5,
            this.renderSettings.h6
        };
    }
    

    protected override void Write(UxmlRenderer renderer, HeadingBlock obj) {
        MarkdownSettings.HeaderSettings settings = headerSettingses[obj.Level - 1];

        string opener = "<size=" + settings.fontSize +">";
        string closer = "</size>";

        int weight = settings.fontWeight;
        if (weight > 0 && weight <= 900 && weight % 100 == 0) {
            opener += "<font-weight=" + weight + ">";
            closer += "</font-weight>";
        }
        else {
            opener += "<b>";
            closer += "</b>";
        }

        renderer.WriteLinesBefore(obj);

        renderer.WriteRaw(opener);
        
        renderer.WriteLeafInline(obj);

        renderer.WriteRaw(closer);

        renderer.EnsureLine();
        //renderer.WriteLine();
    }
}
}