using System;

namespace ExtensionsMethods
{
    public static class StringExtension
    {
        public static string FirstToUpper(this String str)
        {
            string firstLetter = str.Substring(0, 1);

            string secondLetter = str.Substring(1);

            return firstLetter.ToUpper() + secondLetter;
        }
    }
}