using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    List<int> _integerList;

    List<SomeData> _someData = new List<SomeData>();
    // Start is called before the first frame update
    void Start()
    {
        InitializeList();
    }
    
    void InitializeList() 
    {
        _integerList = new List<int>();
        Debug.Log($"The length of the list is {_integerList.Count} " +
            $"and the capacity is {_integerList.Capacity}");

        _integerList.Add(2);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _integerList.Add(Random.Range(0, 8));
            Debug.Log($"The length of the list is {_integerList.Count} " +
    $"and the capacity is {_integerList.Capacity}");

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            _integerList.Remove(2);

            Debug.Log($"The Remove function is being used. The length of the list is {_integerList.Count} " +
    $"and the capacity is {_integerList.Capacity}");

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            _integerList.RemoveAt(2);

            Debug.Log($"The RemoveAt MEthod is being used. The length of the list is {_integerList.Count} " +
    $"and the capacity is {_integerList.Capacity}");

        }
    }
}
