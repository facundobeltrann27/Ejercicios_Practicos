using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Practicos
{
    internal class Practico_2
    {
        public static void EjecutarEjercicios()
        {
            Ejercicio11();
            Ejercicio12();
            Ejercicio13();
            Ejercicio14();
            Ejercicio15();
            Ejercicio16();
            Ejercicio17();
            Ejercicio18();
            Ejercicio19();
            Ejercicio20();
        }
        public static void Ejercicio11()
        {
            try
            {
                // EJERCICIO 11
                Console.Write("Ingrese un número: ");
                int numero11 = int.Parse(Console.ReadLine());

                if (numero11 > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else
                {
                    Console.WriteLine("El número no es positivo.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio12()
        {
            try
            {
                // EJERCICIO 12
                Console.Write("Ingrese un número: ");
                int numero12 = int.Parse(Console.ReadLine());

                if (numero12 < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número no es negativo.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio13()
        {
            try
            {
                // EJERCICIO 13
                Console.Write("Ingrese un número: ");
                int numero13 = int.Parse(Console.ReadLine());

                if (numero13 % 2 == 0)
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio14()
        {
            try
            {
                // EJERCICIO 14
                Console.Write("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("La persona es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("La persona es menor de edad.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar una edad válida.");
            }
        }


        public static void Ejercicio15()
        {
            try
            {
                // EJERCICIO 15
                Console.Write("Ingrese el primer número: ");
                int numero15a = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int numero15b = int.Parse(Console.ReadLine());

                if (numero15a > numero15b)
                {
                    Console.WriteLine("El mayor es: " + numero15a);
                }
                else if (numero15b > numero15a)
                {
                    Console.WriteLine("El mayor es: " + numero15b);
                }
                else
                {
                    Console.WriteLine("Los dos números son iguales.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio16()
        {
            try
            {
                // EJERCICIO 16
                Console.Write("Ingrese un número: ");
                int numero16 = int.Parse(Console.ReadLine());

                if (numero16 % 5 == 0)
                {
                    Console.WriteLine("El número es múltiplo de 5.");
                }
                else
                {
                    Console.WriteLine("El número no es múltiplo de 5.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio17()
        {
            try
            {
                // EJERCICIO 17
                Console.Write("Ingrese un número: ");
                int numero17 = int.Parse(Console.ReadLine());

                if (numero17 > 100)
                {
                    Console.WriteLine("El número es mayor que 100.");
                }
                else
                {
                    Console.WriteLine("El número no es mayor que 100.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio18()
        {
            try
            {
                // EJERCICIO 18
                Console.Write("Ingrese la nota: ");
                double nota = double.Parse(Console.ReadLine());

                if (nota >= 6)
                {
                    Console.WriteLine("Aprobado.");
                }
                else
                {
                    Console.WriteLine("Reprobado.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar una nota válida.");
            }
        }


        public static void Ejercicio19()
        {
            try
            {
                // EJERCICIO 19
                Console.Write("Ingrese un número: ");
                int numero19 = int.Parse(Console.ReadLine());

                if (numero19 >= 10 && numero19 <= 20)
                {
                    Console.WriteLine("El número está entre 10 y 20.");
                }
                else
                {
                    Console.WriteLine("El número no está entre 10 y 20.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio20()
        {
            try
            {
                // EJERCICIO 20
                Console.Write("Ingrese una letra: ");
                char letra = char.Parse(Console.ReadLine());

                if (letra == 'a' || letra == 'e' || letra == 'i' ||
                    letra == 'o' || letra == 'u' ||
                    letra == 'A' || letra == 'E' || letra == 'I' ||
                    letra == 'O' || letra == 'U')
                {
                    Console.WriteLine("La letra es una vocal.");
                }
                else
                {
                    Console.WriteLine("La letra no es una vocal.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar una letra válida.");
            }
        }
    }
}
