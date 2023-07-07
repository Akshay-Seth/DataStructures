using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomStack<T> 
{
    //Use a list as a base data structure
    List<T> _customStack;

    public int Count
    {
        get
        {
            return _customStack.Count;
        }
    }
    public CustomStack()
    {
        _customStack = new List<T>();
        Debug.Log("Initialized a New Stack");
    }
    
    public void Push(T item)
    {
        _customStack.Insert(0, item);
    }

    public T Pop()
    {
        if (_customStack.Count <= 0)
        {
            Debug.LogError("Error! Cannot pop an empty stack");
        }

        T _removingItem = _customStack[0];

        _customStack.Remove(_removingItem);

        return _removingItem;
    }

    public bool IsEmpty()
    {
        return _customStack.Count <= 0;
    }

}