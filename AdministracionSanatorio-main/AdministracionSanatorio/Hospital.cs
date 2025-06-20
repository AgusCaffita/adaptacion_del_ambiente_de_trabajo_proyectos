using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Hospital
    {
        public List<Doctor> Doctores { get; set; } = new List<Doctor>();
        public List<Paciente> Pacientes { get; set; } = new List<Paciente>();
        public List<Intervencion> Intervenciones { get; set; } = new List<Intervencion>();

        public Hospital()
        {
            // Doctores
            Doctores.Add(new Doctor("Juan Pérez", "12345", "Cardiología", true));
            Doctores.Add(new Doctor("Laura Gómez", "23456", "Traumatología", false));
            Doctores.Add(new Doctor("Carlos Ruiz", "34567", "Neurología", true));
            Doctores.Add(new Doctor("María Silva", "45678", "Gastroenterología", true));
            Doctores.Add(new Doctor("Fernando Torres", "56789", "Cardiología", true));
            Doctores.Add(new Doctor("Cecilia López", "67890", "Traumatología", true));

            // Pacientes
            Pacientes.Add(new Paciente("30111222", "Ana Torres", "1111-2222", "ObraMed", 80));
            Pacientes.Add(new Paciente("29222333", "Luis Fernández", "2222-3333", null, 0));
            Pacientes.Add(new Paciente("28444555", "Clara Méndez", "3333-4444", "SaludPlus", 90));
            Pacientes.Add(new Paciente("27555666", "Pedro Gómez", "4444-5555", "VidaTotal", 70));
            Pacientes.Add(new Paciente("26666777", "Lucía Ortega", "5555-6666", null, 0));
            Pacientes.Add(new Paciente("25777888", "Jorge Ramírez", "6666-7777", "SaludPlus", 60));

            // Intervenciones comunes
            Intervenciones.Add(new IntervencionComun("INT001", "Bypass coronario", "Cardiología", 120000));
            Intervenciones.Add(new IntervencionComun("INT003", "Artroscopía de rodilla", "Traumatología", 80000));
            Intervenciones.Add(new IntervencionComun("INT005", "Endoscopía digestiva", "Gastroenterología", 40000));
            Intervenciones.Add(new IntervencionComun("INT007", "Colocación de stent", "Cardiología", 95000));
            Intervenciones.Add(new IntervencionComun("INT008", "Reducción de fractura", "Traumatología", 60000));

            // Intervenciones de alta complejidad
            Intervenciones.Add(new IntervencionAltaComplejidad("INT002", "Neurocirugía", "Neurología", 200000));
            Intervenciones.Add(new IntervencionAltaComplejidad("INT004", "Revascularización miocárdica", "Cardiología", 250000));
            Intervenciones.Add(new IntervencionAltaComplejidad("INT006", "Cirugía de columna", "Traumatología", 180000));
            Intervenciones.Add(new IntervencionAltaComplejidad("INT009", "Cirugía bariátrica", "Gastroenterología", 220000));
            Intervenciones.Add(new IntervencionAltaComplejidad("INT010", "Craneotomía", "Neurología", 270000));
        }

        public void agregarPaciente(string dni, string nombre, string telefono, string os, int cobertura)
        {
                Pacientes.Add(new Paciente(dni, nombre, telefono, os, cobertura));
        }



        public void mostrarPacientes()
        {
            foreach (Paciente paciente in Pacientes)
            {
                paciente.MostrarPaciente();
                Console.WriteLine("\n");
            }
        }

        public void agregarIntervencion(string documento)
        {
            Paciente pc = null;
            foreach (Paciente paciente in Pacientes)
            {
                if (paciente.Dni == documento)
                    pc = paciente;
            }

            if(pc == null)
            {
                Console.WriteLine("No hay paciente con ese documento, intente de nuevo");

            }
            else
            {
                Console.WriteLine("Ingrese complejidad de la intervencion");
                string complejidad = Console.ReadLine();
                Console.WriteLine("Ingrese codigo de la intervencion");
                string codigo = Console.ReadLine();
                Console.WriteLine("Ingrese descripcion de la intervencion");
                string descripcion = Console.ReadLine();
                Console.WriteLine("Ingrese especialidad de la intervencion");
                string especialidad = Console.ReadLine();
                Console.WriteLine("Ingrese precio de la intervencion");
                int precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese fecha de la intervencion");
                string fecha = Console.ReadLine();
                Console.WriteLine("Ingrese doctor de la intervencion (nombre completo");
                string name = Console.ReadLine();
                Doctor doc = null;
                foreach(Doctor doct in Doctores)
                {
                    if(doct.nombreCompleto == name)
                    {
                        doc = doct;
                    }
                }
                Console.WriteLine("Pagó la intervencion?");
                bool pago = bool.Parse(Console.ReadLine());
                if(doc == null)
                {
                    Console.WriteLine("No se encontro el doctor");
                }
                else
                {
                    pc.agregarIntervencion(fecha, doc, pago, complejidad, codigo, descripcion, especialidad, precio);
                }

            }
        }


        public void calcularCosto(string documento, string codigo)
        {
            Paciente paciente = null;
            Intervencion intervencion = null;
            foreach(Paciente pac in Pacientes)
            {
                if(pac.Dni == documento)
                {
                    paciente = pac;
                }
            }

            if(paciente == null)
            {
                Console.WriteLine("No se ha encontrado paciente con ese documento");
                return;
            }

            foreach (Intervencion inte in Intervenciones)
            {
                if (inte.Codigo == codigo)
                {
                    intervencion = inte;
                }
            }

            if (intervencion == null)
            {
                Console.WriteLine("No se ha encontrado intervencion con ese codigo");
                return;
            }

            decimal costo = 0;
            costo = intervencion.Precio * (1 - (decimal)paciente.Cobertura / 100);

            Console.WriteLine("El costo de la intervencion es: " + costo);
        }

        public void calcularDeuda(string documento)
        {
            Paciente paciente = null;
            
            foreach (Paciente pac in Pacientes)
            {
                if (pac.Dni == documento)
                {
                    paciente = pac;
                }
            }

            if (paciente == null)
            {
                Console.WriteLine("No se ha encontrado paciente con ese documento");
                return;
            }

            paciente.intervencionesNoPagas();
        }
    }
}

