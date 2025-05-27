using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Paciente
    {
        public string dni;
        public string nombreCompleto;
        public string telefono; 
        public string obraSocial;
        public int cobertura;
        public List<Intervencion> Intervenciones { get; set; } = new List<Intervencion>();

        public Paciente(string dni, string nombreCompleto, string telefono, string obraSocial, int cobertura)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.obraSocial = obraSocial;
            this.cobertura = cobertura;     
        }

        public void agregarIntervencion(string complejidad, string codigo, string descripcion, string especialidad, int precio)
        {
            if(complejidad == "comun")
            {
                Intervenciones.Add(new IntervencionComun(codigo, descripcion, especialidad, precio));
            }
            else
            {
                Intervenciones.Add(new IntervencionAltaComplejidad(codigo, descripcion, especialidad, precio));
            }
        }  //NO SE QUE ONDA LO DEL PRECIO

        public void intervencionesNoPagas()
        {

        }
    }
}
//  Intervenciones.Add(new IntervencionAltaComplejidad("INT002", "Neurocirugía", "Neurología", 200000));
// Intervenciones.Add(new IntervencionComun("INT001", "Bypass coronario", "Cardiología", 120000));
