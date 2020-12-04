using System;
using System.Collections.Generic;
using System.IO;

namespace Helpers
{
    public static class TextInputs
    {
        public static List<int> GetNumberListFromFile(string fileLocation, List<int> output)
        {
            FileStream fileStream = new FileStream(fileLocation, FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (int.TryParse(line, out int number))
                    {
                        output.Add(number);
                    }
                }
            }
            return output;
        }
    }
}
