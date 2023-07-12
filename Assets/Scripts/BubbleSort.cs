using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    
    void Start()
    {
        int[] _array = { 5, 7, 2, 3, 6, 1, 8, 9 };

        DoBubbleSort(_array);
        string _arrayValue = "";
        for (int i = 0; i < _array.Length; i++)
        {
            _arrayValue += _array[i] + " , ";
        }

        Debug.Log($"The array is: {_arrayValue}");
    }

    static void DoBubbleSort(int[] _inputArray)
    {
        bool swapped;

        for (int i = 0; i < _inputArray.Length; i++)
        {
            swapped = false;

            for (int j = 0; j < _inputArray.Length -i -1; j++)
            {
                if (_inputArray[j] > _inputArray[j+1])
                {
                    int temp = _inputArray[j];
                    _inputArray[j] = _inputArray[j + 1];
                    _inputArray[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }

    }
}
