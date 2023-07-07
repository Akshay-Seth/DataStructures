using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomQueue<T>
{
    List<T> _customQueue;

    public CustomQueue()
    {
        _customQueue = new List<T>();
    }

    public void Enqueue(T item)
    {
        _customQueue.Add(item);
    }

    public T Dequeue()
    {
        if (_customQueue.Count <= 0)
        {
            Debug.LogError("Error! Cannot pop an empty queue");
        }

        T _removingItem = _customQueue[0];

        _customQueue.Remove(_removingItem);

        return _removingItem;
    }

    public bool IsEmpty()
    {
        return _customQueue.Count <= 0;
    }
}
