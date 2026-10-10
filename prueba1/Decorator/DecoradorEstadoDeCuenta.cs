using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Decorator
{
    public class DecoradorEstadoDeCuenta: DecoradorSuscriptor
    {
        public DecoradorEstadoDeCuenta(Mostrable c): base(c)
        {

        }

        public override string mostrarInfo()
        {
            string estado_de_cuenta = null;

            if (componente.getSuscriptor().getHorasVistas() > 0)
            {
                estado_de_cuenta = "cuenta activa";

            }
            else
            {
                estado_de_cuenta = "cuenta inactiva";
            }

            if (componente.mostrarInfo().Contains("meses"))
            {
                return componente.mostrarInfo().Replace("meses", $"meses, {estado_de_cuenta}");
            }
            return $"{componente.getSuscriptor().getNombre()} ({estado_de_cuenta}) - {componente.getSuscriptor().getHorasVistas()} horas vistas";
        }
    }
}
