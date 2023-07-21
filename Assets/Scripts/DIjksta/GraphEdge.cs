using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(LineRenderer))]
public class GraphEdge : MonoBehaviour
{
    public GraphNode fromNode, toNode;
    public float cost;
    public GameObject costTextObject;

    private GameObject _costText;
    private LineRenderer _line;

    void Start()
    {
        _costText = Instantiate(costTextObject);
        _line = GetComponent<LineRenderer>();
        _line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        cost = Vector3.Distance(fromNode.transform.position, toNode.transform.position);
        DrawLine();
        _costText.GetComponent<TMP_Text>().SetText("" +  cost); 
    }

    void DrawLine()
    {
        _line.SetPosition(0,fromNode.transform.position);
        _line.SetPosition(0,toNode.transform.position);
        _costText.transform.position = (fromNode.transform.position + toNode.transform.position) / 2 + Vector3.up * 1.2f; ;
    }
}
