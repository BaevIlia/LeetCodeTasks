using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Tasks
{
    public class Task29
    {
        public int Divide(int dividend, int divisor) 
        {

            #region Решение в столбик
            //Решение в столбик - занимает очень много времени на больших числах
            /*if (dividend == int.MinValue && divisor == -1) 
            {
                return int.MaxValue;
            }

            long count = 0;
            bool isNegative = (dividend < 0) ^ (divisor < 0);
            long positiveDividend = Math.Abs((long)dividend);
            long positiveDivisor = Math.Abs((long)divisor);
            long closeNumber = positiveDivisor;
            while (closeNumber <= positiveDividend) 
            {
                closeNumber += positiveDivisor;
                count++;
            } 


            if (isNegative) 
            {
                return -Math.Abs((int)count);
            }

            return Math.Abs((int)count);*/
            #endregion

            #region Решение с битовым сдвигом
            if (dividend == int.MinValue && divisor == -1) 
            {
                return int.MaxValue;
            }

            bool isNegative = (dividend < 0) ^ (divisor < 0);

            long absoluteDividend = Math.Abs((long)dividend);
            long absoluteDivisor = Math.Abs((long)divisor);

            int result = 0;

            while (absoluteDividend >= absoluteDivisor) 
            {
                long temp = absoluteDivisor, multiple =1;
                while (absoluteDividend >= (temp << 1)) 
                {
                    temp <<= 1;
                    multiple <<= 1;

                }
                absoluteDividend -= temp;
                result += (int)multiple;
            }

            return isNegative ? -result : result;
            #endregion
        }
    }
}
