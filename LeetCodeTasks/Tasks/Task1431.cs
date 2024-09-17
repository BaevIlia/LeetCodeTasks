using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Tasks
{
    public class Task1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
        {
            int maxCandies = candies.Max();
            List<bool> resultList = new();
            foreach (var c in candies) 
            {
                if (c + extraCandies >= maxCandies)
                {
                    resultList.Add(true);
                }
                else 
                {
                    resultList.Add(false);
                }
            }
            return resultList;
        }
    }
}
