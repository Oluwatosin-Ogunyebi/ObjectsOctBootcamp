using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    [SerializeField] private TMP_Text txtTriangle, txtSquare, txtCircle;

    public Dictionary<string, int> dictionary = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        dictionary.Add("Triangles", 0);
        dictionary.Add("Squares", 0);
        dictionary.Add("Circles", 0);
    }

    // Update is called once per frame
    void Update()
    {   
        //Add Triangles
        if (Input.GetKeyUp(KeyCode.Q))
        {
            if (dictionary.ContainsKey("Triangles"))
            {
                dictionary["Triangles"]++;
                txtTriangle.text = dictionary["Triangles"].ToString();
            }
        }

        //Add Squares
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (dictionary.ContainsKey("Squares"))
            {
                dictionary["Squares"]++;
                txtSquare.text = dictionary["Squares"].ToString();
            }
        }

        //Add Circles
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (dictionary.ContainsKey("Circles"))
            {
                dictionary["Circles"]++;
                txtCircle.text = dictionary["Circles"].ToString();
            }
        }
    }
}
