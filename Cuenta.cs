using System;
using System.Collections.Generic;

namespace Techlonoshe20173CCuentas
{
    public class Cuenta
    {
        public long Numero {get; set;}
        public decimal Saldo {get; set;}

        public List<Persona> Titulares {get; set;}

        public List<Operacion> Operaciones {get;set;}

        /// <summary>
        /// Constructor
        /// </summary>
        public Cuenta()
        {
            this.Saldo = 0;
            this.Titulares = new List<Persona>();
            this.Operaciones = new List<Operacion>();
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
            this.Operaciones = new List<Operacion>();
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
                this.Operaciones.Add(new Operacion { Monto = -1 * cantidad,
                                            Fecha = DateTime.Now,
                                            Tipo = "Extracción"});
                return true;
            }
            return false;
        }

        public bool DepositarDinero(decimal cantidad)
        {
            this.Saldo += cantidad;
            this.Operaciones.Add(new Operacion { Monto = cantidad,
                                            Fecha = DateTime.Now,
                                            Tipo = "Depósito"});
            return true;
        }
        
        public void MostrarOperacionesRealizadas()
        {
            foreach(Operacion operación in this.Operaciones)
            {
                Console.WriteLine(string.Format("{0} {1}: {2}", 
                                            operación.Fecha.ToString("yyyy/MM/dd HH:mm:ss"),
                                            operación.Tipo,
                                            operación.Monto.ToString("C2")));
            }
        }
    }
}