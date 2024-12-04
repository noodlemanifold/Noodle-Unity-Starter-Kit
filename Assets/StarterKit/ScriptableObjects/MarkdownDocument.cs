using System;
using System.IO;
using Markdig;
using Markdig.Extensions.EmphasisExtras;
using Markdig.Renderers;
using NoodleKit;
using Unity.Properties;
using UnityEngine;

namespace Noodlekit{

[CreateAssetMenu(fileName = "Markdown", menuName = "Noodle Kit/Markdown")]
public class MarkdownDocument : ScriptableObject {

    public MarkdownSettings renderingSettings;
    [TextArea(30,50)]
    public string rawText;

    [CreateProperty]
    public string uxmlRichText{ get; private set; }
    
    public string htmlText { get; private set; }

    private StringWriter writer1 = new();
    private StringWriter writer2 = new();
    private HtmlRenderer htmlRenderer;
    private UxmlRenderer uxmlRenderer;

    public void RenderHTML() {
        if (htmlRenderer is null) htmlRenderer = new(writer1);
        
        Markdig.Syntax.MarkdownDocument doc = Markdown.Parse(rawText);
        
        htmlRenderer.Render(doc);
        htmlRenderer.Writer.Flush();

        htmlText =  htmlRenderer.Writer.ToString() ?? string.Empty;

        Debug.Log(htmlText);
    }
    
    public void RenderUXML() {
        if (renderingSettings is null) return;
        if (uxmlRenderer is null) uxmlRenderer = new(writer2, renderingSettings);
        
        var pipeline = new MarkdownPipelineBuilder()
            .UseEmphasisExtras(EmphasisExtraOptions.Strikethrough | EmphasisExtraOptions.Subscript)
            .EnableTrackTrivia()
            .Build();
        
        Markdig.Syntax.MarkdownDocument doc = Markdown.Parse(rawText, pipeline);
        
        uxmlRenderer.Render(doc);
        uxmlRenderer.Writer.Flush();

        uxmlRichText =  uxmlRenderer.Writer.ToString() ?? string.Empty;

        StringWriter w = uxmlRenderer.Writer as StringWriter;
        w.GetStringBuilder().Clear();
        

        //Debug.Log(uxmlRichText);
    }
}
}