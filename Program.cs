using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá, o que deseja fazer? ");
            Console.WriteLine("");
            Console.WriteLine("1 ---- Soma");
            Console.WriteLine("2 ---- Subtração");
            Console.WriteLine("3 ---- Multiplicação");
            Console.WriteLine("4 ---- Divisão");
            Console.WriteLine("5 ---- Sair");
            Console.WriteLine("");

            Console.WriteLine("Escolha a operação: ");

            short escolha = short.Parse(Console.ReadLine());

            switch(escolha){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Sair(); break; 
                default: Menu(); break;
            }


        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("SOMA");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = (v1 + v2);

            Console.WriteLine("Resultado da Soma: " + resultado);
            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = (v1 - v2);

            Console.WriteLine("Resultado da Subtração: " + resultado);
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = (v1 * v2);

            Console.WriteLine("Resultado da Multiplicação: " + resultado);
            Console.ReadKey();
            
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("DIVISÃO");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = (v1 / v2);

            Console.WriteLine("Resultado da Divisão: " + resultado);
            Console.ReadKey();

            Menu();
        }

        static void Sair()
        {
            Console.Clear();

            Console.WriteLine("Tchau, Até a próxima.");
            System.Environment.Exit(0);
        }
    }
}
