using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicProgramming : MonoBehaviour
{
    static int numOfTimesUsed;
    // Start is called before the first frame update
    void Start()
    {
        int n = 10;
        long fibonacciNumber = CalculateFibonacci(n);

        Debug.Log($"The {n}th Fibonacci number is: {fibonacciNumber}");

        n = 9;
       fibonacciNumber = CalculateFibonacci(n);

        Debug.Log($"The {n}th Fibonacci number is: {fibonacciNumber}");

        n = 5;
        fibonacciNumber = CalculateFibonacci(n);

        Debug.Log($"The {n}th Fibonacci number is: {fibonacciNumber}");
    }
    static long CalculateFibonacci(int n)
    {
        Dictionary<int, long> fibCache = new Dictionary<int, long>();

        return Fibonacci(n, fibCache);
    }
    static long Fibonacci(int n, Dictionary<int, long> cache)
    {
        if (cache.ContainsKey(n))
        {           
            numOfTimesUsed++;
            Debug.Log($"Used the cache! and it has been used {numOfTimesUsed} times");
            return cache[n];
        }

        long fibNumber;

        if (n <= 1)
        {
            fibNumber = n;
        }
        else
        {
            fibNumber = Fibonacci(n - 1, cache) + Fibonacci(n - 2, cache);
        }

        cache[n] = fibNumber;
        return fibNumber;
    }
}
