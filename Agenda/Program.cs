using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] a = new string[1, 2];
            Console.WriteLine("A G E N D A\n\n" +
               "Digite a opção desejada:\n" +
               "1 - Exibir agenda;\n" +
               "2 - Adicionar contato;\n" +
               "3 - Pesquisar contato pelo nome (editar);\n");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '1':
                    break;
                case '2':
                    AddContact(a);
                    break;
                case '3':
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }   

            Console.ReadKey();
        }
        public static string[,] AddContact(string[,] a)
        {
            bool sair = false;
            if (a.GetLength(0) == 1 && a[0, 0] == "")
            {
                int i = 0;
                Console.WriteLine("Digite o primeiro nome a ser cadastrado na agenda,\n" +
                    "ou pressione ENTER para retornar ao menu:");
                a[i, 0] = Console.ReadLine();
                if (a[i, 0] != "")
                {
                    Console.WriteLine("Qual é o telefone do(a) {0}?", a[i, 0]);
                    a[i, 1] = Console.ReadLine();
                    Console.WriteLine("Contato cadastrado com sucesso!");
                }
                else
                {
                    sair = true;
                }
            }
            do
            {
                if (sair == true)
                {
                    break;
                }
                int i = a.GetLength(0);
                a = AddOneLength(a);
                Console.WriteLine("Digite o próximo nome a ser cadastrado, ou ENTER para retornar ao menu.");
                a[i,0] = Console.ReadLine();
                if (a[i, 0] == "")
                {
                    RemoveLast(a);
                    break;
                }
                else
                {
                    Console.WriteLine("Qual é o telefone do(a) {0}?", a[i, 0]);
                    a[i, 1] = Console.ReadLine();
                    Console.WriteLine("Contato cadastrado com sucesso!");
                }
            }
            while (true);
            return a;
        }
        public static string[,] AddOneLength(string[,] a)
        {
            string[,] b = new string[(a.GetLength(0) + 1), 1];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                b[i, 0] = a[i, 0];
                b[i, 1] = a[i, 1];
            }
            return b;
        }
        public static string[,] RemoveLast(string[,] a)
        {
            string[,] b = new string[a.GetLength(0) - 1, 1];
            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                b[i, 0] = a[i, 0];
                b[i, 1] = a[i, 1];
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
