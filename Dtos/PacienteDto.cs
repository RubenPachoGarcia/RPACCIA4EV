using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA4EV.Dtos
{
    internal class PacienteDto
    {
        string dniPaciente = "aaaaa";
        string nombrePaciente = "aaaaa";
        string apellidosPaciente = "aaaaa";
        string especialidadPaciente = "aaaaa";
        string fechaCitaPaciente="aaaaa";
        string asistenciaCitaPaciente="aaaaa";

        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string ApellidosPaciente { get => apellidosPaciente; set => apellidosPaciente = value; }
        public string EspecialidadPaciente { get => especialidadPaciente; set => especialidadPaciente = value; }
        public string FechaCitaPaciente { get => fechaCitaPaciente; set => fechaCitaPaciente = value; }
        public string AsistenciaCitaPaciente { get => asistenciaCitaPaciente; set => asistenciaCitaPaciente = value; }

        public PacienteDto(string dniPaciente, string nombrePaciente, string apellidosPaciente, string especialidadPaciente, string fechaCitaPaciente, string asistenciaCitaPaciente)
        {
            this.dniPaciente = dniPaciente;
            this.nombrePaciente = nombrePaciente;
            this.apellidosPaciente = apellidosPaciente;
            this.especialidadPaciente = especialidadPaciente;
            this.fechaCitaPaciente = fechaCitaPaciente;
            this.asistenciaCitaPaciente = asistenciaCitaPaciente;
        }

        public PacienteDto()
        {
        }

        override
        public string ToString()
        {
            string objetoString = "";
            return objetoString;
        }
    }
}
