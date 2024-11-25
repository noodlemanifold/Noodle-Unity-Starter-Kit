using System;
using System.Drawing;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;


public class TestScript : MonoBehaviour {
    public float favoriteNumber;
    public void Clicked() {
        Debug.Log("Clicked!");
    }
}

#if UNITY_EDITOR
[CustomEditor ( typeof(TestScript))]
public class InspectorTestScript : Editor {
    public override VisualElement CreateInspectorGUI() {
        VisualElement container = new VisualElement();//create root element of our inspector UI
        TestScript script = (TestScript)target;//the component this is an inspector for
        
        InspectorElement.FillDefaultInspector(container, serializedObject, this);//draw the default inspector

        Button button = new Button();//make a new button
        button.text = "Click!";//set button text
        button.clickable = new Clickable(() => { script.Clicked(); });//lambda function called on button click
        button.style.marginTop = 10;
        
        container.Add(button);//append our button to the UI layout
        
        return container;//return our super cool layout
    }
}
#endif
