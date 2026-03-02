using System;
using APS_Eq_TeamAltf4_U2.EjecutoresEjercicios;

namespace APS_Eq_TeamAltf4_U2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase icdia");
            Console.WriteLine("1. Par-Impar");
            Console.WriteLine("2. Suma AB");

            int idx = int.Parse(Console.ReadLine());

            switch (idx)
            {
                case 1:
                    new RunnerEjercicio_ParImpar();
                    break;
                case 2:
                    new RunnerSumaAB();
                    break;
            }
        }
    }
}
