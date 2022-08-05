﻿using System;
using System.Globalization;

namespace CalcularSalario
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valorHora * horas;

            Console.WriteLine( $"NUMBER = {numero} ");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
