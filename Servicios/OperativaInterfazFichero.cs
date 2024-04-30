using RPACCIA4EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA4EV.Servicios
{
    internal interface OperativaInterfazFichero
    {
        public void operacionFichero(List<PacienteDto> listaPacientes);
    }
}
