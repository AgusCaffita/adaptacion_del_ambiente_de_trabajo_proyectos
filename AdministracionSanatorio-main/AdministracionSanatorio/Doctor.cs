using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Doctor
    {
        string nombreCompleto;
        string matricula;
        string especialidad;
        bool puedeIntervenir;

        public Doctor(string nombreCompleto, string matricula, string especialidad, bool puedeIntervenir)
        {
            this.nombreCompleto = nombreCompleto;
            this.matricula = matricula;
            this.especialidad = especialidad;
            this.puedeIntervenir = puedeIntervenir;
        }
    }
}


