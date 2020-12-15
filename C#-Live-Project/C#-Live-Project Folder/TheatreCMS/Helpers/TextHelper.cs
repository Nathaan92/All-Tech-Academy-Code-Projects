using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;
using System.Windows;

namespace TheatreCMS.Helpers
{
    public static class TextHelper
    {
        public static string LimitCharacterCount(this string stringText, int maxChars)
        {
            if (stringText == null) return null;

            // If the max character wanted is less then the length of the bio it will return as is.
            if (stringText.Length <= maxChars)
            {
                return stringText;
            }
            else
            {
                return stringText.Length <= maxChars ? stringText : stringText.Substring(0, maxChars) + "...";
            }
        }

        public static string LimitWordCount(string stringText, int maxWordCount )
        {
            if (stringText == null) return stringText;

            // This replaces an double spaces with sigle spaces.
            stringText = stringText.Replace("  ", " ");

            // This creates an array of elements, split is telling the code to make whatever comes after the space an element 
            //and then the code is given a number maxWordCount which will only allow that many elements in and then adds them together.
            string query = stringText.Split(' ').Take(maxWordCount).Aggregate((a, b) => a + " " + b);

            int wordCount = stringText.Split(' ').Count();

            if (wordCount + 1 <= maxWordCount)
            {
                return stringText;
            }
            else
            {
                return query + "...";
            }
        }  
    }
}