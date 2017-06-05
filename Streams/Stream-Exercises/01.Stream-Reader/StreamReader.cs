using System;
using System.IO;

namespace _01.Stream_Reader
{
    public class StreamReader
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader("sometext.txt"))
            {
                var lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine($"Line {lineNumber}: {line}");
                    line = reader.ReadLine();
                }
            }
        }
    }
}
