using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Tasks
{
    public class Task3
    {
        public int LengthOfLongestSubstring(string s) 
        {
            List<char> chars = new();

            int left = 0;
            int maxLength = 0;
            for (int right = 0; right < s.Length; right++)
            {
                if (!chars.Contains(s[right]))
                {
                    chars.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                }
                else
                {
                    while (s[left] != (s[right]))
                    {
                        chars.Remove(s[left]);
                        left++;
                    }
                    chars.Remove(s[left]);
                    left++;
                    chars.Add(s[right]);
                }
            }
            return maxLength;

            
        }
    }
}
