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
            
            Console.WriteLine("Probando mi primer proyecto con C#");

            Console.WriteLine("Introduzca su nombre de usuario");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca una contraseña de usuario");
            string pwd = Console.ReadLine();

            if (nombreUsuario == "usuarioX")
            {
                if (pwd == "12345")
                {
                    Console.WriteLine("Bienvenido " + nombreUsuario);
                }
                else
                {
                    Console.WriteLine("la contraseña es incorrecta");
                }
            }
            else
            {
                Console.WriteLine("El nombre de Usuario es incorrect0");
            }




/*
            #region Operadores logicos
            const int miConst = 10;
            Console.WriteLine("Introduce un numero entero X");
            //como el usuario ingresa un string tengo que parsearlo.
            int numX =Int32.Parse( Console.ReadLine());
            Console.WriteLine("Introduce un numero entero Y");
            int numY = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un numero entero Z");
            int numZ = Int32.Parse(Console.ReadLine());
            bool todosMayores = false;

            if (numX > 0 && numY > 0 && numZ > 0)
            {
                Console.WriteLine("Todos los numeros son mayores que 0");
                todosMayores = true;
            }
            else
            {
                Console.WriteLine("Hay algun numero que es menor o igual a 0");
            }
            if (numX > 0 || numY > 0 || numZ > 0)
            {
                Console.WriteLine("Al menos un numero es mayor a 0");

            }
            if (!todosMayores)
            {
                Console.WriteLine("No todos los numeros son mayores a 0");
            }
            #endregion



            /*

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

                        #region Operadores de Asignacion
                        Console.WriteLine("Introduce un numero entero B");
                        //como el usuario ingresa un string tengo que parsearlo.
                        int numB = Int32.Parse(Console.ReadLine());
                        suma += numB;
                        Console.WriteLine("el nuevo valor de suma es = " + suma);
                        resta -= numB;
                        Console.WriteLine("el nuevo valor de la resta  es = " + resta);
                        multi *= numB;
                        Console.WriteLine("el nuevo valor de la multiplicacion  es = " + multi);
                        #endregion

                        #region Operadores Relacionales

                        if (miConst == num)
                        {
                            Console.WriteLine("El numero es igual a la constante");
                        }

                        if (miConst !=num)
                        {
                            Console.WriteLine("El numero es distinto a la constante");
                        }
                        if (miConst > num)
                        {
                            Console.WriteLine("El numero es menor a la constante");
                        }
                        if (miConst < num)
                        {
                            Console.WriteLine("El numero es mayor a la constante");
                        }

                        #endregion

                */
            #region ReadKey
            Console.ReadKey();
            #endregion


        }
    }
}
