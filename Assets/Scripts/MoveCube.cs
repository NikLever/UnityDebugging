using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Transform npc;

    private Vector3 origin;
    private Material material;
    
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        material = GetComponent<Renderer>().material;

        //Debug.LogFormat("The origin position is {0}. ", origin);
        //Debug.LogFormat("At Start transform.position={0}, transform.rotation={1}", transform.position, transform.rotation);
        Debug.LogWarning("This is a warning message");
        Debug.LogError("This is an error message");

        float theta = Mathf.Sin(1) + Mathf.PI;
        //Debug.LogFormat("pi = {0}", Mathf.PI);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x = origin.x + Mathf.Sin(Time.time) * 5;
        
        if (pos.x < 0)
        {
            SetColor(Color.blue);
        }
        else
        {
            SetColor(Color.red);
        }

        transform.position = pos;

        float dist = Vector3.Distance(transform.position, npc.position);
        //Debug.LogFormat("dist = {0:0.00}", dist);

        if ( dist < 5) Debug.Break();

    }

    void SetColor(Color color)
    {
        Debug.Assert(material != null, "SetColor: material not assigned");

        material.SetColor("_Color", color);
    }
}
