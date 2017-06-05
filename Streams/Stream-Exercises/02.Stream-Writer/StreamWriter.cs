using System;
using System.IO;

namespace _02.Stream_Writer
{
    public class StreamWriter
    {
        public static void Main()
        {
            using (var reader = new StreamReader("../../Program.cs"))
            {
                using (var writer = new StreamWriter("../../reversed.txt"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        for (int i = line.Length - 1; i >= 0; i--)
                        {
                            writer.Write(line[1]);
                        }

                        writer.WriteLine();
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
