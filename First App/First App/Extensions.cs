using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    public static class Extensions
    {
        public static int Max(this string[] values, Func<string, int> selector)
        {
            int max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                int value = selector.Invoke(values[i]);
                max = value > max ? value : max;
            }
            return max;
        }
    }
}
