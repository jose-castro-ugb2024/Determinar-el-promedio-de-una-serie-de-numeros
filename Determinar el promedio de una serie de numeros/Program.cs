﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinar_el_promedio_de_una_serie_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        { // prioridad de los operadores aritmeticos
            // ejercicio de obtener el promedio de una serie de numeros

            int[] serie = new int[] { 5, 4, 6, 8, 9 }; //32
            int suma = 0;
            foreach (int num in serie)
            {
                suma += num;

            }
            decimal prom = suma / serie.Length; //6
            Console.WriteLine("La suma es: {0}, el promedio {1}", suma, prom);
            //pausa
            Console.ReadLine();
        }
    }
}
