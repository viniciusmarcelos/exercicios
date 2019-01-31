using System;

namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario = 0;
            Console.WriteLine("REAJUSTE SALARIAL");
            Console.WriteLine("Digite o valor atual do salário:");
            float.TryParse(Console.ReadLine(), out salario);
            salario = (salario < 1700 ? (salario + 300) : (salario + 200));
            Console.WriteLine("O salário reajustado é {0}", salario);
            Console.ReadLine();        
        }
    }
}
