using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public abstract class Intervencion
    {
        public string Codigo;
        public string Descripcion;
        public string Especialidad;
        public decimal Precio;
        public Intervencion(string codigo, string descripcion, string especialidad, int precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Especialidad = especialidad;
            Precio = precio;
        }

        public void MostrarIntervencion()
        {
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Descripcion: " + Descripcion);
            Console.WriteLine("Especialidad: " + Especialidad);
            Console.WriteLine("Precio: " + Precio);
        }
    }
    
    public class IntervencionComun: Intervencion
    {
         public IntervencionComun(string codigo, string descripcion, string especialidad, int precio): base(codigo, descripcion, especialidad, precio) { }
        
    }

    public class IntervencionAltaComplejidad: Intervencion
    {
        static double Adicional = 50;
        public IntervencionAltaComplejidad(string codigo, string descripcion, string especialidad, int precio): base(codigo, descripcion, especialidad, precio)
        {
            Precio = ((decimal)Adicional * precio / 100) + precio;
            
        }
    }


}

