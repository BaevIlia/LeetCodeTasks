namespace LeetCodeTasks;

public class Task643
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int windowSum = 0;
        for (int i = 0; i < k; i++)
        {
            windowSum += nums[i];
        }

        double maxSum = windowSum;

        for (int r = k; r < nums.Length; r++)
        {
            int l = r - k;
            windowSum = windowSum + nums[r] - nums[l];
            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum / k;
    }
}