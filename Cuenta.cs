using System;
using System.Collections.Generic;

namespace Techlonoshe20173CCuentas
{
    public class Cuenta
    {
        public long Numero {get; set;}
        public decimal Saldo {get; set;}

        public List<Persona> Titulares {get; set;}

        /// <summary>
        /// Constructor
        /// </summary>
        public Cuenta()
        {
            this.Saldo = 0;
            this.Titulares = new List<Persona>();
        }

        /// <summary>
        /// Constructor que recibe parámetro
        /// </summary>
        /// <param name="numero">Numero de Cuenta</param>
        public Cuenta(long numero)
        {
            this.Numero = numero;
            this.Saldo = 0;
            this.Titulares = new List<Persona>();
        }

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