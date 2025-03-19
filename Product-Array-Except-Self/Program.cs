// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
// You must write an algorithm that runs in O(n) time and without using the division operation.
// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
// You must write an algorithm that runs in O(n) time and without using the division operation.
// Example 1:

// Input: nums = [1, 2, 3, 4]
// Output: [24, 12, 8, 6]
// Example 2:

// Input: nums = [-1, 1, 0, -3, 3]
// Output: [0, 0, 9, 0, 0]
// https://leetcode.com/problems/product-of-array-except-self/description/
class ProductArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        // Here's the idea.
        // We will have an input of [1,2,3,4] when the index = 0, i.e nums[0] = 1, then multiply the rest of the array numbers 2*3*4 =24 amd same goes on.
        // Output = [24, 12, 8, 6]
        // We need to do this in 0(n) time.
        int n = nums.Length;
        int[] answer = new int[n];
        int[] prefixProduct = new int[n];
        int[] suffixProduct = new int[n];

        //  [1, 2, 3, 4]
        //  [1 , 1 , 2, 6 ] prefixproduct
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                prefixProduct[i] = 1;
            }
            else
            {
                prefixProduct[i] = prefixProduct[i - 1] * nums[i - 1];
            }
        }


        //  [1, 2, 3, 4]
        //  [24 , 12 , 4, 1] suffixProduct

        for (int i = n - 1; i >= 0; i--)
        {
            if (i == n - 1)
            {
                suffixProduct[i] = 1;
            }
            else
            {
                suffixProduct[i] = suffixProduct[i + 1] * nums[i + 1];
            }

            // Multiply prefix * suffix
            // P = [1 , 1 , 2, 6 ]
            // S = [24 , 12 , 4, 1]
            // [24, 12, 8, 6]
            answer[i] = prefixProduct[i] * suffixProduct[i];

        }

        return answer;
    }

};

public class Program
{
    public static void Main()
    {
        int[] nums = [1, 2, 3, 4];
        ProductArrayExceptSelf productArrayExceptSelf = new ProductArrayExceptSelf();
        var answer = productArrayExceptSelf.ProductExceptSelf(nums);
    }
}