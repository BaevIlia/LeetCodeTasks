using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Tasks
{
    public class Task17
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> resultList = new();
            if (string.IsNullOrWhiteSpace(digits))
                return resultList;


            Dictionary<char, string> numbersLetters = new()
            {
                {'2', "abc" },
                {'3', "def" },
                {'4', "ghi" },
                {'5', "jkl" },
                {'6', "mno" },
                {'7', "pqrs"},
                {'8', "tuv" },
                {'9', "wxyz" }


            };

            resultList.Add("");
            for (int i = 0; i < digits.Length; i++)
            {
                resultList = resultList.SelectMany(x => numbersLetters[digits[i]].Select(y => x + y.ToString())).ToList();
            }


            
            return resultList;
        }
    }
}
