using System;

namespace Techlonoshe20173CCuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Cuentas");
            //creamos persona
            Persona morty = new Persona();
            morty.Nombre = "Morty";
            morty.Apellido = "Smith";
            morty.DNI = 38234293;
            morty.Mail = "morty@mail.com";
            morty.FechaDeNacimiento = new DateTime(1990, 5, 1);

            //creamos cuenta
            Cuenta cuenta1 = new Cuenta();
            cuenta1.Numero = 231231;
            cuenta1.Saldo = 0;
            //le damos la cuenta a morty
            cuenta1.Titular = morty;

            if(cuenta1.DepositarDinero(400))
            {
                Console.WriteLine("Operación OK");
            }
            if(cuenta1.RetirarDinero(200))
            {
                Console.WriteLine("Operación OK");
            }
            if(cuenta1.RetirarDinero(300))
            {
                Console.WriteLine("Operación OK");
            }

            Console.WriteLine("La cuenta tiene un saldo: " + cuenta1.Saldo);
        }
    }
}
