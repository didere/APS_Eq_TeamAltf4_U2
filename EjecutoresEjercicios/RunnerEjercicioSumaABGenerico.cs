using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    class RunnerEjercicioSumaABGenerico
    {
        public RunnerEjercicioSumaABGenerico()
        {
            int a, b;
            Console.WriteLine("Dame el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de b: ");
            b = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new EjercicioSumaAB_Genericos<int>(a, b);
            ejercicio.Ejecutar();

        }
    }
}
