using System;
using System.Collections.Generic;
using System.Text;

namespace MiAgencia
{
    class Coche : Vehiculo
    {
        #region Atributos
        int puertas;
        #endregion


        public Coche()
        {
            puertas = 4;
        }
        public Coche(int puertas)
        {
           this.puertas = puertas;
        }
    }
}
