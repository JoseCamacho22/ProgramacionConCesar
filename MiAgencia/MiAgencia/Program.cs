using System;

namespace MiAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MiAgencia";
            Console.WriteLine("Seleccione una opcion: ");
            Console.WriteLine("1 Moto");
            Console.WriteLine("2 Coche ");
            Console.WriteLine("3 Camion");

            int menu = int.Parse(Console.ReadLine());
            int año, llantas, color;
            string modelo;
            switch (menu)
            {
                case 1:
                    break;
                case 2:
                    Console.WriteLine("Modelo");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Año");
                    año = int.Parse(Console.ReadLine());
                    Console.WriteLine("llantas");
                    llantas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Color: 1 Blanco , 2 Gris , 3 Rojo...");
                    color = int.Parse(Console.ReadLine());
                    Coche miCoche = new Coche();
                    miCoche.Id = 0;
                    miCoche.LLantas = llantas;
                    miCoche.Modelo = modelo;
                    miCoche.Año = año;

                    string resp = miCoche.Comprar();
                    Console.WriteLine("Respuesta " + resp);
                    Console.ReadKey();
                    break;

            }
        }
    }
}
