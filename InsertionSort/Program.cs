using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "flavia", "ana", "flavia", "zulma", "vinicius", "maria", "dane", "zonose", "patricia" };
            Console.WriteLine("This program will sort a list using Insertion Sort.\n" +
                "The list is:\n");
            WriteArray(a);
            Console.WriteLine("\nAnd now, the sorted list:\n");
            WriteArray(InsertionSort(a));
            Console.WriteLine("\nTo see how it was done, step by step, go ahead pressing enter.");
            Console.ReadKey();
            a = new string [] { "flavia", "ana", "flavia", "zulma", "vinicius", "maria", "dane", "zonose", "patricia" };
            WriteArray(InsertionSortWithComments(a));         
        }
        public static string[] InsertionSortWithComments(string[] a)
        {
            int lastOrdered = 0;
            int count = 1;
            do
            {
                int smallesIndex = lastOrdered;
                for (int i = lastOrdered; i < a.Length - 1; i++)
                {
                    if (!IsTheFirstSmaller(a[smallesIndex], a[i + 1]))
                    {
                        smallesIndex = i + 1;
                    }
                }
                Console.WriteLine("\nThis is the pass number {0}, the smallest was {1} and it will be swapped to the {2} position.\n", count++, a[smallesIndex], lastOrdered);
                SwapPositions(a, lastOrdered++, smallesIndex);
                WriteArray(a);
                Console.ReadKey();
            }
            while (lastOrdered < a.Length - 1);
            return a;
        }
        public static string[] InsertionSort(string[] a) //by finding the smalles string then swaping it with the first one on the array, and so on
        {
            int lastOrdered = 0;
            do
            {
                int smallesIndex = lastOrdered;
                for (int i = lastOrdered; i < a.Length - 1; i++)
                {
                    if (!IsTheFirstSmaller(a[smallesIndex], a[i + 1]))
                    {
                        smallesIndex = i + 1;
                    }
                }
                SwapPositions(a, lastOrdered++, smallesIndex);
            }
            while (lastOrdered<a.Length-1);
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
        public static string[] SwapPositions(string[] a, int pos1, int pos2)
        {
            string aux = null;
            aux = a[pos1];
            a[pos1] = a[pos2];
            a[pos2] = aux;
            return a;
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
