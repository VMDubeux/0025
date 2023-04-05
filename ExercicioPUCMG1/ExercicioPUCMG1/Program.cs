using System;
using System.Globalization;

namespace ExercicioPUCMG1
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            double salario, inss, outroValor;

            Console.Write("Por favor, digite o seu salário: R$");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 1000.00)
                inss = salario * 0.08;
            else
                inss = salario * 0.1;

            Console.WriteLine($"O valor do INSS a ser pago é R${inss.ToString("F2")}.");

            //testando if, if-else, else, while

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Brincadeira: tente adivinhar o valor escolhido!");

            Console.Write("Informe um número: ");
            outroValor = double.Parse(Console.ReadLine());

            while (outroValor != 1000.00)
            {
                if (outroValor < 1000.00)
                    Console.WriteLine("É menor que esse.");
                else
                    Console.WriteLine("É maior que esse.");

                Console.Write("Informe outro número: ");
                outroValor = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Você acertou! Parabéns!");
        }
    }
}