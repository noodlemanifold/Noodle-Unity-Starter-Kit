#if UNITY_EDITOR

using System;
using UnityEditor;
using UnityEditor.Toolbars;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;


//better dark mode: https://github.com/0x7c13/UnityEditor-DarkMode

public class ThemeSwitcher : Editor {
    //[MenuItem("Theme/Toggle Theme")]
    public static void ToggleTheme() {
        int newSkin = EditorGUIUtility.isProSkin ? 0 : 1;

        EditorPrefs.SetInt("UserSkin", newSkin);
        InternalEditorUtility.SwitchSkinAndRepaintAllViews();
    }
}

//Overwriting/adding editor buttons madness:

//Unity toolbar source code:
//https://github.com/Unity-Technologies/UnityCsReference/blob/master/Editor/Mono/UIElements/DefaultMainToolbar.cs

//this class works how the new Multiplay toolbar dropdown works. 
//it only gives you the play buttons container before it is added to the rest of the Editor UI
//so its parent is null :(
//however, if you cache it, then subscribe to a late redraw event, its parents are defined!

internal static class ToolbarHook {
    // public static event Action<VisualElement> CreatingPlayModeButtons
    // {
    //     add => UnityEditor.Toolbars.PlayModeButtons.onPlayModeButtonsCreated += value;
    //     remove => UnityEditor.Toolbars.PlayModeButtons.onPlayModeButtonsCreated -= value;
    // }

    [InitializeOnLoadMethod]
    private static void Initialize() {
        UnityEditor.Toolbars.PlayModeButtons.onPlayModeButtonsCreated += CreatePlayModeButtons;
        EditorApplication.delayCall += AfterRedraw; 
    }

    private static VisualElement playContainerCache;

    internal static void CreatePlayModeButtons(VisualElement container) {
        playContainerCache = container;
    }

    private static void AfterRedraw() {
        VisualElement rightToolbar = playContainerCache.parent.parent.Q("ToolbarZoneRightAlign");
        AddThemeButton(rightToolbar);
    }

    private static void AddThemeButton(VisualElement container) {
        EditorToolbarButton button = new EditorToolbarButton();
        //omg.text = "Least Cursed Button";
        //omg.icon = EditorGUIUtility.IconContent("PlayButton").image as Texture2D;
        button.icon = EditorGUIUtility.FindTexture("DirectionalLight Gizmo");
        button.clickable = new Clickable(() => { ThemeSwitcher.ToggleTheme(); });
        container.Add(button);
    }
}

//overwriting toolbar buttons idea:
//https://stackoverflow.com/questions/76496378/is-there-a-way-to-add-a-button-in-the-unity-editor-like-unity-services
//this is a bit jank and generates editor warnings

// [EditorToolbarElement("Multiplayer/MultiplayerRole", typeof(DefaultMainToolbar))]
// sealed class CloudReplace : EditorToolbarButton {
//     public CloudReplace() : base(Clicked) {
//         tooltip = L10n.Tr("Switch Editor Theme");
//         icon = EditorGUIUtility.FindTexture("DirectionalLight Gizmo");
//         style.unityBackgroundImageTintColor = Color.magenta;
//         Image image = this.Q<Image>();
//         image.style.color = Color.magenta;
//
//         this.Q<Image>(className: EditorToolbar.elementIconClassName).style.display = DisplayStyle.Flex;
//
//         // RegisterCallback<AttachToPanelEvent>(OnAttachedToPanel);
//         // RegisterCallback<DetachFromPanelEvent>(OnDetachFromPanel);
//     }
//
//     static void Clicked() {
//         ThemeSwitcher.ToggleTheme();
//     }
// }
#endif