
using System;
using System.Collections;
using System.Reflection;
using NoodleKit;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;

public class TestScript : MonoBehaviour {
    
    [Button("Bla", "holy shit", true)]
    public float IExist;

    public void Bla() {
        Debug.Log("OMG");
    }
}

