using System;


namespace LeetCodeTasks.Tasks
{
    public class Task35
    {
        
        public int SearchInsert(int[] nums, int target) 
        {
            const int errorFlag = -1;
            int length = nums.Length;
            int half = length / 2;
            int result = errorFlag;
            if (target > nums[half])
            {
                for (int i = Array.IndexOf(nums, nums[half]); i < length; i++)
                {
                    if (target == nums[i]) 
                    {
                        result = Array.IndexOf(nums, nums[i]);
                        return result;
                    }
                       
                   
                }
            }
            else if (target < nums[half])
            {
                for (int i = 0; i <= half; i++)
                {
                    if (target == nums[i])
                    {
                        result = Array.IndexOf(nums, nums[i]);
                        return result;
                    }
                    
                }
            }
            else if (target == nums[half])
            {
                result = Array.IndexOf(nums, nums[half]);
                return result;
            }

            if (result == errorFlag) 
            {
                int count = half;
                if (target > nums[length - 1]) 
                {
                    result = Array.IndexOf(nums, nums[length - 1]);
                    return result;
                }
                if (target < nums[0])
                {
                    result = 0;
                    return result;
                }
                if (target > nums[half]) 
                {
                   
                    while (target > nums[count]) 
                    {
                        count++;
                    }
                    result = Array.IndexOf(nums, nums[count]);
                    return result;
                }
                else if (target < nums[half])
                {
                   
                    while (target < nums[count])
                    {
                        count--;
                    }
                    result = Array.IndexOf(nums, nums[count])+1;
                    return result;
                }
            }

            return result;
            
        }
    }
}
