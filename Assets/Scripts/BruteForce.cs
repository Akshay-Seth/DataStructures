using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteForce : MonoBehaviour
{

    void Start()
    {
        int _key = Random.Range(0, 9999);
        Debug.Log($"The key to check is: {_key} and the current time passed is {Time.time}");

        //Check all possibilities until key is found
        int _keyCheck = 0;
        while (_keyCheck != _key)
        {
            _keyCheck++;
        }
        Debug.Log($"Key Found is {_keyCheck} at {Time.time}");
    }

}
