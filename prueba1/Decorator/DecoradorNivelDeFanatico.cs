using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Decorator
{
    public class DecoradorNivelDeFanatico: DecoradorSuscriptor
    {
        public DecoradorNivelDeFanatico(Mostrable c): base(c)
        {

        }

        public override string mostrarInfo()
        {
            string nivelfanatico = null;
            int horas = componente.getSuscriptor().getHorasVistas();
            if (horas < 10)
            {
                nivelfanatico = "bronce";
            }
            else if (horas <= 49)
            {
                nivelfanatico = "plata";
            }
            else
            {
                nivelfanatico = "oro";
            }

            return $"[{nivelfanatico}] {componente.mostrarInfo()}";

        }
    }
}
