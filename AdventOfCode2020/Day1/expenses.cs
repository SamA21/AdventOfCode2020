using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class Expenses
    {
        public int? TwoNumbers(List<int> numbers, int targetNumber)
        {
            foreach (var first in numbers)
            {
                foreach (var second in numbers)
                {
                    if (first + second == targetNumber)
                    {
                        return first * second;
                    }
                }
            }
            return null;
        }

        public int? ThreeNumbers(List<int> numbers, int targetNumber)
        {
            foreach (var first in numbers)
            {
                foreach (var second in numbers)
                {
                    foreach (var third in numbers)
                    {
                        if (first + second + third == targetNumber)
                        {
                            return first * second * third;
                        }
                    }
                }
            }
            return null;
        }
    }
}
