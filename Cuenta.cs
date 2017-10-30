using System;

namespace Techlonoshe20173CCuentas
{
    public class Cuenta
    {
        public long Numero {get; set;}
        public decimal Saldo {get; set;}

        public Persona Titular {get; set;}

        /// <summary>
        /// Se retira dinero de la cuenta.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns>True si la operación es correcta, False si no.</returns>
        public bool RetirarDinero(decimal cantidad)        
        {
            if(Saldo >= cantidad)
            {
                this.Saldo -= cantidad; // this.Saldo = this.Saldo - cantidad;
                return true;
            }
            return false;
        }

        public bool DepositarDinero(decimal cantidad)
        {
            this.Saldo += cantidad;
            return true;
        }
        
    }
}