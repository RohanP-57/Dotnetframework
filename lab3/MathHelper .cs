using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
    internal static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array must not be null or empty.", nameof(numbers));

            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
    }
}
