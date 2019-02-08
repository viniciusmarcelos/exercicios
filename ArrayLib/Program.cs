using System;

namespace ArrayLibrary
{
    public static class ArrayLib
    {
        public static void Escrevevetor(string[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + (i < (vetor.Length - 1) ? ", " : ".\n"));
            }
        }
        public static int Find(string[] vetor, string alvo)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == alvo)
                {
                    return i;
                }
            }
            return -1;
        }
        public static string[] Join(string[] parte1, string[] parte2)
        {
            string[] partesjuntas = new string[(parte1.Length + parte2.Length)];
            for (int i = 0; i < parte1.Length; i++)
            {
                partesjuntas[i] = parte1[i];
            }
            for (int i = 0; i < parte2.Length; i++)
            {
                partesjuntas[(parte1.Length + i)] = parte2[i];
            }
            return partesjuntas;
        }
        public static string[] Trim(string[] vetor)
        {
            int tamanhovetorsemvazios = 0;
            int pos = 0; //posição de gravação no vetor sem vazios
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != "")
                {
                    tamanhovetorsemvazios++;
                }
            }
            string[] vetorsemvazios = new string[tamanhovetorsemvazios];
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != "")
                {
                    vetorsemvazios[pos] = vetor[i];
                    if (pos < tamanhovetorsemvazios)
                    {
                        pos++;
                    }
                }
            }
            return vetorsemvazios;
        }
        public static string[] Fill(string[] vetor, string nome)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = nome;
            }
            return vetor;
        }
    }
}
