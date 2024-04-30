using RPACCIA4EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA4EV.Servicios
{
    internal class OperativaImplementacion:OperativaInterfaz
    {
        MenuInterfaz mi = new MenuImplementacion();

        //Metodo que valida si el DNI existe en la lista de pacientes
        public void validarDNI(List<PacienteDto> listaPacientes)
        {
            PacienteDto paciente=new PacienteDto();

            Console.WriteLine("Introduce su DNI: ");
            string dni=Convert.ToString(Console.ReadLine());

            if (dni.Equals(paciente.DniPaciente))
            {
                Console.WriteLine("Espere su turno para la consulta de ".Concat(paciente.EspecialidadPaciente).Concat( "en la sala de espera. Su especialista le avisara"));
            }
            else
            {
                int opcionDNI;

                Console.WriteLine("No dispone de cita previa hoy");
                Console.WriteLine("0. Volver");
                Console.WriteLine("1. Intentarlo de nuevo");

                opcionDNI= Console.ReadKey(true).KeyChar - ('0');

                if(opcionDNI==0) 
                {
                    mi.menuPrincipal();
                }
                else if(opcionDNI==1)
                {
                    validarDNI(listaPacientes);
                }
                else
                {
                    Console.WriteLine("La opcion seleccionada no existe");
                }
            }
        }

        //Metodo que permite mostrar todo tipo de consultas segun elija el usuario
        public void listadoConsultas(List<PacienteDto> listaPacientes)
        {
            int opcionElegida;

            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Mostrar consultas");
            Console.WriteLine("2. Imprimir consultas");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Introduzca la opcion que desee: ");

            opcionElegida = Console.ReadKey(true).KeyChar - ('0');

            if(opcionElegida==0)
            {
                mi.menuPrincipal();
            }
            else if(opcionElegida==1)
            {
                foreach (PacienteDto pacientes in listaPacientes)
                {
                    string objeto = pacientes.DniPaciente + pacientes.NombrePaciente +
                        pacientes.ApellidosPaciente + pacientes.EspecialidadPaciente +
                        pacientes.FechaCitaPaciente + pacientes.AsistenciaCitaPaciente;
                    Console.WriteLine(objeto);
                }

                int opcionEspecialidad;

                Console.WriteLine("0. Volver");
                Console.WriteLine("1. Psicologia");
                Console.WriteLine("2. Traumatologia");
                Console.WriteLine("3. Fisioterapia");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Introduzca la opcion que desee: ");

                opcionEspecialidad = Console.ReadKey(true).KeyChar - ('0');
            }
            else if( opcionElegida==2)
            {
                
            }
            else
            {
                Console.WriteLine("La opcion seleccionada no existe");
            }
        }
    }
}