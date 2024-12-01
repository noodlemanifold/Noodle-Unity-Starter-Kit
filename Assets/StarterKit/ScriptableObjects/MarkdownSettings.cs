using NoodleKit;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UIElements;
#endif


[CreateAssetMenu(fileName = "MarkdownSettings", menuName = "Noodle Kit/Markdown Settings")]
public class MarkdownSettings : ScriptableObject {

    [Header("Heading Settings")] 
    public HeaderSettings h1;
    public HeaderSettings h2;
    public HeaderSettings h3;
    public HeaderSettings h4;
    public HeaderSettings h5;
    public HeaderSettings h6;

    [Header("Paragraph Settings")]
    public string tabSize = "1em";

    [Header("List Settings")] 
    public string unorderedListDelimiter = "- ";

    [System.Serializable]
    public class HeaderSettings {
        public int fontWeight;
        public string fontSize;
    }
}

#if UNITY_EDITOR

[CustomPropertyDrawer(typeof(MarkdownSettings.HeaderSettings))]
public class ButtonDrawer : PropertyDrawer { //inherit from property drawer to change how a property is drawn

    public override VisualElement CreatePropertyGUI(SerializedProperty property) {
        VisualElement container = new VisualElement();

        if (!property.isExpanded) {
            property.isExpanded = true;
            property.serializedObject.ApplyModifiedProperties();
        }

        PropertyField defaultInspector = new PropertyField(property);
        container.Add(defaultInspector);
        
        return container;
    }
}
#endif