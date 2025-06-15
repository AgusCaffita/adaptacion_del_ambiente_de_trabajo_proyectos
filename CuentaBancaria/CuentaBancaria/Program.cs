using System;

namespace CuentaBancaria
{
    public class CuentaBancaria
    {
        private int numeroCuenta;
        private double saldo;
        private string titular;

        public CuentaBancaria(int numeroCuenta, double saldo, string titular)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.titular = titular;
        }
        public double ObtenerSaldo()
        {
            return saldo;
        }
        public void ModificarSaldo(double nuevoSaldo)
        {
            saldo += nuevoSaldo;
        }
    }

    public class Banco
    {
      
        
        public void Depositar(double cantidad, CuentaBancaria cuentita)
        {
            for(bool i = true; i == true ;) {
                if (cantidad < 0)
                {
                    Console.WriteLine("Monto invalido, por favor ingrese otro monto");
                    cantidad = double.Parse(Console.ReadLine());
                }
                else
                {
                    i = false;
                }
            }
            cuentita.ModificarSaldo(cantidad);
        }
        public void Extraer(double cantidad, CuentaBancaria cuentita)
        {
            for (bool i = true; i == true;)
            {               
                if (cantidad > cuentita.ObtenerSaldo())
                {
                    Console.WriteLine("No puede extraer " + cantidad);
                    cantidad = double.Parse(Console.ReadLine());
                }
                else
                {
                    i = false;
                }
            }
            cuentita.ModificarSaldo(-cantidad);
        }
        public bool Transferencia(CuentaBancaria cuentaOrigen, double monto, CuentaBancaria cuentaDestino)
        {
            if (monto > cuentaOrigen.ObtenerSaldo() || monto < 0)
            {
                return false;
            }
            else
            {
                return true;
            }           
        }
    }

    class Program()
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            CuentaBancaria cuenta = new CuentaBancaria(1234, 2023.4, "luli");
            CuentaBancaria cuenta2 = new CuentaBancaria(1235, 3000, "agus");
            banco.Depositar(500, cuenta);
            Console.WriteLine("saldo:" + cuenta.ObtenerSaldo());
            banco.Extraer(3000, cuenta);
            Console.WriteLine("saldo:" + cuenta.ObtenerSaldo());
            double aTransferir = double.Parse(Console.ReadLine());
            bool trasferir = banco.Transferencia(cuenta2, aTransferir, cuenta);
            if (trasferir)
            {
                banco.Extraer(aTransferir, cuenta2);
                banco.Depositar(aTransferir, cuenta);
            }
            else
            {
                Console.WriteLine("la cuenta no tiene " + aTransferir + " para transferir");
            }
            Console.WriteLine("saldo:" + cuenta.ObtenerSaldo());

        }
    }
}
