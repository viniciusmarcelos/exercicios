using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double resposta = 0;
            char sinal;
            string sair = "";
            const char somachar = '+';
            const char subchar = '-';
            const char multchar = '*';
            const char divchar = '/';
            Console.WriteLine(
                "                         C A L C U L A D O R A\n\n" +
                "Para utilizar esta calculadora, você deverá seguir os seguintes passos:\n" +
                "- Digite o primeiro número da operação e pressione ENTER;\n" +
                "- Digite o símbolo da operação e pressione ENTER;\n" +
                "   ' " + somachar + " ' para soma;\n" +
                "   ' " + subchar + " ' para subtração;\n" +
                "   ' " + multchar + " ' para multiplicação;\n" +
                "   ' " + divchar + " ' para divisão;\n" +
                "- Digite o segundo número da operação e pressione ENTER.\n\n" +
                "Pode iniciar! (ou entre 's' para sair)\n");
            while (true)
            {
                sair = Console.ReadLine();
                if (sair != "s")
                {
                    a = Convert.ToDouble(sair);
                    sinal = Convert.ToChar(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    switch (sinal)
                    {
                        case somachar:
                            resposta = soma(a, b);
                            break;
                        case subchar:
                            resposta = subtração(a, b);
                            break;
                        case multchar:
                            resposta = multiplicação(a, b);
                            break;
                        case divchar:
                            resposta = divisão(a, b);
                            break;
                    }
                    Console.WriteLine("\nO resultado é:  {0}\n\nDigite a próxima operação, ou entre 's' para sair:\n", resposta);
                }
                else
                {
                    break;
                }
            }
        }
        public static double soma(double a, double b)
        {
            return a + b;
        }
        public static double subtração(double a, double b)
        {
            return a - b;
        }
        public static double multiplicação(double a, double b)
        {
            return a * b;
        }
        public static double divisão(double a, double b)
        {
            return a / b;
        }
    }
}