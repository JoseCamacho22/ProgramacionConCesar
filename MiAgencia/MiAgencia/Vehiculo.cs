using System;
using System.Collections.Generic;
using System.Text;

namespace MiAgencia
{
    public enum ColorCoche
    {
        Ninguno,
        Blanco,
        Gris,
        Rojo,
        Azul,
        Negro

    }

    public enum Estatus
    {
        Existencia,
        Vendido,
        Entregado
    }

   public class Vehiculo
    {

        #region Atributos
        int id;
        int llantas;
        string modelo;
        int año;
        ColorCoche color;
        Estatus estatus;

        #endregion

        #region Metodos
        public string Comprar()
        {
            return "comprado";
        }
        public string Vender()
        {
            return "vendido";
        }
        #endregion

        public Vehiculo()
        {
            id = 0;
            modelo = "";
            año = 2017;
            llantas = 4;
            color = ColorCoche.Ninguno;
            estatus = Estatus.Existencia;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int LLantas { get; set; }

        public int Color { get; set; }

        public string Modelo { get; set; }

        public int Año { get; set; }
    }
}
