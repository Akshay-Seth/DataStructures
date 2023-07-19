using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegerTree
{
    private IntegerTreeNode root;

    public IntegerTree()
    {
        root = null;
    }

    public void Insert(int parentValue, int childValue)
    {
        IntegerTreeNode parentNode = FindNode(root, parentValue);
        if (parentNode != null)
        {
            IntegerTreeNode childNode = new IntegerTreeNode(childValue);
            parentNode.children.Add(childNode);
        }else if (root == null)
        {
            root = new IntegerTreeNode(childValue);
        }
    }

    private IntegerTreeNode FindNode(IntegerTreeNode currentNode, int value)
    {
        if (currentNode == null)
        {
            return null;
        }

        if (currentNode.value == value)
        {
            return currentNode;
        }

        foreach (IntegerTreeNode childNode in currentNode.children)
        {
            IntegerTreeNode foundNode = FindNode(childNode, value);
            if (foundNode != null)
            {
                return foundNode; 
            }
        }

        return null;
    }

    public void Traverse()
    {
        TraverseRecursive(root);
    }

    private void TraverseRecursive(IntegerTreeNode currentNode)
    {
        if(currentNode != null)
        {
            Debug.Log(currentNode.value + " ");

            foreach (IntegerTreeNode child in currentNode.children)
            {
                TraverseRecursive(child);
            }
        }
    }
}

class IntegerTreeNode
{
    public int value;
    public List<IntegerTreeNode> children = new List<IntegerTreeNode>();

    public IntegerTreeNode(int value)
    {
        this.value = value;
    }
}
