using System;

namespace InsertNamesAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neste programa você poderá inserir quantos nomes quiser.\n" +
                "E depois de finalizado, ele irá exibi-los e depois colocá-los em ordem.\n" +
                "Não misture letras maiúsculas com minúsculas, use apenas um tipo.\n\n" +
                "Favor insira o primeiro nome e pressione ENTER:");
            string[] a = new string[1];
            a = AddNames(a);
            Console.WriteLine("Ok! Os nomes digitados foram:\n");
            WriteArray(a);
            Console.WriteLine("\nPressine ENTER para ordená-los.");
            Console.ReadKey();
            Console.WriteLine("Colocando os nomes em ordem alfabética, temos:\n");
            WriteArray(OrderStringArray(a));
            Console.ReadKey();
        }
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
        public static string[] AddOneLength(string[] a)
        {
            string[] b = new string[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            return b;
        }
        public static string[] RemoveLast(string[] a)
        {
            string[] b = new string[a.Length - 1];
            for (int i = 0; i < a.Length-1; i++)
            {
                b[i] = a[i];
            }
            return b;
        }
        public static void WriteArray(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + (i < (a.Length - 1) ? ", " : ".\n"));
            }
        }
        public static string[] OrderStringArray(string[] a)
        {
            if (IsItOrdered(a))
            {
                return a;
            }
            do
            {
                int i = 0;
                do
                {
                    if (!IsTheFirstSmaller(a[i], a[i + 1]))
                    {
                        SwapPositions(a, i, i + 1);
                        if (IsItOrdered(a))
                        {
                            return a;
                        }
                    }
                    i++;
                }
                while (i < a.Length - 1);
            }
            while (!IsItOrdered(a));
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
        public static bool IsItOrdered(string[] a)
        {
            int i = 0;
            do
            {
                if (IsTheFirstSmaller(a[i], a[i + 1]))
                {
                    i++;
                }
                else
                {
                    return false;
                }
            }
            while (i < a.Length - 1);
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
