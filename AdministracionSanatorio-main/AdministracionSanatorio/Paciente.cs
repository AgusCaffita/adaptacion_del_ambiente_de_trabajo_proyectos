using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Paciente
    {
        public string Dni;
        public string NombreCompleto;
        public string Telefono; 
        public string ObraSocial;
        public int Cobertura;
        public List<Intervencion> Intervenciones { get; set; } = new List<Intervencion>();

        public Paciente(string dni, string nombreCompleto, string telefono, string obraSocial, int cobertura)
        {
            Dni = dni;
            NombreCompleto = nombreCompleto;
            Telefono = telefono;
            ObraSocial = obraSocial;
            Cobertura = cobertura;     
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
        }

        public void MostrarPaciente(Paciente p)
        {
            Console.WriteLine("DNI: " + p.Dni);
            Console.WriteLine("Nombre: " + p.NombreCompleto);
            Console.WriteLine("Teléfono: " + p.Telefono);
            Console.WriteLine("Obra social: " + p.ObraSocial);
            Console.WriteLine("Cobertura: " + p.Cobertura + "%");
        }


        public void intervencionesNoPagas()
        {

        }
    }
}
//  Intervenciones.Add(new IntervencionAltaComplejidad("INT002", "Neurocirugía", "Neurología", 200000));
// Intervenciones.Add(new IntervencionComun("INT001", "Bypass coronario", "Cardiología", 120000));
