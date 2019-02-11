using System;
using MyLibrary;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startMenu = new string[] { "Clientes", "Contas", "Operações", "Sair" };
            StringLib.PrintAddingSpaces("SISTEMA DO BANCO");
            Console.WriteLine("\nEntre com o número da opção desejada:\n");
            ArrayLib.PrintMenuStyle1(startMenu);
            string startMenuChoice = ArrayLib.GetChoiceMenuStyle1(startMenu, Console.ReadLine());
            switch (startMenuChoice)
            {
                case "Clientes":
                    string[]clientsMenu = new string[] {"Adicionar novo cliente","Remover um cliente","}
                    break;
                case "Contas":
                    break;
                case "Operações":
                    break;
                case "Sair":
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
