using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Decorator
{
    public class DecoradorRecuadro: DecoradorSuscriptor
    {
        public DecoradorRecuadro(Mostrable c) : base(c)
        {
        }

        public override string mostrarInfo()
        {
            string texto = $"* {componente.mostrarInfo()} *";
            string borde = new string('*', texto.Length);
            return $"{borde}\n{texto}\n{borde}";
        }
    }
}
