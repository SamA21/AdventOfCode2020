using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = TextInputs.GetNumberListFromFile("Inputs\\Day1.txt", new List<int>());
            int targetNumber = 2020;
            numbers = numbers.Where(x => x <= targetNumber).ToList();//remove bigger than answer numbers    
            Expenses expenses = new Expenses();
            //part 1
            Console.WriteLine(expenses.TwoNumbers(numbers, targetNumber));
            //part 2
            Console.WriteLine(expenses.ThreeNumbers(numbers, targetNumber));

        }
    }
}
