﻿using System;

namespace MyLibrary
{
    public class ArrayLib
    {
        public static string[] AddNames(string[] a)
        {
            int i = 0;
            do
            {
                a[i] = Console.ReadLine();
                if (a[i] == "")
                {
                    a = RemoveLast(a);
                    break;
                }
                Console.WriteLine("O nome {0} foi adicionado. Total de {1} nomes.\n" +
                                "Entre com o próximo nome, ou apenas ENTER se terminou:", a[i], a.Length);
                a = AddOneLength(a);
                i++;
            }
            while (true);
            return a;
        }

        private static string[] AddOneLength(string[] array) //returns an array iqual to the array imput + 1 length
        {
            string[] newArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        private static string[] RemoveLast(string[] array) //returns an array iqual to the array imput - 1 length
        {
            string[] newArray = new string[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        public static void PrintArray(string[] array) //prints the array using ", " between the elements, and "." after the last one
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + (i < (array.Length - 1) ? ", " : ".\n"));
            }
        }

        public static void PrintMenuStyle1(string[] array) //prints a Menu, options are: 1, 2, 3 .. and the last is 0 - Exit
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i < (array.Length - 1) ? i + 1 : 0, array[i]);
            }
        }

        public static string GetChoiceMenuStyle1(string[] array, string choice) //returns the string of the choice imput
        {
            int choiceNumber = Convert.ToInt32(choice);
            if (choiceNumber < array.Length && choiceNumber>0)
            {
                return array[choiceNumber - 1];
            }
            else return choiceNumber == 0 ? array[array.Length - 1] : "-1";
        }

        public static void PrintArrayWithIndexes(string[] array) //prints an array with indexes, example: {name1 , name2 , name3} = "0. name1, 1. name2, 2. name3."
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i + ". " + array[i] + (i < (array.Length - 1) ? ", " : ".\n"));
            }
        }

        public static int Find_Ordinary(string[] array, string target) //returns the position of the target or -1 if not found
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Find_Binary(string[] array, string target)
        {
            int start = 0;
            int end = array.Length - 1;
            int mid = 0;
            SortArray_BubbleSort(array);
            do
            {
                mid = MiddlePosition(start, end);
                if (IsTheFirstSmaller(target, array[mid])) //checks if the inserted name is smaller than middle position string
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            while (end - start > 1);
            if (array[end] == target)
            {
                return end;
            }
            else if (array[start] == target)
            {
                return start;
            }
            else return -1;
        } //returns the position of the target or -1 if not found. THE ARRAY WILL BE SORTED after using this. Method: sorts the array, checks in witch half target is, than witch half of that half, and so on until it finds it 

        public static string[] Join(string[] piece1, string[] piece2) //returns an array with the elements of piece1 followed by elements of piece2
        {
            string[] jointedPieces = new string[(piece1.Length + piece2.Length)];
            for (int i = 0; i < piece1.Length; i++)
            {
                jointedPieces[i] = piece1[i];
            }
            for (int i = 0; i < piece2.Length; i++)
            {
                jointedPieces[(piece1.Length + i)] = piece2[i];
            }
            return jointedPieces;
        }

        public static string[] Trim(string[] array) //removes empty strings from the array, reducing it's size
        {
            int voidlessArraySize = 0;
            int pos = 0; //position to record on the voidless array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != "")
                {
                    voidlessArraySize++;
                }
            }
            string[] voidlessArray = new string[voidlessArraySize];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != "")
                {
                    voidlessArray[pos] = array[i];
                    if (pos < voidlessArraySize)
                    {
                        pos++;
                    }
                }
            }
            return voidlessArray;
        }

        public static string[] Fill(string[] array, string fillinglText) //fills all slots of the array with the fillingText
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = fillinglText;
            }
            return array;
        }

        public static string[] SortArray_BubbleSort(string[] array) //sorts an array with Bubble Sort method, this is the enhanced version
        {
            int iMax = array.Length - 1;
            int lastSwap = 0;
            do
            {
                lastSwap = 0;
                for (int i = 0; i < iMax; i++)
                {
                    if (!IsTheFirstSmaller(array[i], array[i + 1]))
                    {
                        SwapPositions(array, i, i + 1);
                        lastSwap = i;
                    }
                }
                iMax = lastSwap;
            }
            while (lastSwap != 0);
            return array;
        }

        public static string[] SortArray_InsertionSort(string[] array) //by finding the smallest string then swaping it with the first one on the array, and so on
        {
            int lastOrdered = 0;
            do
            {
                int smallestIndex = lastOrdered;
                for (int i = lastOrdered; i < array.Length - 1; i++)
                {
                    if (!IsTheFirstSmaller(array[smallestIndex], array[i + 1]))
                    {
                        smallestIndex = i + 1;
                    }
                }
                SwapPositions(array, lastOrdered++, smallestIndex);
            }
            while (lastOrdered < array.Length - 1);
            return array;
        }

        private static string[] SwapPositions(string[] array, int position1, int position2) //swaps positions between elements in position1 and position2
        {
            string aux = null;
            aux = array[position1];
            array[position1] = array[position2];
            array[position2] = aux;
            return array;
        }

        private static bool IsTheFirstSmaller(string string1, string string2) //checks if string1 is smaller than string2, returns true or false
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

        private static int MiddlePosition(int number1, int number2) //returns the average between number1 and number2
        {
            return (number1 + number2) / 2;
        }
    }
    public class StringLib
    {
        public static string ThAdder(int position) //adds the correct sulfix to positions, as following: 0"", 1"st", 2"nd", 3"rd", 4"th", 5"th" ... and -1"not found"
        {
            switch (position)
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

        public static void PrintAddingSpaces(string imput)
        {
            for (int i = 0; i<imput.Length; i++)
            {
                Console.Write("{0}{1}", imput[i], i < imput.Length - 1 ? " " :"\n");
            }           
        } //P R I N T S  L I K E  T H I S
    }
}
