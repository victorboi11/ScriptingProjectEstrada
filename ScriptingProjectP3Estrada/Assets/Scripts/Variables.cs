using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Variables : MonoBehaviour
{

    public int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MultiplyByTwo(int num)
    {
        int result;
        result = num * 2;
        return result;
    }
}