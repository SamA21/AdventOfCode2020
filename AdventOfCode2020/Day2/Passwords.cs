using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    public class Passwords
    {
        public int GetValidPolicys(List<string> passwords)
        {
            int validPolicys = 0;

            foreach(var pass in passwords)
            {
                string[] splitPass = pass.Split(':');
                string[] numbers = splitPass[0].Split(' ')[0].Split('-');
                int min = int.Parse(numbers[0]);
                int max = int.Parse(numbers[1]);
                string letter = splitPass[0].Split(' ')[1];
                char charConversion = letter.ToCharArray()[0];
                int count = splitPass[1].Count(x => x == charConversion);

                if(count >= min && count <= max)
                {
                    validPolicys++;
                }
            }

            return validPolicys;

        }

        public int GetValidPolicysDay2(List<string> passwords)
        {
            int validPolicys = 0;

            foreach (var pass in passwords)
            {
                string[] splitPass = pass.Split(':');
                string[] numbers = splitPass[0].Split(' ')[0].Split('-');
                int firstIndex = int.Parse(numbers[0]);
                int secondIndex = int.Parse(numbers[1]);
                string letter = splitPass[0].Split(' ')[1];
                string word = splitPass[1].Trim();
                char charConversion = letter.ToCharArray()[0];
                if (word[firstIndex-1] == charConversion)
                {
                    if (word[secondIndex - 1] != charConversion)
                    {
                        validPolicys++;
                    }
                }
                else
                {
                    if(word[secondIndex - 1] == charConversion)
                    {
                        validPolicys++;
                    }
                }
            }

            return validPolicys;

        }
    }
}
