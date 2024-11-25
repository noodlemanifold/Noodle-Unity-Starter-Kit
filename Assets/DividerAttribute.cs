using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

public class DividerAttribute : PropertyAttribute {
    public float thickness;
    public float margin;

    public DividerAttribute(float thickness = 1, float margin = 20) {
        this.thickness = thickness;
        this.margin = margin;
    }

}

[CustomPropertyDrawer(typeof(DividerAttribute))]
public class DividerDrawer : DecoratorDrawer { //inherit from property drawer to change how a property is drawn

    public override VisualElement CreatePropertyGUI() {
        VisualElement container = new VisualElement();
        DividerAttribute divider = attribute as DividerAttribute;
        
        //optionally you can load in a .uxml file instead of defining the UI in code.
        //VisualTreeAsset tree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/DividerAttribute.uxml");
        //container = tree.Instantiate();
        
        VisualElement bar = new VisualElement();
        bar.style.backgroundColor = Color.gray;
        bar.style.height = divider!.thickness;
        bar.style.marginLeft = 5;
        bar.style.marginRight = 5;
        bar.style.marginTop = divider!.margin;
        bar.style.marginBottom = divider!.margin;
        container.Add(bar);
        return container;
    }
}

