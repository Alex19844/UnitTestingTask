using System;
using System.Diagnostics.Metrics;

namespace CountingStringChars
{
    public static class ForMethods
    {
        /// <summary>
        /// Returns a number of characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of characters in a string.</returns>
        public static int GetCharCount(string? str)
        {
            // #1. Analyze the implementation of "GetCharCountRecursive" methods, and implement the method using the "for" loop statement.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// Returns a number of upper characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of upper characters in a string.</returns>
        public static int GetUpperCharCount(string? str)
        {
            // #2. Analyze the implementation of "GetUpperCharCountRecursive" methods, and implement the method using the "for" loop statement.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Returns maximum number of consecutive identical letters of the Latin alphabet in a line.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>Maximum number of consecutive identical letters of the Latin alphabet in a line.</returns>
        public static int GetConsecutIdentLatinCount(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                return 0;
            }

            if (str.Length == 1 && IsBasicLetter(str[0]))
            {
                return 1;
            }

            int maxCount = 0;
            int currentCount = 1;
            bool isLetter = false;

            for (int i = 1; i < str.Length; i++)
            {
                if (IsBasicLetter(str[i]) && IsBasicLetter(str[i - 1]))
                {
                    if (char.ToLower(str[i]) == char.ToLower(str[i - 1]))
                    {
                        currentCount++;
                    }
                    else
                    {
                        maxCount = Math.Max(maxCount, currentCount);
                        currentCount = 1;
                    }
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }

                if (IsBasicLetter(str[i]) || IsBasicLetter(str[i - 1]))
                {
                    isLetter = true;
                }
            }

            maxCount = Math.Max(maxCount, currentCount);
            if (!isLetter)
            {
                maxCount = 0;
            }

            return maxCount;
        }

        public static bool IsBasicLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        /// <summary>
        /// Returns maximum number of consecutive identical digits in a line.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>Maximum number of consecutive identical digits in a line.</returns>
        public static int GetConsecutIdentDigitsCount(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                return 0;
            }

            if (str.Length == 1 && char.IsDigit(str[0]))
            {
                return 1;
            }

            int currentCount = 1;
            int maxCount = 0;
            bool isDigit = false;

            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) && str[i] == str[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = char.IsDigit(str[i]) ? 1 : 0;
                }

                if (char.IsDigit(str[i]) || char.IsDigit(str[i - 1]))
                {
                    isDigit = true;
                }
            }

            maxCount = Math.Max(maxCount, currentCount);
            if (!isDigit)
            {
                maxCount = 0;
            }

            return maxCount;
        }


        /// <summary>
        /// Returns a number of characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of characters in a string.</returns>
        public static int GetCharCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetCharCountRecursive(str, 0);
        }

        /// <summary>
        /// Returns a number of upper characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of upper characters in a string.</returns>
        public static int GetUpperCharCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetUpperCharCountRecursive(str, 0);
        }

        private static int GetCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            return GetCharCountRecursive(str, index + 1) + 1;
        }

        private static int GetUpperCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            bool isUpper = char.IsUpper(str[index]);
            int currentIncrement = isUpper ? 1 : 0;

            return GetUpperCharCountRecursive(str, index + 1) + currentIncrement;
        }
    }
}
