using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] _array = { 5, 7, 2, 3, 6, 1, 8, 9 };

        DoQuickSort(_array, 0, _array.Length - 1);
        string _arrayValue = "";
        for (int i = 0; i < _array.Length; i++)
        {
            _arrayValue += _array[i] + " , ";
        }

        Debug.Log($"The array is: {_arrayValue}");
    }

    static void DoQuickSort(int[] _array, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            int partitionIndex = Partition(_array, lowIndex, highIndex);

            DoQuickSort(_array, lowIndex, partitionIndex - 1);
            DoQuickSort(_array, partitionIndex + 1, highIndex);
        }
    }

    static int Partition(int[] _array, int lowIndex, int highIndex)
    {
        int pivot = _array[highIndex];
        int i = lowIndex - 1;

        for (int j = lowIndex; j < highIndex; j++)
        {
            if (_array[j] <= pivot)
            {
                i++;

                //Swap Elements
                int temp = _array[i];
                _array[i] = _array[j];
                _array[j] = temp;
            }
        }

        //Swap pivot with the element at the correct position
        int temp2 = _array[i + 1];
        _array[i + 1] = _array[highIndex];
        _array[highIndex] = temp2;

        return i + 1;
    }
}
