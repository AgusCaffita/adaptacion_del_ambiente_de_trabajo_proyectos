using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public abstract class Intervencion
    {
        protected string codigo;
        protected string descripcion;
        protected string especialidad;
        protected decimal precio;
        public Intervencion(string codigo, string descripcion, string especialidad, int precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.especialidad = especialidad;
            this.precio = precio;
        }
        
    }
    
    public class IntervencionComun: Intervencion
    {
         public IntervencionComun(string codigo, string descripcion, string especialidad, int precio): base(codigo, descripcion, especialidad, precio) { }
        
    }

    public class IntervencionAltaComplejidad: Intervencion
    {
        static double adicional;
        public IntervencionAltaComplejidad(string codigo, string descripcion, string especialidad, int precio): base(codigo, descripcion, especialidad, precio)
        {
            this.precio = ((decimal)adicional * precio / 100) + precio;
        }
    }
}

