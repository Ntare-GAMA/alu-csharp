using System;

namespace Text
{
    /// <summary>
    /// Provides string utility operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string.
        /// </summary>
        /// <param name="s">A camelCase string.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int count = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                    count++;
            }

            return count;
        }
    }
}