using System;

namespace Text
{
    /// <summary>
    /// Class for string operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>Index of first non-repeating character or -1 if none exists</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            int[] count = new int[26];
            
            foreach (char c in s)
                count[c - 'a']++;
            
            for (int i = 0; i < s.Length; i++)
                if (count[s[i] - 'a'] == 1)
                    return i;
            
            return -1;
        }
    }
}