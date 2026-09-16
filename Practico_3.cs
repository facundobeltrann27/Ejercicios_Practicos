using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Practicos
{
    internal class Practico_3
    {
        public static void EjecutarEjercicios()
        {
            Ejercicio21();
            Ejercicio22();
            Ejercicio23();
            Ejercicio24();
            Ejercicio25();
            Ejercicio26();
            Ejercicio27();
            Ejercicio28();
            Ejercicio29();
            Ejercicio30();
        }

        public static void Ejercicio21()
        {
            try
            {
                // EJERCICIO 21
                Console.Write("Ingrese un número: ");
                int numero21 = int.Parse(Console.ReadLine());

                if (numero21 > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero21 < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio22()
        {
            try
            {
                // EJERCICIO 22
                Console.Write("Ingrese un número: ");
                int numero22 = int.Parse(Console.ReadLine());

                if (numero22 % 2 == 0)
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


        public static void Ejercicio23()
        {
            try
            {
                // EJERCICIO 23
                Console.Write("Ingrese su edad: ");
                int edad23 = int.Parse(Console.ReadLine());

                if (edad23 >= 18)
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


        public static void Ejercicio24()
        {
            try
            {
                // EJERCICIO 24
                Console.Write("Ingrese el primer número: ");
                int numero24a = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int numero24b = int.Parse(Console.ReadLine());

                if (numero24a > numero24b)
                {
                    Console.WriteLine("El mayor es: " + numero24a);
                }
                else if (numero24b > numero24a)
                {
                    Console.WriteLine("El mayor es: " + numero24b);
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


        public static void Ejercicio25()
        {
            try
            {
                // EJERCICIO 25
                Console.Write("Ingrese el monto de la compra: ");
                double compra = double.Parse(Console.ReadLine());

                if (compra > 1000)
                {
                    Console.WriteLine("Tiene descuento.");
                }
                else
                {
                    Console.WriteLine("No tiene descuento.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un monto válido.");
            }
        }


        public static void Ejercicio26()
        {
            try
            {
                // EJERCICIO 26
                Console.Write("Ingrese la temperatura: ");
                double temperatura = double.Parse(Console.ReadLine());

                if (temperatura < 15)
                {
                    Console.WriteLine("Frío.");
                }
                else if (temperatura <= 25)
                {
                    Console.WriteLine("Templado.");
                }
                else
                {
                    Console.WriteLine("Calor.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar una temperatura válida.");
            }
        }


        public static void Ejercicio27()
        {
            try
            {
                // EJERCICIO 27
                Console.Write("Ingrese un número: ");
                int numero27 = int.Parse(Console.ReadLine());

                if (numero27 % 3 == 0)
                {
                    Console.WriteLine("El número es divisible por 3.");
                }
                else
                {
                    Console.WriteLine("El número no es divisible por 3.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }


        public static void Ejercicio28()
        {
            try
            {
                // EJERCICIO 28
                Console.Write("Ingrese el primer número: ");
                int numero28a = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int numero28b = int.Parse(Console.ReadLine());

                if (numero28a == numero28b)
                {
                    Console.WriteLine("Los números son iguales.");
                }
                else
                {
                    Console.WriteLine("Los números son distintos.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar números válidos.");
            }
        }


        public static void Ejercicio29()
        {
            try
            {
                // EJERCICIO 29
                Console.Write("Ingrese un año: ");
                int año = int.Parse(Console.ReadLine());

                if (año % 4 == 0)
                {
                    Console.WriteLine("El año es bisiesto.");
                }
                else
                {
                    Console.WriteLine("El año no es bisiesto.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar un año válido.");
            }
        }


        public static void Ejercicio30()
        {
            try
            {
                // EJERCICIO 30
                Console.Write("Ingrese una contraseña: ");
                string contraseña = Console.ReadLine();

                if (contraseña.Length >= 8)
                {
                    Console.WriteLine("La contraseña es válida.");
                }
                else
                {
                    Console.WriteLine("La contraseña debe tener como mínimo 8 caracteres.");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe ingresar una contraseña válida.");
            }
        }
    }
}
