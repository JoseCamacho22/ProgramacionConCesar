using System;

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

            Console.WriteLine("Mes Actual " + Meses.Enero);
          

            Console.ReadLine();
          

            #endregion

            #region ReadKey
            Console.ReadKey();
            #endregion


        }
    }
}
