using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Par_Impar.Servicios
{
    internal class GuardarNumeroImplementacion : GuardarNumeroInterfaz
    {
        public int preguntarNumero()
        {
            Console.Write("\n\tIndique un número para saber si es par o impar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
