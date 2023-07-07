using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{       
    Dictionary<string, int> _highScores = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        AddDataToDIctionary();
        CheckIfKeyAvailable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddDataToDIctionary()
    {
        _highScores.Add("Albert", 255);
        _highScores.Add("Dragana", 406);
        _highScores.Add("Liliana", 26);
    }

    void CheckIfKeyAvailable()
    {
        if (_highScores.ContainsKey("Albert"))
        {
            Debug.Log("Albert got " + _highScores["Albert"]);
        }
        else
        {
            Debug.Log("Nothing here");
        }
    }
}
