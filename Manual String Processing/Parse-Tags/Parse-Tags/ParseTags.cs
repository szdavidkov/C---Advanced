using System;
using System.Collections.Generic;
using System.Linq;

namespace Parse_Tags
{
    public class ParseTags
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            var openTag = "<upcase>";
            var closeTags = "</upcase>";

            var startIndex = inputText.IndexOf(openTag);
            while (startIndex != -1)
            {
                var endIndex = inputText.IndexOf(closeTags);
                if (endIndex == -1)
                {
                    break;
                }

                var toBeReplaced = inputText.Substring(startIndex, endIndex + closeTags.Length - startIndex);

                var replaced = toBeReplaced.Replace(openTag, String.Empty).Replace(closeTags, String.Empty).ToUpper();

                inputText = inputText.Replace(toBeReplaced, replaced);
                startIndex = inputText.IndexOf(openTag);
            }
            Console.WriteLine(inputText);
        }
    }
}
