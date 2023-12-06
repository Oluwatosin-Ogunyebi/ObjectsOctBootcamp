using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    public GameObject testPrefab;

    public Stack<GameObject> stack = new Stack<GameObject>();

    GameObject tempObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            //Push a new object to the queue
            tempObject = Instantiate(testPrefab, transform);
            tempObject.transform.position = new Vector2(stack.Count, 0); //Calculate testPrefab position

            tempObject.name = "STACKED-" + stack.Count;
            tempObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV();

            stack.Push(tempObject);

            Debug.Log("Pushed " + tempObject.name);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            var removedObject = stack.Pop();
            Debug.Log("Popped from the queue: " + removedObject.name);
            Destroy(removedObject);
        }

        if(Input.GetKeyUp(KeyCode.D))
        {   
            var topGameObject = stack.Peek();
            topGameObject.GetComponent<SpriteRenderer>().color = Color.black;
            Debug.Log("Object at the top of the queue is " + topGameObject.name);
        }

    }
}
