/// <summary>
/// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
/// Find two lines that together with the x-axis form a container, such that the container contains the most water.
/// Return the maximum amount of water a container can store.
/// Notice that you may not slant the container.
/// https://leetcode.com/problems/container-with-most-water/description/
/// </summary>
/// 
class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        // Two pointer algorithm
        int maxArea = 0;
        int leftIndex = 0;
        int rightIndex = height.Length - 1;

        while (leftIndex < rightIndex)
        {
            // Calculate current area
            int width = rightIndex - leftIndex; 

            // Comparing the height of the two big nodes, the smaller height should be chosen,
            // as water can only fit inside the container with the shortest height
            int minHeight = Math.Min(height[leftIndex], height[rightIndex]); 
            int currentArea = width * minHeight;

            // Update max area if current area is larger
            if (currentArea > maxArea)
            {
                maxArea = currentArea;
                int indexLeft = leftIndex;
                int indexRight = rightIndex;
            }

            // Move the pointer pointing to the smaller height
            if (height[leftIndex] < height[rightIndex])
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }

        return maxArea;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContainerWithMostWater container = new();
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        int maxArea = container.MaxArea(height);
        Console.WriteLine(maxArea); // Output: 49
    }
}