
using System;
using Markdig;
using Markdig.Syntax;
using Unity.Mathematics;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;
using UnityEngine.UIElements;
using NoodleKit;
using UnityEditor.Events;

[ExecuteAlways]
public class TestScript : MonoBehaviour {
    
    public MarkdownDocument document;
    [Button("",false)] public UnityEvent ToHTML;
    [Button("",false)] public UnityEvent ToUXML;


    void Update() {
        UnityEventTools.RemovePersistentListener(ToHTML,HTML);
        UnityEventTools.AddPersistentListener(ToHTML,HTML);
        ToHTML.SetPersistentListenerState(0,UnityEventCallState.EditorAndRuntime);
        
        UnityEventTools.RemovePersistentListener(ToUXML,UXML);
        UnityEventTools.AddPersistentListener(ToUXML,UXML);
        ToUXML.SetPersistentListenerState(0,UnityEventCallState.EditorAndRuntime);
    }

    void AssignEvents() {
        
    }

    public void HTML() {
        document.RenderHTML();
    }
    
    public void UXML() {
        document.RenderUXML();
    }
}

