using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Practicos
{
    internal class Practico_1
    {
        public static void EjecutarEjercicios()
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
            Ejercicio10();
        }
        public static void Ejercicio1()
        {
            try
            {
                // EJERCICIO 1
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("El número ingresado es: " + numero);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio2()
        {
            try
            {
                // EJERCICIO 2
                Console.Write("Ingrese el primer número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                int suma = numero1 + numero2;

                Console.WriteLine("La suma es: " + suma);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio3()
        {
            try
            {
                // EJERCICIO 3
                Console.Write("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                int suma3 = num1 + num2;
                int resta3 = num1 - num2;
                int multiplicacion3 = num1 * num2;

                Console.WriteLine("La suma es: " + suma3);
                Console.WriteLine("La resta es: " + resta3);
                Console.WriteLine("La multiplicación es: " + multiplicacion3);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio4()
        {
            try
            {
                // EJERCICIO 4
                Console.Write("Ingrese la base del rectángulo: ");
                int baseRectangulo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura del rectángulo: ");
                int alturaRectangulo = int.Parse(Console.ReadLine());

                int area = baseRectangulo * alturaRectangulo;

                Console.WriteLine("El área del rectángulo es: " + area);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio5()
        {
            try
            {
                // EJERCICIO 5
                Console.Write("Ingrese la base del rectángulo: ");
                int baseRectangulo2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura del rectángulo: ");
                int alturaRectangulo2 = int.Parse(Console.ReadLine());

                int perimetro = 2 * (baseRectangulo2 + alturaRectangulo2);

                Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio6()
        {
            try
            {
                // EJERCICIO 6
                Console.Write("Ingrese la temperatura en Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine("La temperatura en Fahrenheit es: " + fahrenheit);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar una temperatura válida.");
            }
        }


        public static void Ejercicio7()
        {
            try
            {
                // EJERCICIO 7
                Console.Write("Ingrese la cantidad de kilómetros: ");
                double Kilometros = double.Parse(Console.ReadLine());

                double metros = Kilometros * 1000;

                Console.WriteLine("La cantidad de metros es: " + metros);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar una cantidad válida.");
            }
        }


        public static void Ejercicio8()
        {
            try
            {
                // EJERCICIO 8
                Console.Write("Ingrese el primer número: ");
                double num1Promedio = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2Promedio = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el tercer número: ");
                double num3Promedio = double.Parse(Console.ReadLine());

                double promedio = (num1Promedio + num2Promedio + num3Promedio) / 3;

                Console.WriteLine("El promedio es: " + promedio);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio9()
        {
            try
            {
                // EJERCICIO 9
                Console.Write("Ingrese un número: ");
                double numero9 = double.Parse(Console.ReadLine());

                double doble = numero9 * 2;
                double triple = numero9 * 3;

                Console.WriteLine("El doble es: " + doble);
                Console.WriteLine("El triple es: " + triple);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio10()
        {
            try
            {
                // EJERCICIO 10
                Console.Write("Ingrese el precio: ");
                double precio = double.Parse(Console.ReadLine());

                double precioConIva = precio * 1.21;

                Console.WriteLine("El precio con IVA es: " + precioConIva);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un precio válido.");
            }
        }
    }
}