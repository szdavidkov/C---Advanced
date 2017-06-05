using System;
using System.IO;
using System.Text;

namespace _03.Writing_To_Files
{
    public class WritingToFiles
    {
        public static void Main()
        {
            var text = "Кирилица";
            var filesStream = new FileStream("../../log.txt",FileMode.Create);
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                filesStream.Write(bytes,0,bytes.Length);
            }
            finally 
            {
                filesStream.Close();
            }
        }
    }
}
