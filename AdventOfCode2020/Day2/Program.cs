using Helpers;
using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> passwords = TextInputs.GeStringListFromFile("Inputs\\Day2.txt", new List<string>());
            Passwords pass = new Passwords();
            //Part 1
            int valid = pass.GetValidPolicys(passwords);
            Console.WriteLine(valid);
            //Part 2
            int validDay2 = pass.GetValidPolicysDay2(passwords);
            Console.WriteLine(validDay2);
        }
    }
}
