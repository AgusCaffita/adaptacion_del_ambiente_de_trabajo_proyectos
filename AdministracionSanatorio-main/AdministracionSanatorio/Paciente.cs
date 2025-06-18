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
        public List<IntRealizadas> Intervenciones { get; set; } = new List<IntRealizadas>();

        public Paciente(string dni, string nombreCompleto, string telefono, string obraSocial, int cobertura)
        {
            Dni = dni;
            NombreCompleto = nombreCompleto;
            Telefono = telefono;
            ObraSocial = obraSocial;
            Cobertura = cobertura;
        }

        public void agregarIntervencion(string fecha, Doctor doc,bool pago, string complejidad, string codigo, string descripcion, string especialidad, int precio)
        {
            Intervenciones.Add(new IntRealizadas(fecha, doc, pago, complejidad, codigo, descripcion, especialidad, precio));
        }

        public void MostrarPaciente()
        {
            Console.WriteLine("DNI: " + Dni);
            Console.WriteLine("Nombre: " + NombreCompleto);
            Console.WriteLine("Teléfono: " + Telefono);
            Console.WriteLine("Obra social: " + ObraSocial);
            Console.WriteLine("Cobertura: " + Cobertura + "%");
            foreach (IntRealizadas inte in Intervenciones)
            {
                inte.MostrarIntervencion();
                Console.WriteLine("\n");
            }

        }




        public void intervencionesNoPagas()
        {
            decimal porPagar = 0;
            foreach(IntRealizadas intR in Intervenciones)
            {
                if(intR.Pago == false)
                {
                    Console.WriteLine("Id de operacion: " + intR.Id);
                    porPagar += intR.Interv.Precio;
                }
            }

            Console.WriteLine("Le faltan pagar (bruto) " + porPagar);
        }
    }
}