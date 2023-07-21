using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DijkstraAlgorithm : MonoBehaviour
{   
    public List<GraphNode> nodes = new List<GraphNode>();

    public GraphNode startNode;
    public GraphNode targetNode;

    public LineRenderer pathLine;

    Dictionary<GraphNode,float> distances = new Dictionary<GraphNode,float>();
    Dictionary<GraphNode, GraphNode> previousNodes = new Dictionary<GraphNode, GraphNode>();

    private void Awake()
    {
        //Adding all the nodes to a list
        foreach(GraphNode node in FindObjectsOfType(typeof(GraphNode)))
        {
            nodes.Add(node);
        }
    }

    private void Update()
    {
        if (startNode == null || targetNode == null) return;
        CalculateDijkstra();
    }

    public void CalculateDijkstra()
    {
        //Initialize the distances and previous Nodes
        foreach (GraphNode node in nodes)
        {
            distances[node] = float.MaxValue;
            previousNodes[node] = null;
        }
        //Distance from the start node to itself is 0
        distances[startNode] = 0;

        //Create a priority queue for storing nodes to visit
        List<GraphNode> unvisitedNodes = new List<GraphNode>(nodes);

        while (unvisitedNodes.Count > 0)
        {
            //Find the node with the smallest distance
            GraphNode currentNode = null;
            foreach (GraphNode node in unvisitedNodes)
            {
                if (currentNode == null || distances[node] < distances[currentNode])
                {
                    currentNode = node;
                }
            }

            unvisitedNodes.Remove(currentNode);

            //Update distances to neighbouring nodes
            foreach (GraphEdge edge in currentNode.edges)
            {
                float distance = distances[currentNode] + edge.cost;

                //Choose the proper node
                GraphNode neighbourNode = currentNode == edge.fromNode ? edge.toNode : edge.fromNode;

                if (distance < distances[neighbourNode])
                {
                    distances[neighbourNode] = distance;
                    previousNodes[neighbourNode] = currentNode;
                }
            }
        }

        //Draw shortest path
        List<GraphNode> path  = new List<GraphNode>();

        GraphNode pathNode = targetNode;

        while (pathNode != null)
        {
            path.Insert(0, pathNode);
            pathNode = previousNodes[pathNode];
        }

        pathLine.positionCount = path.Count;


        for (int i = 0; i < path.Count; i++)
        {
            pathLine.SetPosition(i, path[i].transform.position);
        }
    }
}
