
using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;
using UnityEngine.UIElements;
using NoodleKit;


public class TestScript : MonoBehaviour {
    
    public float hi;
    public float hi2;
    [Divider]
    public float hi3;
    public float hi4;
    [Button] [SerializeField] private UnityEvent coolEvent5;


    void Start() {
        coolEvent5.AddListener(Print);
    }

    public void Print() {
        Debug.Log("HI");
    }
}

