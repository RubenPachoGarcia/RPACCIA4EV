using RPACCIA4EV.Dtos;
using RPACCIA4EV.Servicios;

namespace RPACCIA4EV
{
    class Program
    {
        //Metodo main que controla el flujo de nuestra aplicacion
        public static void Main(string[] args)
        {
            List<PacienteDto> listaPacientes = new List<PacienteDto>();

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            OperativaInterfazFichero oif = new OperativaImplementacionFichero();

            oif.operacionFichero(listaPacientes);
                        
            int opcion;
            bool cerrarMenu = false;

                //Bucle while que controla las opciones elegidas por el usuario ylos metodos a ejecutar
                while (!cerrarMenu) 
            {
                Console.WriteLine("BIENVENIDO");
                opcion= mi.menuPrincipal();

                switch(opcion) 
                { 
                    case 0:
                        Console.WriteLine("Se cierra la aplicacion");
                        cerrarMenu= true;
                        break;
                    case 1:
                        Console.WriteLine("Se ejecuta la opcion 1");
                        oi.validarDNI(listaPacientes);
                        break;
                    case 2:
                        Console.WriteLine("Se ejecuta la opcion 2");
                        oi.listadoConsultas(listaPacientes);
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no existe");
                        break;
                }
            }
        }
    }
}