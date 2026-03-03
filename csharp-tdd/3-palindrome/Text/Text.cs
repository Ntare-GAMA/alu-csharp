using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Provides string utility operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines whether a given string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is a palindrome, false otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null) return false;

            string cleaned = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}