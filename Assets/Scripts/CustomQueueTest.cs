using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomQueueTest : MonoBehaviour
{
    void Start()
    {
        CustomQueue<int> __ourCustomStack = new CustomQueue<int>();

        __ourCustomStack.Enqueue(10);
        __ourCustomStack.Enqueue(15);
        __ourCustomStack.Enqueue(20);
        __ourCustomStack.Enqueue(30);
        __ourCustomStack.Enqueue(45);
        __ourCustomStack.Enqueue(50);

        Debug.Log("Is the Queue Empty? " + __ourCustomStack.IsEmpty());

        Debug.Log("Popping the Queue " + __ourCustomStack.Dequeue());
        Debug.Log("Popping the Queue " + __ourCustomStack.Dequeue());
        Debug.Log("Popping the Queue " + __ourCustomStack.Dequeue());
        Debug.Log("Popping the Queue " + __ourCustomStack.Dequeue());
        Debug.Log("Popping the Queue " + __ourCustomStack.Dequeue());
        Debug.Log("Popping the Queue " + __ourCustomStack.Dequeue());
        Debug.Log("Popping the Queue " + __ourCustomStack.Dequeue());
    }
}
