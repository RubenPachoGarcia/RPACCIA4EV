using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA4EV.Servicios
{
    internal class MenuImplementacion: MenuInterfaz
    {
        //Metodo que ejecuta el menu principal para que el usuario decida la opcion que desee
        public int menuPrincipal()
        {
            int opcionUsuario;

            Console.WriteLine("CENTRO MEDICO");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Registro de llegada");
            Console.WriteLine("2. Listado de consultas");
            Console.WriteLine("-------------------------------"); 
            Console.WriteLine("Introduzca la opcion que desee: ");

            opcionUsuario=Console.ReadKey(true).KeyChar - ('0');

            return opcionUsuario;
        }
    }
}
