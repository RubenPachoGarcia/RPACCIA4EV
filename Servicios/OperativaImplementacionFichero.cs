using RPACCIA4EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA4EV.Servicios
{
    internal class OperativaImplementacionFichero:OperativaInterfazFichero
    {
        //Metodo para añadir los datos del fichero a la lista de pacientes 
        public void operacionFichero(List<PacienteDto> listaPacientes)
        {
            string rutaFichero = "C:\\Users\\ruben\\Desktop\\Programacion\\RPACCIA4EV\\citasConAsistencia-30042024.txt";
            string contenidoFichero;

            using (StreamReader sr = new StreamReader(rutaFichero))
            {
                contenidoFichero = sr.ReadToEnd();
            }

            string[] ficheroArray = contenidoFichero.Split('\n');

            for (int i = 0; i < ficheroArray.Length; i++)
            {
                PacienteDto paciente = new PacienteDto();
                string[] pacienteArray = ficheroArray[i].Split(';');
                
                //Console.WriteLine(pacienteArray);
                //Console.WriteLine(pacienteArray.Length);

                paciente.DniPaciente = ficheroArray[0];
                paciente.NombrePaciente = ficheroArray[1];
                paciente.ApellidosPaciente = ficheroArray[2];
                paciente.EspecialidadPaciente = ficheroArray[3];
                paciente.FechaCitaPaciente = ficheroArray[4];
                paciente.AsistenciaCitaPaciente = ficheroArray[5];

                listaPacientes.Add(paciente);
            }
        }
    }
}
