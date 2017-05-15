using System;
using System.Collections.Generic;
using System.Linq;

namespace CrackingInterview.Chapter_1.Unique_String
{
    /* Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
     * Questions to ask:
     * What constitues an unique character? Is a lower case letter treated as unique from its upper case counterpart? 
     * What is the character set? ASCII or Unicode? 
     * Does the string only contain characters Aa-Zz? Or are there numbers, special characters, etc?
     * Is an empty string considered unique? 
     * Considering we're using C#, don't have to worry about null-terminator - ask if we need to use c-style string */
    public static class IsUniqueTest
    {
        private static HashSet<char> Hash { get;  } = new HashSet<char>();

        /* Run-time complexity of this is O(n); space-time complexity is O(n), where n is size of string*/
        /* This method does not consider the character set; either should work. Null terminator doesn't matter. Empty string is considered unique, so will return true.
             * Lower case is separate from upper case. */
        public static bool IsStringUnique(string testString)
        {
            Hash.Clear();

            foreach (char c in testString)
            {
                if (!Hash.Add(c)) return false;
            }
            
            return true;
        }

        /* Run-time complexity of this is O(n); space-time complexity is O(n), where n is size of string */
        /* This method does not consider the character set; either should work. Null terminator doesn't matter. Empty string is considered unique, so will return true.
             * Lower case is separate from upper case. */
        public static bool IsStringUniqueLinq(string testString)
        {
            Hash.Clear();
            
            return testString.All(c => Hash.Add(c));
        }

        /* Run-time complexity of this is O(n); space-time complexity is only O(1), where n is size of string */
        /* This method will only work if we treat lower-case and upper case as the same, and if we assume the characters are bounded between Aa-Zz */
        public static bool IsStringUniqueBitVector(string testString)
        {
            /* Since this method assumes no characters outside A-Z, we can return early */
            if (testString.Length > 26) return false;

            int checker = 0; /* 32-bit integer */

            foreach (char c in testString)
            {
                int val = Char.ToLower(c) - 'a';
                if ((checker & (1 << val)) > 0) return false;

                checker |= 1 << val;
            }
            return true;
        }

        /* This method will take O(n^2) time, but will use O(1) space */
        public static bool IsStringUniqueNoDataStruct(string testString)
        {
            for (int i = 0; i < testString.Length; i++)
            {
                for (int j = i + 1; j < testString.Length; j++)
                {
                    if (testString[i] == testString[j]) return false;
                }
            }

            return true;
        }

        public static bool IsStringUniqueNoDataStructSort(string testString)
        {
            /* Not implemented - but can use a O(n log n) sorting algorithm, and then a O(n) loop to check each char */
            return true;
        }
    }
}
