using System;

namespace jugadorCansado
{
    interface Jugador
    {
        bool Correr(int minutos);
        bool Cansado();
        void Descansar(int minutos);
    }

    public class Amateur : Jugador
    {
        public bool cansado = false;
        public int minsQuePuedeCorrer = 20;
        public int minutosXCorrer = 20;

        public bool Correr(int mins)
        {
            if (mins > minsQuePuedeCorrer)
            {
                Console.WriteLine("El jugador no puede correr eso, es mucho para su cuerpito");
                return false;
            }
            if (mins == minsQuePuedeCorrer)
            {
                Console.WriteLine("Corrio " + mins + " y se canso");
                minutosXCorrer = 0;
                cansado = true;
                return true;
            }
            minutosXCorrer = minutosXCorrer - mins;
            Console.WriteLine("Corrio " + mins + " todavía puede correr " + minutosXCorrer);
            cansado = false;
            return true;
        }

        public bool Cansado()
        {
            if (minutosXCorrer == 0)
            {
                cansado = true;
            }
            return cansado;
        }

        public void Descansar(int minutos)
        {
            Console.WriteLine("El jugador ha descansado " + minutos + " minutos");
            if ((minutosXCorrer + minutos) <= minsQuePuedeCorrer)
            {
                minutosXCorrer = minutosXCorrer + minutos;
            }
            else if ((minutosXCorrer + minutos) > minsQuePuedeCorrer)
            {
                minutosXCorrer = minsQuePuedeCorrer;
            }
        }
    }

    public class Profesional : Jugador
    {
        public bool cansado = false;
        public int minsQuePuedeCorrer = 40;
        public int minutosXCorrer = 40;

        public bool Correr(int mins)
        {
            if (mins > minsQuePuedeCorrer)
            {
                Console.WriteLine("El jugador no puede correr eso, es mucho para su cuerpito");
                return false;
            }
            if (mins == minsQuePuedeCorrer)
            {
                Console.WriteLine("Corrio " + mins + " y se canso");
                minutosXCorrer = 0;
                cansado = true;
                return true;
            }
            minutosXCorrer = minutosXCorrer - mins;
            Console.WriteLine("Corrio " + mins + " todavía puede correr " + minutosXCorrer);
            cansado = false;
            return true;
        }

        public bool Cansado()
        {
            if (minutosXCorrer == 0)
            {
                cansado = true;
            }
            return cansado;
        }

        public void Descansar(int minutos)
        {
            Console.WriteLine("El jugador ha descansado " + minutos + " minutos");
            if ((minutosXCorrer + minutos) <= minsQuePuedeCorrer)
            {
                minutosXCorrer = minutosXCorrer + minutos;
            }
            else if ((minutosXCorrer + minutos) > minsQuePuedeCorrer)
            {
                minutosXCorrer = minsQuePuedeCorrer;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Profesional profesional = new Profesional();
            Amateur amateur = new Amateur();

            Console.WriteLine(profesional.Correr(20));
            Console.WriteLine(profesional.Correr(20));

            if (profesional.Cansado())
            {
                profesional.Descansar(26);
            }

            Console.WriteLine(profesional.Correr(90));
            Console.WriteLine(amateur.Correr(30));

            if (amateur.Cansado())
            {
                amateur.Descansar(40);
            }

            Console.WriteLine(amateur.Correr(90));
        }
    }
}
