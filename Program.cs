﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        if (opcion == 1)
        {
            Sumar();
        }

            // TODO: Implementar funciones de suma, resta, multiplicación, división
    }
    static void Sumar()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        double resultado = num1 + num2;
        Console.WriteLine($"El resultado de la suma es: {resultado}");
    }
    // TODO: Implementar funciones de suma, resta, multiplicación, división
}