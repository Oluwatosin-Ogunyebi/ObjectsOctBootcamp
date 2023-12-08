using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class JSONTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Serializing Data to JSON

        SampleData sample = new SampleData();
        sample.name = "Rico";
        sample.score = 20;

        string data = JsonUtility.ToJson(sample);

        Debug.Log(data);

        //Deserializing JSON to Data
        string json = "{\n\t\"name\": \"Rico\", \n\t\"score\": 20\n}";

        SampleData sample2 = JsonUtility.FromJson<SampleData>(json);

        Debug.Log("The sample data is " + sample2.name + " and " + sample2.score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
