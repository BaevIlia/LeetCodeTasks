namespace LeetCodeTasks.Tasks;

public class Task1001
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int right = -1;
        int result = 0;
        int zerosCount = 0;

        while (left < nums.Length)
        {
            while (right + 1 < nums.Length && (nums[right + 1] == 1 || zerosCount < k))
            {
                if (nums[right + 1] == 0)
                {
                    zerosCount++;
                }
                right++;
            }
            result = Math.Max(result, right - left + 1);

            if (nums[left] == 0)
                zerosCount--;
            left++;
        }
        return result;
    }
}