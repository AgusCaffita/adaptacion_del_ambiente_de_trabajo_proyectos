using System;

namespace Cronometro
{
    public class Cronometro
    {
        public int seg;
        public int min;

        public void Reiniciar()
        {
            seg = 0;
            min = 0;
        }
        public void IncrementarTiempo()
        {
            seg++;
            if(seg == 60)
            {
                seg = 0;
                min++;
            }
        }
        public void MostrarTiempo()
        {
            Console.WriteLine(min + " minutos " + seg + " segundos");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cronometro tiempo = new Cronometro();
            for (int i = 0; i < 5000; i++)
            {
                tiempo.IncrementarTiempo();
                tiempo.MostrarTiempo();
            }
        }
    }
}