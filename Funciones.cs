using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Practicos
{
    internal class Funciones
    {

        public static int LeerPractico(string mensaje)
        {
            Console.WriteLine(mensaje);
            string valorUno = Console.ReadLine();
            if (!Int32.TryParse(valorUno, out int sumando1))
                throw new Exception("Error: debe ingresar un número válido.");
            return sumando1;
        }
        public static void EjecutarPractico(int practico)

        {
            switch (practico)
            {
                case 1:
                    Practico_1.EjecutarEjercicios();
                    break;
                case 2:
                    Practico_2.EjecutarEjercicios();
                    break;
                case 3:
                    Practico_3.EjecutarEjercicios();
                    break;
                case 4:
                    Practico_4.EjecutarEjercicios();
                    break;
                default:
                    Console.WriteLine($"El practico {practico} no existe. ");
                    break;

            }
        }
    }
}
