using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Find
            string[] vetor = new string[] { "ana", "paula", "luiz", "beatriz", "afonso" };
            const string alvo = "luiz";
            const string alvoerrado = "JHENIFFFFEEER (não encontrada aqui, mas sim no TINDER)";
            Console.WriteLine("O vetor é:\n");
            Escrevevetor(vetor);
            Console.WriteLine("\nAo procurar pelo nome {0} no vetor, retornamos a posição dele, que é: {1}.\n", alvo, Find(vetor, alvo));
            Console.WriteLine("Se procurarmos por {0} no vetor, retornamos o código de não encontrado: {1}.\n", alvoerrado, Find(vetor, alvoerrado));
            #endregion
            #region Join
            string[] parte1 = new string[] { "Um", "Dois", "Três", "Quatro", "Cinco", "Seis" };
            string[] parte2 = new string[] { "Sete", "Oito", "Nove", "Dez" };
            Console.WriteLine("Agora, temos dois vetores:\n");
            Escrevevetor(parte1);
            Console.WriteLine();
            Escrevevetor(parte2);
            Console.WriteLine("\nAo juntar os dois vetores, temos:\n");
            Escrevevetor(Join(parte1, parte2));
            #endregion
            #region Trim
            string[] vetorcomvazios = new string[] { "", "Dilma", "", "", "Lula", "", "", "", "Jair", "" };
            Console.WriteLine("\nA seguir, temos um vetor de {0} posições com nomes e vazios misturados:\n", vetorcomvazios.Length);
            Escrevevetor(vetorcomvazios);
            Console.WriteLine("\nE, magicamente, removemos os vazios:\n");
            Escrevevetor(Trim(vetorcomvazios));
            #endregion
            #region Fill
            const int tamanhonovovetor = 200;
            const string preenchimento = "PAU NO CU DE QUEM TÁ LENDO!";
            string[] novo_vetor = new string[tamanhonovovetor];
            Console.WriteLine("\nPara finalizar, criamos um novo vetor com {0} posições, e vamos preenchê-lo o nome '{1}'\nPressione ENTER.", tamanhonovovetor, preenchimento);
            Console.ReadLine();
            Escrevevetor(Fill(novo_vetor, preenchimento));
            #endregion
            Console.ReadKey();
        }
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
