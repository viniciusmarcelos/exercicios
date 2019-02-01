using System;

namespace ChaoticSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = new string[] { "ana", "paula", "luiz", "beatriz", "afonso", "beatriz" };
            string a = "Anaa           asdsad       asdasd";
            string b = "Ana";
            Console.WriteLine("O vetor está em ortem?"+ Is);

            Console.ReadKey();
        }
        //public static string[] OrderStringArray(string[] array1)
        //{
        //    string[] array2 = new string[array1.Length];
        //    if (ordered)
        //    {
        //        return array1;
        //    }
        //    return array2;
        }
        public static bool IsItOrdered(string[] a)
        {
            int i = 0;
            do
            {
                if (IsTheFirstSmaller(a[i],a[i+1]))
                {
                    i++;
                }
                else
                {
                    return false;
                }
            }
            while (i < a.Length-1);
            return true;
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
    }
}



