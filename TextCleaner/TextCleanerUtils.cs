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
        public string RemoveDoubleSpaces(string text) 
        {
            string output = text;

            if (!string.IsNullOrEmpty(output))
            {
                while (output.Contains("  "))
                {
                    output = output.Replace("  ", " ");
                }
            }

            return output;
        }

        public string RemoveHtmlTags(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return Regex.Replace(text, "<.*?>", string.Empty);
            }

            return text;
        }

        private string RemoveTripleSpaces(string text)
        {
            string output = text;

            if (!string.IsNullOrEmpty(output))
            {
                while (output.Contains("   "))
                {
                    output = output.Replace("   ", " ");
                }
            }

            return output;
        }

        public string RemoveExcessLineBreakers(string text)
        {
            if (text == null)
            {
                return string.Empty;
            }

            while (text.Contains("\r\n\r\n"))
            {
                text = text.Replace("\r\n\r\n", "\r\n");
            }

            return text;
        }





















        //public string RemoveExcessLineBreakers(string text)
        //{
        //    if (string.IsNullOrEmpty(text))
        //    {
        //        return string.Empty;
        //    }

        //    while (text.Contains("\r\n\r\n"))
        //    {
        //        text = text.Replace("\r\n\r\n", "\r\n");
        //    }

        //    return text;
        //}
    }
}
