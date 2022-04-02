//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            CrearTrenes();
            CompararTrenecitos();
        }

        public static void CrearTrenes() {
            for(int i = 0; i < 10000000; i++ ){
                Train tren = new Train("1");
            }
        }

        public static void CompararTrenecitos(){
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t2 == t3);

        }
    }
}