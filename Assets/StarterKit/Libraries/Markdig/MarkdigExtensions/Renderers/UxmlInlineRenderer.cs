using Markdig.Syntax.Inlines;

namespace Markdig.Renderers.Uxml {

/// <summary>
/// A HTML renderer for a <see cref="HtmlInline"/>.
/// </summary>
/// <seealso cref="HtmlObjectRenderer{HtmlInline}" />
public class UxmlInlineRenderer : UxmlObjectRenderer<HtmlInline> {
    protected override void Write(UxmlRenderer renderer, HtmlInline obj) {
        if (renderer.EnableHtmlForInline) {
            renderer.Write(obj.Tag);
        }
    }
}
}