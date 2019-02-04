using System;

namespace ChaoticSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = new string[] { "ana", "paula", "luiz", "beatriz", "afonso", "beatriz", "afonso", "zaire rezende", "edimar", "macedo", "vitoria", "ana", "vinicius" };
            Console.WriteLine("Temos o vetor inicialmente inserido:\n");
            WriteArray(testArray);
            Console.WriteLine("\nE após muito esforço, que nem dá pra ver, ele foi ordenado:\n");
            WriteArray(OrderStringArray(testArray));
            Console.ReadKey();
        }
        public static string[] OrderStringArray(string[] a)
        {
            int iMax = a.Length - 1;
            int newMax = iMax;
            bool ready = false;
            do
            {
                ready = true;
                iMax = newMax;
                for (int i = 0; i < iMax; i++)
                {
                    if (!IsTheFirstSmaller(a[i], a[i + 1]))
                    {
                        SwapPositions(a, i, i + 1);
                        newMax = i;
                        ready = false;
                    }
                }
            }
            while ((iMax <= 1)||!ready);
            return a;
        }
        public static string[] SwapPositions(string[] a, int pos1, int pos2)
        {
            string aux = null;
            aux = a[pos1];
            a[pos1] = a[pos2];
            a[pos2] = aux;
            return a;
        }
        public static bool IsTheFirstSmaller(string string1, string string2) //checks if string1 is smaller than string2, returns true or false
        {
            bool smaller = true;
            bool smallerFound = false;
            int a = 0;
            int max = string1.Length > string2.Length ? string2.Length : string1.Length; //uses the smaller length vallue
            do
            {
                if (string1[a] > string2[a])
                {
                    smaller = false;
                    smallerFound = true;
                }
                else if (string1[a] < string2[a])
                {
                    smaller = true;
                    smallerFound = true;
                }
                else
                {
                    a++;
                }
            }
            while (!smallerFound && a < max);
            if (!smallerFound)
            {
                smaller = string1.Length > string2.Length ? false : true; //if all the compared characters are equal, then the string with less characters is the smaller
            }
            return smaller;
        }
        public static void WriteArray(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + (i < (a.Length - 1) ? ", " : ".\n"));
            }
        }
    }
}