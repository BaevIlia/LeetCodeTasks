using System;


namespace LeetCodeTasks.Tasks
{
    public class Task27
    {
        public int RemoveElement(int[] nums, int val) 
        {

            //Не проходит тесты
            /*int[] newNums = nums.Where(i=>i!=val).ToArray();
            return newNums.Length;*/

            int k = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] != val) 
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }

    }
}
