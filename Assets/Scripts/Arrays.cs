using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //Declare Arrays
    int[] _integerArray;
    string[] _stringArray;
    float[] _floatArray;

    SomeData[] _someData;
    // Start is called before the first frame update
    void Start()
    {
        CreatePrimitiveArrays();
        UpdateArrayValues();
        CreateCUstomArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreatePrimitiveArrays()
    {
        _integerArray = new int[5];
        for (int i = 0; i < _integerArray.Length; i++)
        {
            Debug.Log("Integer value is " + _integerArray[i]);
        }
        _integerArray = new int[4] { 1, 2, 3,4};
        for (int i = 0; i < _integerArray.Length; i++)
        {
            Debug.Log("Integer value after second array is " + _integerArray[i]);
        }

        _stringArray = new string[5];
        for (int i = 0; i < _stringArray.Length; i++)
        {
            Debug.Log("String value array is " + _stringArray[i]);
        }

        _stringArray = new string[] { "hello", "world" };
    }

    public void UpdateArrayValues()
    {
        _integerArray[0] = 15;
        // _integerArray[15] = 0;: Will lead to error in play mode

        _integerArray = new int[20];
        _integerArray[15] = 0;
    }

    public void CreateCUstomArray()
    {
        _someData = new SomeData[4];

        SomeData data1 = new SomeData();
        _someData[0] = data1;
        data1._id = 20;

    }
}
