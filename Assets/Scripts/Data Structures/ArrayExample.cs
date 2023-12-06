using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public GameObject testPrefab;
    public GameObject[] array;

    public GameObject[] initialisedArray = new GameObject[3];

    //default length is zero
    // Start is called before the first frame update
    void Start()
    {
        GenerateArrayIndex(0);
        GenerateArrayIndex(1);
        GenerateArrayIndex(2);

    }

    private void GenerateArrayIndex(int index)
    {
        initialisedArray[index] = Instantiate(testPrefab, transform);
        initialisedArray[index].transform.position = new Vector2(index, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log($"The Length of Array is {initialisedArray.Length}");
        }

        if (Input.GetKeyUp(KeyCode.W))
        {   
            foreach(var item in initialisedArray)
            {
                item.GetComponent<SpriteRenderer>().color = Color.white;
            }
            initialisedArray[Random.Range(0, initialisedArray.Length)].GetComponent<SpriteRenderer>().color = Color.red;


        }
    }
}
