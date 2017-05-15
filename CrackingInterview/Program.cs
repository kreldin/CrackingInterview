using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CrackingInterview.Chapter_1.Unique_String;
using CrackingInterview.Chapter_1.Permutation;

namespace CrackingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProblem1();
            Console.WriteLine();
            RunProblem2();

            Console.ReadLine();
        }

        static void RunProblem1()
        {
            Console.WriteLine("Problem 1 - Unique String");
            if (!IsUniqueTest.IsStringUnique("Hello, my Name is Robert!")) Console.WriteLine("Pass 1");
            if (IsUniqueTest.IsStringUnique("")) Console.WriteLine("Pass 2");
            if (IsUniqueTest.IsStringUnique("AbCdEfGhIjKlMnOpqRstUvWxYz")) Console.WriteLine("Pass 3");
            if (IsUniqueTest.IsStringUnique("AaBbCc")) Console.WriteLine("Pass 4");
            if (IsUniqueTest.IsStringUnique("A")) Console.WriteLine("Pass 4a");

            if (!IsUniqueTest.IsStringUniqueLinq("Hello, my Name is Robert!")) Console.WriteLine("Pass 5");
            if (IsUniqueTest.IsStringUniqueLinq("")) Console.WriteLine("Pass 6");
            if (IsUniqueTest.IsStringUniqueLinq("AbCdEfGhIjKlMnOpqRstUvWxYz")) Console.WriteLine("Pass 7");
            if (IsUniqueTest.IsStringUniqueLinq("AaBbCc")) Console.WriteLine("Pass 8");
            if (IsUniqueTest.IsStringUniqueLinq("A")) Console.WriteLine("Pass 8a");

            if (!IsUniqueTest.IsStringUniqueBitVector("hello!")) Console.WriteLine("Pass 9");
            if (!IsUniqueTest.IsStringUniqueBitVector("robert")) Console.WriteLine("Pass 10");
            if (IsUniqueTest.IsStringUniqueBitVector("")) Console.WriteLine("Pass 11");
            if (!IsUniqueTest.IsStringUniqueBitVector("Aa")) Console.WriteLine("Pass 12");
            if (IsUniqueTest.IsStringUniqueBitVector("A")) Console.WriteLine("Pass 13");
            if (IsUniqueTest.IsStringUniqueBitVector("AbCDeFgHIJKlmnOPqRstUvWxYz")) Console.WriteLine("Pass 13a");
            if (!IsUniqueTest.IsStringUniqueBitVector("AbCDeFgHIJKlmnOPqRstUvWxYzZZZZ")) Console.WriteLine("Pass 13b");

            if (!IsUniqueTest.IsStringUniqueNoDataStruct("Hello, my Name is Robert!")) Console.WriteLine("Pass 14");
            if (IsUniqueTest.IsStringUniqueNoDataStruct("")) Console.WriteLine("Pass 15");
            if (IsUniqueTest.IsStringUniqueNoDataStruct("AbCdEfGhIjKlMnOpqRstUvWxYz")) Console.WriteLine("Pass 16");
            if (IsUniqueTest.IsStringUniqueNoDataStruct("AaBbCc")) Console.WriteLine("Pass 17");
            if (IsUniqueTest.IsStringUniqueNoDataStruct("A")) Console.WriteLine("Pass 18");

            if (!IsUniqueTest.IsStringUniqueNoDataStructSort("Hello, my Name is Robert!")) Console.WriteLine("Pass 19");
            if (IsUniqueTest.IsStringUniqueNoDataStructSort("")) Console.WriteLine("Pass 20");
            if (IsUniqueTest.IsStringUniqueNoDataStructSort("AbCdEfGhIjKlMnOpqRstUvWxYz")) Console.WriteLine("Pass 21");
            if (IsUniqueTest.IsStringUniqueNoDataStructSort("AaBbCc")) Console.WriteLine("Pass 22");
            if (IsUniqueTest.IsStringUniqueNoDataStructSort("A")) Console.WriteLine("Pass 23");
        }

        static void RunProblem2()
        {
            Console.WriteLine("Problem 2 - Permutations");
            if (IsPermutationTest.IsPermutationHash("Hello", "Hello")) Console.WriteLine("Pass 1");
            if (!IsPermutationTest.IsPermutationHash("", "Hello")) Console.WriteLine("Pass 2");
            if (!IsPermutationTest.IsPermutationHash("Hello", "")) Console.WriteLine("Pass 3");
            if (IsPermutationTest.IsPermutationHash("Ggggg", "Ggggg")) Console.WriteLine("Pass 4");
            if (IsPermutationTest.IsPermutationHash("Tit", "Tit")) Console.WriteLine("Pass 5");
            if (!IsPermutationTest.IsPermutationHash("tit", "TIT")) Console.WriteLine("Pass 6");
            if (!IsPermutationTest.IsPermutationHash("tit", "TI T")) Console.WriteLine("Pass 7");
            if (IsPermutationTest.IsPermutationHash("AzYuDlp", "plDAzYu")) Console.WriteLine("Pass 7A");

            if (IsPermutationTest.IsPermutationSort("Hello", "Hello")) Console.WriteLine("Pass 8");
            if (!IsPermutationTest.IsPermutationSort("", "Hello")) Console.WriteLine("Pass 9");
            if (!IsPermutationTest.IsPermutationSort("Hello", "")) Console.WriteLine("Pass 10");
            if (IsPermutationTest.IsPermutationSort("Ggggg", "Ggggg")) Console.WriteLine("Pass 11");
            if (IsPermutationTest.IsPermutationSort("Tit", "Tit")) Console.WriteLine("Pass 12");
            if (!IsPermutationTest.IsPermutationSort("tit", "TIT")) Console.WriteLine("Pass 13");
            if (!IsPermutationTest.IsPermutationSort("tit", "TI T")) Console.WriteLine("Pass 14");
            if (IsPermutationTest.IsPermutationSort("AzYuDlp", "plDAzYu")) Console.WriteLine("Pass 15");
        }
    }
}
