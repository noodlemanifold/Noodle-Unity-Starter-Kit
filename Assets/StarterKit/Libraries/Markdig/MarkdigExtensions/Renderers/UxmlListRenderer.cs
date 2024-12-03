using UnityEngine;

using Markdig.Syntax;

namespace Markdig.Renderers.Uxml {

/// <summary>
/// A HTML renderer for a <see cref="ListBlock"/>.
/// </summary>
/// <seealso cref="HtmlObjectRenderer{ListBlock}" />
public class UxmlListRenderer : UxmlObjectRenderer<ListBlock> {
    
    private MarkdownSettings renderSettings;
    
    public UxmlListRenderer(MarkdownSettings renderSettings) {
        this.renderSettings = renderSettings;
    }
    
    protected override void Write(UxmlRenderer renderer, ListBlock listBlock) {
        renderer.EnsureLine();
        renderer.WriteLinesBefore(listBlock);

        int delimiterNumber = 1;
        if (listBlock.OrderedStart is not null) {
            delimiterNumber = int.Parse(listBlock.OrderedStart);
        }

        foreach (var item in listBlock) {
            var listItem = (ListItemBlock)item;
            var previousImplicit = renderer.ImplicitParagraph;
            renderer.ImplicitParagraph = !listBlock.IsLoose;

            if (listBlock.IsOrdered) {
                if (listBlock.BulletType != '1') {
                    //apparently this isnt supported?
                    //its just treats them as a big paragraph
                    //put its in the libraries own list renderer?
                    //who knows anymore dood
                    char delimiterLetter = (char)(listBlock.BulletType + (delimiterNumber - 1));//least cursed math
                    renderer.Write("" + delimiterLetter + listBlock.OrderedDelimiter);
                }
                else {
                    renderer.WriteRaw("<mspace=0.6em>" + delimiterNumber +"</mspace>" + listBlock.OrderedDelimiter);
                    //renderer.Write("" + delimiterNumber + listBlock.OrderedDelimiter);
                }
            }
            else {
                renderer.WriteRaw(renderSettings.unorderedListDelimiter);
            }

            delimiterNumber++;

            renderer.WriteRaw("<indent=1em>");
            renderer.WriteChildren(listItem);
            renderer.WriteRaw("</indent>");
            
            renderer.ImplicitParagraph = previousImplicit;
            renderer.EnsureLine();
        }
        
        renderer.WriteLine();//lists are always followed by a blank line
    }
}
}