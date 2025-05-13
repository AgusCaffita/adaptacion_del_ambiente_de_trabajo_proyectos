using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    class Paciente
    {
        public int DNI;
        public string nombre;
        public string apellido;
        public int telefono; 
        public string obraSocial;
        public int cobertura;
        List<Intervencion> intervenciones = new List<Intervencion>();

        public void Paciente(int dni, string name, string sname, int tel, string os)
        {
            this.DNI = dni;
            nombre = name;
            apellido = sname;
            telefono = tel;
            obraSocial = os;
            if(obraSocial == "OSDE")
            {
                cobertura = 80;
            }else if(obraSocial == "Swiss Medical")
            {
                cobertura = 90;
            }else if(obraSocial == "IAPOS")
            {
                cobertura = 70;
            }

           
        }


        public void agregarIntervencion()
        {
            intervenciones.Add(codigo);
        }

        public void intervencionesNoPagas()
        {

        }
    }
}
