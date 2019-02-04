using System;

namespace BinaryFind
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "flavia", "ana", "flavia", "zulma", "vinicius", "maria", "dane", "zonose", "patricia" };
            Console.WriteLine("This program will find a string in a string[] using a method called Binary Find.\n" +
                "The string is: \n");
            WriteArray(a);
            Console.WriteLine("Now, type a name to search for:");
            string name = Console.ReadLine();
            Console.WriteLine("\nTo search, we first put the array in order:\n");
            WriteArrayWithIndex(OrderStringArray(a));
            Console.WriteLine("\nThe name {0} is in the {1}{2} position.", name, Find(a,name), ThAdder(Find(a,name)));
            Console.ReadKey();
        }
        public static int Find(string[] a, string name)
        {
            int start = 0;
            int end = a.Length - 1;
            int mid = 0;
            string[] b = CoppyStringArray(a);
            OrderStringArray(b);
            do
            {
                mid = MiddlePosition(start, end);
                if (IsTheFirstSmaller(name, b[mid])) //checks if the inserted name is smaller than middle position string
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            while (end - start > 1);
            if (b[end] == name)
            {
                return end;
            }
            else if (b[start] == name)
            {
                return start;
            }
            else return -1;
        }
        public static int MiddlePosition(int a, int b)
        {
            return (a + b) / 2;
        }
        public static string[] CoppyStringArray(string[] a)
        {
            string[] b = new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            return b;
        }
        public static string[] OrderStringArray(string[] a)
        {
            int iMax = a.Length - 1;
            int lastSwap = 0;
            do
            {
                lastSwap = 0;
                for (int i = 0; i < iMax; i++)
                {
                    if (!IsTheFirstSmaller(a[i], a[i + 1]))
                    {
                        SwapPositions(a, i, i + 1);
                        lastSwap = i;
                    }
                }
                iMax = lastSwap;
            }
            while (lastSwap != 0);
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
        public static void WriteArrayWithIndex(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(i + ". " + a[i] + (i < (a.Length - 1) ? ", " : ".\n"));
            }
        }
        public static string ThAdder(int pos)
        {
            switch (pos)
            {
                case 0:
                    return "";
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                case -1:
                    return "(not found)";
                default:
                    return "th";
            }
        }
    }
}
