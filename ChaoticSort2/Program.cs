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
            do
            {
                for (int i = 0; i < iMax; i++)
                {
                    Console.WriteLine("for número " + i);
                    Console.WriteLine("O iMax no inicio do for " + iMax);
                    if (!IsTheFirstSmaller(a[i], a[i + 1]))
                    {
                        Console.WriteLine("Fez uma troca");
                        SwapPositions(a, i, i + 1);
                        iMax = i;
                        Console.WriteLine("Mudou o o iMax para " + iMax);
                    }
                }
            }
            while (!(iMax <= 1));
            return a;
        }




        //    bool ready = true;
        //    int iMax = a.Length - 1;
        //    do
        //    {
        //        ready = true;
        //        int i = 0;
        //        do
        //        {
        //            if (!IsTheFirstSmaller(a[i], a[i + 1]))
        //            {
        //                SwapPositions(a, i, i + 1);
        //                ready = false;
        //            }
        //            i++;
        //        }
        //        while (i < iMax);
        //        iMax--;
        //    }
        //    while (!ready);
        //    return a;
        //}
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