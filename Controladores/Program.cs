using Ejercicio_Par_Impar.Servicios;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Par_Impar
{
    /// <summary>
    /// Clase Principal de la aplicación
    /// </summary>
    class Program
    {
        static void Main(String[] args)
        {
            GuardarNumeroInterfaz guardarNum = new GuardarNumeroImplementacion();

            int numero = guardarNum.preguntarNumero();

            if ((numero%2) == 0)
                Console.WriteLine("\n\tEl número {0} es par.");

            else
                Console.WriteLine("\n\tEl número {0} es impar.");
        }
    }
}