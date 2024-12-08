using System;
using UnityEngine;

namespace NoodleKit {
//[CreateAssetMenu(fileName = "PrimitivePrefabs", menuName = "Scriptable Objects/PrimitivePrefabs")]
public class PrimitivePrefabs : ScriptableObject {

    public GameObject[] prefabs;

    private void Awake() {
        instance = this;
    }

    private void OnEnable() {
        instance = this;
    }

    public static PrimitivePrefabs instance { get; private set; }

}
}