using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestScript : MonoBehaviour {

    private void Start() {
        Vector4 v1 = new Vector4(1.0f, 2.0f, 3.0f, 4.0f);
        Vector4 v2 = new Vector4(5.0f, 6.0f, 7.0f, 8.0f);
        Vector4 v3 = new Vector4(9.0f, 10.0f, 11.0f, 12.0f);
        Vector4 v4 = new Vector4(13.0f, 14.0f, 15.0f, 16.0f);
        Matrix4x4 mat = new Matrix4x4(v1,v2,v3,v4);
        Debug.Log(mat[0,1]);
        Debug.Log(mat[1,1]);
        Debug.Log(mat[2,1]);
        Debug.Log(mat[3,1]);
    }
}
