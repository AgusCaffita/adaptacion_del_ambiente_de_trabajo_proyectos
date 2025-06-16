using System;

namespace figurita
{
    interface IVehiculo
    {
        void Mover(int tiempo);
        int Posicion();
        void ReiniciarPos();
    }

    class Auto : IVehiculo
    {
        public int posicion;
        public int vMax;

        public Auto(int v) 
        {
            posicion = 0;
            vMax = v;
        }

        public Auto() : this(40) 
        {
        }

        public int Posicion()
        {
            return posicion;
        }

        public void Mover(int tiempo)
        {
            posicion += vMax * tiempo;
            
        }

        public void ReiniciarPos()
        {
            posicion = 0;
        }
    }

    class Bicicleta : IVehiculo
    {
        public int posicion;
        public int vMax = 10;

        public Bicicleta() 
        {
            posicion = 0;
        }

        public int Posicion()
        {
            return posicion;
        }

        public void Mover(int tiempo)
        {
            posicion += vMax * tiempo; 
            
        }

        public void ReiniciarPos()
        {
            posicion = 0;
        }
    }

    class Camion : IVehiculo
    {
        public int posicion;
        public int vMax = 30; 

        public Camion() 
        {
            posicion = 0;
        }

        public int Posicion()
        {
            return posicion;
        }

        public void Mover(int tiempo)
        {
            posicion += vMax * tiempo; 
            
        }

        public void ReiniciarPos()
        {
            posicion = 0;
        }
    }

    class Carrera
    {
        public void Competir(IVehiculo vehiculo1, IVehiculo vehiculo2, int tiempo)
        {
            vehiculo1.ReiniciarPos(); 
            vehiculo2.ReiniciarPos();

            vehiculo1.Mover(tiempo);
            vehiculo2.Mover(tiempo);

            Console.WriteLine($"Posición final - Vehículo 1: {vehiculo1.Posicion()} m");
            Console.WriteLine($"Posición final - Vehículo 2: {vehiculo2.Posicion()} m");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auto fiat = new Auto(45); 
            Bicicleta bici = new Bicicleta(); 
            Camion camion = new Camion();

            bici.Mover(20); 
            Console.WriteLine(bici.Posicion()); 

            bici.Mover(10); 
            Console.WriteLine(bici.Posicion());

            Carrera carrera = new Carrera();
            carrera.Competir(fiat, bici, 10); 
        }
    }
}