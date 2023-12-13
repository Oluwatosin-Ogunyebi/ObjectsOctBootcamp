using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTest : MonoBehaviour
{
    public LineRenderer v1Line;
    public LineRenderer v2Line;
    public LineRenderer crossProductLine;

    public Transform v1;
    public Transform v2;

    public bool isNormalize;

    Vector3 crossProduct;
    float dotProduct;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawLine();
        crossProduct = Vector3.Cross(v1.position, v2.position);
        dotProduct = Vector3.Dot(v1.position, v2.position);
        Debug.Log("Cross Product Value is: " +  crossProduct);
        Debug.Log("Dot Product Value is: " +  dotProduct);
        CrossProductDrawLine(crossProduct);
    }

    void DrawLine()
    {
        v1Line.SetPosition(0, transform.position);
        v1Line.SetPosition(1, v1.position);

        v2Line.SetPosition(0, transform.position);
        v2Line.SetPosition(1, v2.position);
    }

    void CrossProductDrawLine(Vector3 value)
    {
        crossProductLine.SetPosition(0, transform.position);
        crossProductLine.SetPosition(1, value);
    }
}
