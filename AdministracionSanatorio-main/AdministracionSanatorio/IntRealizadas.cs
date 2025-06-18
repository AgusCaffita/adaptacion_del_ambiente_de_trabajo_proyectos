using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class IntRealizadas
    {
        private static int proximoId = 1;

        public string Fecha;
        public Doctor Doc;
        public int Id;
        public bool Pago;
        public Intervencion Interv;

        public IntRealizadas(string fecha, Doctor doc, bool pago, string complejidad, string codigo, string descripcion, string especialidad, int precio)
        {
            Id = proximoId;     
            proximoId++;

            Fecha = fecha;
            Doc = doc;
            Pago = pago;

            if (complejidad == "comun")
            {
                Interv = new IntervencionComun(codigo, descripcion, especialidad, precio);
            }
            else if (complejidad == "alta")
            {
                Interv = new IntervencionAltaComplejidad(codigo, descripcion, especialidad, precio);
            }
            else
            {
                Console.WriteLine("Complejidad no válida, intente de nuevo");
            }

        }

        public void MostrarIntervencion()
        {
            Console.WriteLine("Codigo: " + Interv.Codigo);
            Console.WriteLine("Descripcion: " + Interv.Descripcion);
            Console.WriteLine("Especialidad: " + Interv.Especialidad);
            Console.WriteLine("Precio: " + Interv.Precio);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("Doctor: " + Doc);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Pago?: " + Pago);
        }

    }
}