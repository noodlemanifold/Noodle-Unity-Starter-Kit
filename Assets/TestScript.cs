using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BoxCollider box = gameObject.AddComponent<BoxCollider>();//box holds the new BoxCollider that was added to this gameobject
        BoxCollider boxChild = transform.GetChild(0).GetComponent<BoxCollider>();//box2 holds the first BoxCollider found on this transform's 0th child.
        BoxCollider[] boxes = GetComponents<BoxCollider>();//boxes holds an array of all BoxColliders on this gameobject
        Destroy(box);//removes box from this gameobject before the next frame
        DestroyImmediate(box);//removes box from this gameobject *immediately*. worse for performance.
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
