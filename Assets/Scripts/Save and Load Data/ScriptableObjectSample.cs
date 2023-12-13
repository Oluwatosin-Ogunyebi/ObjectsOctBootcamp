using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SciptableObjectTest", menuName = "OT/Create Scri[ptable Object",order = 1)]
public class ScriptableObjectSample : ScriptableObject
{
    public string objectName;
    public int score;
    public Vector2 startPosition;
}
