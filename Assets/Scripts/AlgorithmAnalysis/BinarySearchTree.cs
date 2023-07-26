using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearchTree
{
    TreeNode root;
    
    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(float key, Transform value)
    {
        root = InsertRecursively(root, key, value);
    }
    private TreeNode InsertRecursively(TreeNode currentNode, float key, Transform value)
    {
        if (currentNode == null)
        {
            return new TreeNode(key, value);
        }
        if (key < currentNode.key)
        {
            currentNode.left = InsertRecursively(currentNode.left, key, value);
        }else if(key > currentNode.key)
        {
            currentNode.right = InsertRecursively(currentNode.right, key, value);
        }

        return currentNode;
    }

    public float FindMinKey()
    {
        TreeNode currentNode = root;

        while (currentNode.left != null)
        {
            currentNode = currentNode.left;
        }

        return currentNode.key;
    }

    public Transform FindTransformValue(float key)
    {
       return FindTransformValueRecursively(root, key);
    }

    private Transform FindTransformValueRecursively(TreeNode currentNode, float key)
    {
        if (currentNode == null)
        {
            return null;
        }

        if (currentNode.key == key)
        {
            return currentNode.value;
        }
        else if (key < currentNode.key)
        {
            return FindTransformValueRecursively(currentNode.left, key);
        }
        else
        {
            return FindTransformValueRecursively(currentNode.right, key);
        }
    }
}

public class TreeNode
{
    public float key;
    public Transform value;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(float key, Transform value)
    {
        this.key = key;
        this.value = value;
        this.left = null;
        this.right = null;
    }

}
