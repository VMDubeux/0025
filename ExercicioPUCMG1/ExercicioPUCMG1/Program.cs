using System;
using System.Globalization;

namespace ExercicioPUCMG1
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            double salario, inss;

            Console.Write("Por favor, digite o seu salário: R$");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 1000.00)
                inss = salario * 0.08;
            else
                inss = salario * 0.1;
            
            Console.WriteLine($"O valor do INSS a ser pago é R${inss.ToString("F2")}.");
        }
    }
}