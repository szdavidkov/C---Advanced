using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;


namespace CubicMessages
{
    public class CubicMessages
    {
        public static void Main()
        {
            var pattern = @"^(\d+)([a-zA-Z]+)([^a-zA-Z]*)$";

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "Over!")
            {
                var messageLenght = int.Parse(Console.ReadLine());

                var match = Regex.Match(inputLine, pattern);
                if (match.Success)
                {
                    var prefix = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var ending = String.Empty;

                    if (match.Groups[3].Value != "")
                    {
                        ending = match.Groups[3].Value;
                    }
                    if (message.Length != messageLenght)
                    {
                        continue;
                    }

                    var indexes = Regex.Replace(prefix + ending, @"\D*", String.Empty);

                    var sb = new StringBuilder();

                    foreach (var index in indexes)
                    {
                        var ind = int.Parse(index.ToString());
                        if (ind>= 0 && ind < messageLenght)
                        {
                            sb.Append(message[ind]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }
                    Console.WriteLine($"{message} == {sb}");
                }
            }
        }
    }
}
