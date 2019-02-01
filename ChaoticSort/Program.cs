using System;

namespace ChaoticSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = new string[] { "ana", "paula", "luiz", "beatriz", "afonso", "beatriz" };
            char[] vetorchar = testArray[0].ToCharArray();
            for (int i = 0; i < vetorchar.Length; i++)
            {
                Console.WriteLine(vetorchar[i]);
            }
            string voltando = vetorchar.ToString();
            Console.WriteLine(voltando);
            Console.WriteLine("A maior string entre {0} e {1} é {2}.", testArray[0], testArray[4], Biggerstring(testArray[0], testArray[4]));


            Console.ReadKey();
        }
        //public static string[] Orderstring(string[] vetor)
        //{

        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        char[] chars1 = vetor[i].ToCharArray();
        //        char[] chars2 = vetor[i + 1].ToCharArray();
        //        string maior = "";
        //        int a = 0;
        //        do
        //        {
        //            if (chars1[a] > chars2[a])
        //            {
        //                maior = chars1.ToString();
        //            }
        //            else if (chars1[a] < chars2[a])
        //            {
        //                maior = chars2.ToString();
        //            }
        //            else
        //            {
        //                a++;
        //            }
        //        }
        //        while (maior != "");
        //    }
        //}
        public static string Biggerstring(string string1, string string2)
        {
            char[] chars1 = string1.ToCharArray();
            char[] chars2 = string2.ToCharArray();
            string bigger = "";
            int a = 0;
            int max = chars1.Length > chars2.Length ? chars2.Length : chars1.Length; //usa o tamanho do menor vetor
            do
            {
                if (chars1[a] > chars2[a])
                {
                    bigger = chars1.ToString();
                }
                else if (chars1[a] < chars2[a])
                {
                    bigger = chars2.ToString();
                }
                else
                {
                    a++;
                }
            }
            while (bigger == "" && a < max);
            if (bigger=="")
            {
                bigger = chars1.Length > chars2.Length ? chars1.ToString() : chars2.ToString(); //se todas as letras comparadas foram iguais, a maior string é a com mais letras
            }
            return bigger;
        }
    }
}



