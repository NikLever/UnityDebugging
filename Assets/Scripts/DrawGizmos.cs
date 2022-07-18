using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    public float size = 1f;
    Vector3 vsize;

    private void Start()
    {
        vsize = new Vector3(size, size, size);
    }

    private void OnValidate()
    {
        vsize.Set(size, size, size);    
    }

    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Vector3 position = transform.position + transform.TransformDirection(Vector3.forward) * 3;
        Gizmos.DrawWireCube(position, vsize);
    }
}
