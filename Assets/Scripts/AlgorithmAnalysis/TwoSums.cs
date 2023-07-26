using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSums : MonoBehaviour
{
    int[] nums = { 2, 7, 11, 15 };
    int target = 9;
    // Start is called before the first frame update
    void Start()
    {
        int[] twoSum = CalculateTwoSum(nums, target);
        Debug.Log($"{twoSum[0]},{twoSum[1]}");
    }


    public int[] CalculateTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> num = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (num.ContainsKey(complement))
            {
                return new int[] {num[complement], i};
            }
            num[nums[i]] = i;   
        }
        return new int[0];
    }
}
