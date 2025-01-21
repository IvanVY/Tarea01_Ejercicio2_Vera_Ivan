using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Ejercicio2_Vera_Ivan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Llamada a los ejercicios
            Console.WriteLine("Ejercicio 1: Evaluar si un número es positivo, negativo o cero");
            EvaluarNumero();

            Console.WriteLine("\nEjercicio 2: Evaluar si la calificación es aprobada o reprobada");
            EvaluarCalificacion();

            Console.WriteLine("\nEjercicio 3: Determinar el rango de un número");
            DeterminarRango();

            Console.WriteLine("\nEjercicio 4: Mostrar el día de la semana según un número del 1 al 7");
            MostrarDiaSemana();

            Console.WriteLine("\nEjercicio 5: Realizar operaciones con dos números y un operador");
            RealizarOperacion();
        }//fin void main

        // Ejercicio 1: Evaluar si un número ingresado es positivo, negativo o cero
        static void EvaluarNumero()
        {
            // Solicitar al usuario que ingrese un número
            Console.Write("Ingresa un número: ");
            string input = Console.ReadLine();

            // Validar si el input es un número válido
            if (double.TryParse(input, out double numero))
            {
                // Evaluar si el número es positivo, negativo o cero
                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }

        // Ejercicio 2: Evaluar si una calificación es aprobada o reprobada
        static void EvaluarCalificacion()
        {
            // Solicitar al usuario que ingrese una calificación
            Console.Write("Ingresa tu calificación: ");
            string input = Console.ReadLine();

            // Validar si el input es un número válido
            if (double.TryParse(input, out double calificacion))
            {
                // Evaluar si la calificación es aprobada o reprobada
                if (calificacion >= 60)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa una calificación válida.");
            }
        }

        // Ejercicio 3: Determinar el rango de un número
        static void DeterminarRango()
        {
            // Solicitar al usuario que ingrese un número
            Console.Write("Ingresa un número: ");
            string input = Console.ReadLine();

            // Validar si el input es un número válido
            if (double.TryParse(input, out double numero))
            {
                // Determinar en qué rango se encuentra el número
                if (numero < 10)
                {
                    Console.WriteLine("Menor que 10");
                }
                else if (numero >= 10 && numero <= 20)
                {
                    Console.WriteLine("Entre 10 y 20");
                }
                else
                {
                    Console.WriteLine("Mayor que 20");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }

        // Ejercicio 4: Mostrar el día de la semana según el número del 1 al 7
        static void MostrarDiaSemana()
        {
            // Solicitar al usuario que ingrese un número entre 1 y 7
            Console.Write("Ingresa un número del 1 al 7 para obtener el día de la semana: ");
            string input = Console.ReadLine();

            // Validar si el input es un número válido
            if (int.TryParse(input, out int dia))
            {
                // Usar un switch para determinar el día de la semana
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sábado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    default:
                        Console.WriteLine("Por favor, ingresa un número entre 1 y 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }

        // Ejercicio 5: Realizar operaciones con dos números y un operador
        static void RealizarOperacion()
        {
            // Solicitar al usuario que ingrese el primer número
            Console.Write("Ingresa el primer número: ");
            string input1 = Console.ReadLine();

            // Solicitar al usuario que ingrese el segundo número
            Console.Write("Ingresa el segundo número: ");
            string input2 = Console.ReadLine();

            // Validar si ambos inputs son números válidos
            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                // Solicitar al usuario que ingrese el operador (+, -, *, /)
                Console.Write("Ingresa la operación (+, -, *, /): ");
                string operador = Console.ReadLine();

                // Usar un switch para realizar la operación correspondiente
                switch (operador)
                {
                    case "+":
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case "/":
                        // Validar si el divisor es diferente de cero
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir por cero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Operación no válida. Por favor ingresa uno de estos operadores: +, -, *, /.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa números válidos.");
            }
        }
    }
}
