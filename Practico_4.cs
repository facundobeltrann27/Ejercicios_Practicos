using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Practicos
{
    internal class Practico_4
    {
        public static void EjecutarEjercicios()
        {
            Ejercicio31();
            Ejercicio32();
            Ejercicio33();
            Ejercicio34();
            Ejercicio35();
            Ejercicio36();
            Ejercicio37();
            Ejercicio38();
            Ejercicio39();
            Ejercicio40();
            Ejercicio41();
            Ejercicio42();
            Ejercicio43();
            Ejercicio44();
            Ejercicio45();
        }

        public static void Ejercicio31()
        {
            try
            {
                // EJERCICIO 31
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch
            {
                Console.WriteLine("Error al mostrar los números.");
            }
        }


        public static void Ejercicio32()
        {
            try
            {
                // EJERCICIO 32
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch
            {
                Console.WriteLine("Error al mostrar los números.");
            }
        }


        public static void Ejercicio33()
        {
            try
            {
                // EJERCICIO 33
                for (int i = 1; i <= 50; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error al mostrar los números pares.");
            }
        }


        public static void Ejercicio34()
        {
            try
            {
                // EJERCICIO 34
                for (int i = 1; i <= 50; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error al mostrar los números impares.");
            }
        }


        public static void Ejercicio35()
        {
            try
            {
                // EJERCICIO 35
                int suma = 0;

                for (int i = 1; i <= 10; i++)
                {
                    suma = suma + i;
                }

                Console.WriteLine("La suma del 1 al 10 es: " + suma);
            }
            catch
            {
                Console.WriteLine("Error al realizar la suma.");
            }
        }


        public static void Ejercicio36()
        {
            try
            {
                // EJERCICIO 36
                int suma = 0;

                for (int i = 1; i <= 100; i++)
                {
                    suma = suma + i;
                }

                Console.WriteLine("La suma del 1 al 100 es: " + suma);
            }
            catch
            {
                Console.WriteLine("Error al realizar la suma.");
            }
        }


        public static void Ejercicio37()
        {
            try
            {
                // EJERCICIO 37
                Console.Write("Ingrese un número: ");
                int numero37 = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numero37 + " x " + i + " = " + (numero37 * i));
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio38()
        {
            try
            {
                // EJERCICIO 38
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            catch
            {
                Console.WriteLine("Error al realizar la cuenta regresiva.");
            }
        }


        public static void Ejercicio39()
        {
            try
            {
                // EJERCICIO 39
                Console.Write("Ingrese un número: ");
                int numero39 = int.Parse(Console.ReadLine());

                long factorial = 1;

                for (int i = 1; i <= numero39; i++)
                {
                    factorial = factorial * i;
                }

                Console.WriteLine("El factorial es: " + factorial);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio40()
        {
            try
            {
                // EJERCICIO 40
                for (int i = 1; i <= 10; i++)
                {
                    int cuadrado = i * i;

                    Console.WriteLine("El cuadrado de " + i + " es: " + cuadrado);
                }
            }
            catch
            {
                Console.WriteLine("Error al calcular los cuadrados.");
            }
        }


        public static void Ejercicio41()
        {
            try
            {
                // EJERCICIO 41
                int numero41;

                do
                {
                    Console.Write("Ingrese un número (0 para terminar): ");
                    numero41 = int.Parse(Console.ReadLine());

                    if (numero41 != 0)
                    {
                        Console.WriteLine("Ingresaste: " + numero41);
                    }

                } while (numero41 != 0);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio42()
        {
            try
            {
                // EJERCICIO 42
                int cantidadPositivos = 0;

                Console.Write("¿Cuántos números desea ingresar?: ");
                int cantidad = int.Parse(Console.ReadLine());

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.Write("Ingrese el número " + i + ": ");
                    int numero42 = int.Parse(Console.ReadLine());

                    if (numero42 > 0)
                    {
                        cantidadPositivos++;
                    }
                }

                Console.WriteLine("Cantidad de números positivos: " + cantidadPositivos);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio43()
        {
            try
            {
                // EJERCICIO 43
                Console.Write("¿Cuántos números desea ingresar?: ");
                int cantidad = int.Parse(Console.ReadLine());

                double suma = 0;

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.Write("Ingrese el número " + i + ": ");
                    double numero43 = double.Parse(Console.ReadLine());

                    suma = suma + numero43;
                }

                double promedio = suma / cantidad;

                Console.WriteLine("El promedio es: " + promedio);
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio44()
        {
            try
            {
                // EJERCICIO 44
                for (int i = 3; i <= 100; i += 3)
                {
                    Console.WriteLine(i);
                }
            }
            catch
            {
                Console.WriteLine("Error al mostrar los múltiplos de 3.");
            }
        }


        public static void Ejercicio45()
        {
            try
            {
                // EJERCICIO 45
                Console.Write("¿Cuántos términos de Fibonacci desea mostrar?: ");
                int cantidad = int.Parse(Console.ReadLine());

                int primero = 0;
                int segundo = 1;

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine(primero);

                    int siguiente = primero + segundo;
                    primero = segundo;
                    segundo = siguiente;
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }
    }
}
