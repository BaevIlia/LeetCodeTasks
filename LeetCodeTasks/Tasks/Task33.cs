using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Tasks
{
    public class Task33
    {
        public int Search(int[] nums, int target)
        {
            int leftPointer = 0;
            int rightPointer = nums.Length - 1;
            int middle = 0;
            while (leftPointer <= rightPointer) 
            {
                middle = (leftPointer + rightPointer) / 2;
                if (target == nums[middle]) 
                {
                    return middle;
                }
                if (nums[middle] >= nums[leftPointer])
                {
                    if (nums[leftPointer] <= target && target <= nums[middle])
                    {
                        rightPointer = middle - 1;
                    }
                    else
                    {
                        leftPointer = middle + 1;
                    }
                }
                else 
                {
                    if (nums[middle] <= target && target <= nums[rightPointer])
                    {
                        leftPointer = middle + 1;
                    }
                    else 
                    {
                        rightPointer = middle - 1;
                    }
                }
            }

            return -1;
        }
    }
}
