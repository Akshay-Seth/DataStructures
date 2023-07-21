using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GraphNode : MonoBehaviour
{
    [HideInInspector] public List<GraphEdge> edges = new List<GraphEdge>();

    public GameObject _graphNodeNameObject;

    GameObject _graphNodeName;

    private void Awake()
    {
        _graphNodeName = Instantiate(_graphNodeNameObject);
        _graphNodeName.GetComponent<TMP_Text>().SetText(gameObject.name);

        //Adding all the edges to the node
        foreach (GraphEdge edge in FindObjectsOfType(typeof(GraphEdge)))
        {
            //if (edge.)
            //{

            //}
        }
    }
    void Update()
    {
        _graphNodeName.transform.position = transform.position + Vector3.up * 1.2f;
    }
}
