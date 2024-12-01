using Markdig.Syntax.Inlines;

namespace Markdig.Renderers.Uxml {

/// <summary>
/// A HTML renderer for a <see cref="HtmlEntityInline"/>.
/// </summary>
/// <seealso cref="HtmlObjectRenderer{HtmlEntityInline}" />
public class UxmlEntityInlineRenderer : UxmlObjectRenderer<HtmlEntityInline> {
    protected override void Write(UxmlRenderer renderer, HtmlEntityInline obj) {
        if (renderer.EnableHtmlEscape) {
            renderer.WriteEscape(obj.Transcoded);
        }
        else {
            renderer.Write(obj.Transcoded);
        }
    }
}
}