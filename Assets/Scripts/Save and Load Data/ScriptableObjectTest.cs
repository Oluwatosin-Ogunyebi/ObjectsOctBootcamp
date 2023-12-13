using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectTest : MonoBehaviour
{
    public ScriptableObjectSample sample;
    // Start is called before the first frame update
    void Start()
    {
        if (!sample)
        {
            return;
        }

        Debug.Log("Hello " +sample.objectName + " " + sample.score);
    }

}
