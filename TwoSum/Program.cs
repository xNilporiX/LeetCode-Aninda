using System;
using System.Collections.Generic;

/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// 
/// Example 1:
/// Input: nums = [2,7,11,15], target = 9
/// Output: [0,1]
/// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
/// Example 2:

/// Input: nums = [3,2,4], target = 6
/// Output: [1,2]
/// Example 3:

/// Input: nums = [3,3], target = 6
/// Output: [0,1]
/// </summary>

public class MySolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = [];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return result = [i, j];
                }
            }
        }
        return [];
    }
}

public class BestSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = [];
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement))
            {
                return result = [numMap[complement], i];
            }
            numMap[nums[i]] = i;
        }
        return [];
    }
}

class Program
{
    static void Main()
    {
        MySolution solution = new MySolution();

        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        try
        {
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}