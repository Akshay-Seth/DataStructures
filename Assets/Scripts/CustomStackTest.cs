using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomStackTest : MonoBehaviour
{

    void Start()
    {
        CustomStack<int> __ourCustomStack = new CustomStack<int>();

        __ourCustomStack.Push(10);
        __ourCustomStack.Push(15);
        __ourCustomStack.Push(20);
        __ourCustomStack.Push(30);
        __ourCustomStack.Push(45);
        __ourCustomStack.Push(50);

        Debug.Log("Is the stack Empty? " + __ourCustomStack.IsEmpty());

        Debug.Log("Popping the stack " + __ourCustomStack.Pop());
        Debug.Log("Popping the stack " + __ourCustomStack.Pop());
        Debug.Log("Popping the stack " + __ourCustomStack.Pop());
        Debug.Log("Popping the stack " + __ourCustomStack.Pop());
        Debug.Log("Popping the stack " + __ourCustomStack.Pop());
        Debug.Log("Popping the stack " + __ourCustomStack.Pop());
        Debug.Log("Popping the stack " + __ourCustomStack.Pop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
