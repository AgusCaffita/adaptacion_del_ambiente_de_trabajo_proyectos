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
                Console.WriteLine("presione: \n  1 para agregar paciente\n  2 para agregar medico\n  3 para agregar intervencion\n  4 para realizar una intervencion\n  5 para ver deudas de un paciente\n  6 para salir");
            }
            

        }
    }
}

