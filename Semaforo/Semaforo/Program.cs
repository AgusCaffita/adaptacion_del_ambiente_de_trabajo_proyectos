using System;
using System.Drawing;

namespace Semaforo
{
    public class Semaforo
    {
        public string colorActual;
        public int tiempo;
        public bool intermitente;

        public Semaforo(string colorActual)
        {
            intermitente = false;
            tiempo = 0;
            this.colorActual = colorActual;
        }

        public void PasoDelTiempo(int segundos)
        {
            if (intermitente)
            {
                tiempo += segundos;
            }
            else
            {
                tiempo += segundos;

                while (tiempo >= 55)
                {
                    tiempo = tiempo - 55;
                }

                if (colorActual == "Rojo")
                {
                    if (tiempo > 30)
                    {
                        colorActual = "Rojo-Amarillo";
                        tiempo = tiempo - 30;
                    }
                }
                if (colorActual == "Rojo-Amarillo")
                {
                    if (tiempo > 2)
                    {
                        colorActual = "Verde";
                        tiempo = tiempo - 2;
                    }
                }
                if (colorActual == "Verde")
                {
                    if (tiempo > 20)
                    {
                        colorActual = "Amarillo";
                        tiempo = tiempo - 20;
                    }
                }
                if (colorActual == "Amarillo")
                {
                    if (tiempo > 2)
                    {
                        colorActual = "Rojo";
                        tiempo = tiempo - 2;
                    }
                }
            }
        }

        public string MostrarColor()
        {
            if (intermitente)
            {
                if ((tiempo % 2) == 0)
                    return "Amarillo";
                else
                    return "Apagado";
            }
            else
            {
                return colorActual;
            }
        }

        public void PonerEnIntermitente()
        {
            intermitente = true;
            tiempo = 0;
        }

        public void SacarDeIntermitente()
        {
            intermitente = false;
            tiempo = 0;
        }
    }

    // Ejemplo de uso:
    class Program
    {
        static void Main()
        {

            Semaforo semaforo = new Semaforo("Rojo");

            Console.WriteLine(semaforo.MostrarColor());
            semaforo.PasoDelTiempo(55);
            Console.WriteLine(semaforo.MostrarColor());

            semaforo.PasoDelTiempo(100);
            Console.WriteLine(semaforo.MostrarColor());

            semaforo.PonerEnIntermitente();
            for (int i = 0; i < 5; i++)
            {
                semaforo.PasoDelTiempo(1);
                Console.WriteLine(semaforo.MostrarColor());
            }

            semaforo.SacarDeIntermitente();
            Console.WriteLine(semaforo.MostrarColor());
        }
    }

}