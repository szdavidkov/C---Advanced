using System;
using System.IO;

namespace _04.File_Copy
{
    public class FileCopy
    {
        private const string RihannaImagePath = "../../rihanna.jpg";
        private const string DestinationPath = "../../result.txt";

        public static void Main()
        {
            using (var source = new FileStream(RihannaImagePath,FileMode.Open))
            {
                using (var destination = new FileStream(DestinationPath,FileMode.Create))
                {
                    double fileLenght = source.Length;
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buffer,0,readBytes);
                        Console.WriteLine("{0:P}", Math.Min(source.Position / fileLenght, 1));
                    }
                }
            }
        }
    }
}
