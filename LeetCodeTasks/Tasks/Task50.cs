﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Tasks
{
    public class Task50
    {
        
        public double MyPow(double x, int n)
        {

            double ans = 1.0;
            long num = n;
            if (n < 0)
            {
                num = -1 * num;
            };
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    x = x * x;
                    num = num / 2;
                }
                else
                {
                    ans = ans * x;
                    num = num - 1;
                }
            }
            if (n < 0)
            {
                return (double)(1.0) / (double)(ans);
            }
            return ans;
        }
    }
}
