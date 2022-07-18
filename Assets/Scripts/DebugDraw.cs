using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDraw : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        int pID = System.Diagnostics.Process.GetCurrentProcess().Id;
        Debug.LogFormat("PID: {0}", pID);
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) throw new System.NullReferenceException("target not set!");

        Debug.DrawLine(transform.position, target.position, Color.white, 0, false);
        Vector3 dir = target.transform.TransformDirection(Vector3.forward) * 3;
        Debug.DrawRay(target.transform.position, dir, Color.green, 0, false);
    }
}
