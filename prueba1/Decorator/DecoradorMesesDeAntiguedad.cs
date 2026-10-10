using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Decorator
{
    public class DecoradorMesesDeAntiguedad: DecoradorSuscriptor
    {
        public DecoradorMesesDeAntiguedad(Mostrable c) : base(c)
        {
        }

        public override string mostrarInfo()
        {
            int meses = componente.getSuscriptor().getMesesDeSuscripcion();
            return $"{componente.getSuscriptor().getNombre()} (suscriptor hace {meses} meses) - {componente.getSuscriptor().getHorasVistas()} horas vistas";
        }

    }
}
