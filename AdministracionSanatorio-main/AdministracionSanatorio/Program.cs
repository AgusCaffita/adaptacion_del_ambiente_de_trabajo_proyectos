using System;

namespace AdministracionSanatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            Console.WriteLine("Bienvenido al happy hospital!!!! :D");
            
            bool bandera = true;
            while (bandera)
            {
                Console.WriteLine("¿Que quiere hacer hoy?");
                Console.WriteLine("presione: \n  1 para agregar paciente\n  2 para ver pacientes\n  3 para agregar intervencion a paciente\n  4 para calcular costo de una intervencion\n  5 para ver deudas de un paciente\n  6 para salir");
                string input = Console.ReadLine();
                int accion = int.Parse(input); 
                switch (accion) {
                    case 1:
                        Console.WriteLine("Ingrese DNI del paciente");
                        string dni = Console.ReadLine();
                        Console.WriteLine("Ingrese nombre completo del paciente");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese telefono del paciente (xxxx-xxxx");
                        string telefono = Console.ReadLine();
                        Console.WriteLine("Ingrese obra social del paciente");
                        string os = Console.ReadLine();
                        Console.WriteLine("Ingrese cobertura de esta obra social");
                        int cobertura = int.Parse(Console.ReadLine());
                        hospital.agregarPaciente(dni, nombre, telefono, os, cobertura);
                        break;

                    case 2:
                        hospital.mostrarPacientes();
                        break;

                    case 3:
                        Console.WriteLine("Ingrese DNI del paciente");
                        string documento = Console.ReadLine();
                        hospital.agregarIntervencion(documento);
                        break;

                    case 4:
                        Console.WriteLine("Ingrese documento del paciente");
                        string docu = Console.ReadLine();
                        Console.WriteLine("Ingrese codigo de la operacion");
                        string code = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Hasta luego :)");
                        bandera = false;
                        break;
                }
             }       
            

        }
    }
}

