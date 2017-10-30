using System;

namespace Techlonoshe20173CCuentas
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(): base()
        {
        }

        public CuentaCorriente(long numero) : base(numero)
        {
        }

        public override bool RetirarDinero(decimal cantidad)
        {
            this.Saldo -= cantidad;
            this.Operaciones.Add(new Operacion { Monto = -1 * cantidad,
                                            Fecha = DateTime.Now,
                                            Tipo = "Extracción"});
            return true;
        }
    }
}