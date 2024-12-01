using Markdig.Renderers.Uxml;
using Markdig.Syntax;
using UnityEngine;

namespace Markdig.Renderers.Html {

/// <summary>
/// A HTML renderer for a <see cref="HtmlBlock"/>.
/// </summary>
/// <seealso cref="HtmlObjectRenderer{HtmlBlock}" />
public class UxmlBlockRenderer : UxmlObjectRenderer<HtmlBlock> {
    protected override void Write(UxmlRenderer renderer, HtmlBlock obj) {
        Debug.Log("Block");
        renderer.WriteLeafRawLines(obj, true, false);
    }
}
}