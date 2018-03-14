﻿using System;

namespace MiPrimerProyecto
{
    public enum Meses
    {
        Enero = 1,
        Febrero,
        Marzo,
        Abril,
        Mayo,
        Junio,
        Julio,
        Agosto,
        Septiembre,
        Octubre,
        Noviembre,
        Diciembre
    };
    class Program
    {
        /// <summary>
        /// Metodo principal
        /// </summary>
        /// <param name="args"> descripcion del parametro arg</param>
        static void Main(string[] args)
        {
            #region Imprimir
            Console.WriteLine("Probando mi primer proyecto con C#");

            const int miConst = 10;
            Console.WriteLine("Introduce un numero entero");
            //como el usuario ingresa un string tengo que parsearlo.
            int num =Int32.Parse( Console.ReadLine());

            #region Operadores Matematicos
            int suma = miConst + num;
            Console.WriteLine("suma = " + suma);
            

            int resta = miConst - num;
            Console.WriteLine("Resta = " + resta);

            int opResta = -resta;
            Console.WriteLine("Opuesto resta  = " + opResta);


            int multi = miConst * num;
            Console.WriteLine("Multiplicacion = " + multi);

            #endregion


            Console.ReadLine();
          

            #endregion

            #region ReadKey
            Console.ReadKey();
            #endregion


        }
    }
}
