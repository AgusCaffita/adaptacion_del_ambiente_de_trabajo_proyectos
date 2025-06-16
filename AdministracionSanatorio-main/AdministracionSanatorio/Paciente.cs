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
            else if(complejidad== "alta")
            {
                Intervenciones.Add(new IntervencionAltaComplejidad(codigo, descripcion, especialidad, precio));
            }
            else
            {
                Console.WriteLine("Complejidad no válida, intente de nuevo");
            }
        }

        public void MostrarPaciente()
        {
            Console.WriteLine("DNI: " + Dni);
            Console.WriteLine("Nombre: " + NombreCompleto);
            Console.WriteLine("Teléfono: " + Telefono);
            Console.WriteLine("Obra social: " + ObraSocial);
            Console.WriteLine("Cobertura: " + Cobertura + "%");
            foreach(Intervencion inte in Intervenciones){
                inte.MostrarIntervencion();
                Console.WriteLine("\n");
            }
            
        }

        


        public void intervencionesNoPagas()
        {

        }
    }
}
