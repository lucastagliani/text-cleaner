using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextCleaner
{
    public class TextCleanerUtils
    {
        public string RemoveDoubleSpaces(string input) 
        {
            string output = input;

            if (!string.IsNullOrEmpty(output))
            {
                while (output.Contains("  "))
                {
                    output = output.Replace("  ", " ");
                }
            }

            return output;
        }

        public string RemoveHtmlTags(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return Regex.Replace(input, "<.*?>", string.Empty);
            }

            return input;
        }

        private string RemoveTripleSpaces(string input)
        {
            string output = input;

            if (!string.IsNullOrEmpty(output))
            {
                while (output.Contains("   "))
                {
                    output = output.Replace("   ", " ");
                }
            }

            return output;
        }
    }
}
