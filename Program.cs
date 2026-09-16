using System;

namespace Ejercicios_Practicos
{
    internal class Program
    {
    private static void Main(string[] args)
        {
            int practico = Funciones.LeerPractico("Ingrese el practico que desea ejecutar (1 - 4):");
            Funciones.EjecutarPractico(practico);
        }
    }
}