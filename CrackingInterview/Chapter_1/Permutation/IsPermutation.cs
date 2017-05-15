using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingInterview.Chapter_1.Permutation
{
    /* Given two strings, write a method to decide if one is a permutation of the other
    * Questions to ask:
    * Is it case sensitive? Does it ignore white space? 
    * What is the character set? ASCII or Unicode? 
    * Does the string only contain characters Aa-Zz? Or are there numbers, special characters, etc?
    * Is an empty string considered permutations? 
    * Considering we're using C#, don't have to worry about null-terminator - ask if we need to use c-style string */
    public static class IsPermutationTest
    {
        private static readonly HashSet<char> Hash = new HashSet<char>();

        /* This will take O(n) time and O(n) space. This method is case and white space sensitive */
        public static bool IsPermutationHash(string inputA, string inputB)
        {
            if (inputA.Length != inputB.Length) return false;

            Hash.Clear();

            foreach (char c in inputA) Hash.Add(c);

            foreach (char c in inputB)
            {
                if (Hash.Add(c)) return false;
            }

            return true;
        }

        private static string Sort(string input)
        {
            var ret = input.ToArray();
            Array.Sort(ret);

            return new string(ret);
        }

        /* Assume the Array.Sort method is average case O(n log n), this will also be method time. Requires additional O(n) space to sort the array. */
        public static bool IsPermutationSort(string inputA, string inputB)
        {
            if (inputA.Length != inputB.Length) return false;

            return Sort(inputA).Equals(Sort(inputB));
        }
    }
}
