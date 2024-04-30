using RPACCIA4EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA4EV.Servicios
{
    internal interface OperativaInterfaz
    {
        /*
         * Metodo que valida si el DNI existe en la lista de pacientes
         * RPG-30042024
         */
        public void validarDNI(List<PacienteDto> listaPacientes);

        /*
         * Metodo que permite mostrar todo tipo de consultas segun elija el usuario
         * RPG-30042024
         */
        public void listadoConsultas(List<PacienteDto> listaPacientes);
    }
}
