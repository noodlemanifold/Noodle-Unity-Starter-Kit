using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace NoodleKit {

public static class NoodleUtils {
    
    public static string FormatCamelCase(string camelCase) {
        string result = "";
        //https://stackoverflow.com/questions/773303/splitting-camelcase
        string[] tokens = Regex.Matches(camelCase, "([A-Z]+(?![a-z])|[A-Z][a-z]+|[0-9]+|[a-z]+)")
            .Select(m => m.Value)
            .ToArray();

        //capitalize each token and add a space
        foreach (string token in tokens) {
            result += System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(token) + " ";
        }

        return result.Trim(); //trim removes the last trailing space character
    }
#if UNITY_EDITOR
    public static Color GetEditorBorderColor() {
        Color lightColor = new Color(0.6f, 0.6f, 0.6f);
        Color darkColor = new Color(0.1f, 0.1f, 0.1f);
        Color color = EditorGUIUtility.isProSkin ? darkColor : lightColor;
        return color;
    }
#endif
}
}