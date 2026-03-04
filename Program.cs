using System;
using APS_Eq_TeamAltf4_U2.EjecutoresEjercicios;

namespace APS_Eq_TeamAltf4_U2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase icdia");
            Console.WriteLine("Ejercicios básicos");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Par-Impar");
            Console.WriteLine("2. Suma AB");
            Console.WriteLine("3. Intercambio XY");
            Console.WriteLine("4. Mayor de edad");
            Console.WriteLine("5. Número Mayor");
            Console.WriteLine("6. Multiplicacion AB");
            Console.WriteLine("------------------------");
            Console.WriteLine("Ingrese el número del ejercicio que desea ejecutar:");


            int idx = int.Parse(Console.ReadLine());

            switch (idx)
            {
                case 1:
                    new RunnerEjercicio_ParImpar();
                    break;
                case 2:
                    new RunnerSumaAB();
                    break;
                case 3:
                    new RunnerIntercambio_xy();
                    break;
                case 4:
                    new RunnerEsMayorDeEdad();
                    break;
                case 5:
                    new RunnerEjercicioNumeroMayor();
                    break;
                case 6:
                    new RunnerMultiplicacionAB();
                    break;
                case 7:
                    new RunnerEjercicioSumaABGenerico();
                    break;
            }
        }
    }
}
