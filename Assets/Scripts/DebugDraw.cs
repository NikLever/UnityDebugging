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
        Debug.DrawLine(transform.position, target.position, Color.white, 0, false);
    }
}
