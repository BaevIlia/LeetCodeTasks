using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Tasks
{
    public class Task283
    {
        public void MoveZeroes(int[] nums) 
        {
            int temp = 0;
            

            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = 0; j < nums.Length - i - 1; j++) 
                {
                    int leftPointer = j;
                    int rightPointer = j + 1;
                    if (nums[leftPointer] == 0 && nums[rightPointer] != 0)
                    {
                        temp = nums[rightPointer];
                        nums[rightPointer] = nums[leftPointer];
                        nums[leftPointer] = temp;
                    }
                }
               
            }
        }
    }
}
