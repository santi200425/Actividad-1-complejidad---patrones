using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class Suscriptor:Perfil{

        private int mesesDeSuscripcion;
        private int horasVistas;

        public Suscriptor(string n, int i, int c, int h) : base(n, i)
        {
            this.mesesDeSuscripcion = c;
            this.horasVistas = h;
        }

        public int getMesesDeSuscripcion()
        {
            return this.mesesDeSuscripcion;
        }

        public int getHorasVistas()
        {
            return this.horasVistas;
        }

        public override bool sosIgual(Comparable c)
        {
            Suscriptor p = (Suscriptor)c;
            if (this.mesesDeSuscripcion == p.mesesDeSuscripcion)
            {
                return true;
            }
            return false;
        }

        public override bool sosMenor(Comparable c)
        {
            Suscriptor p = (Suscriptor)c;
            if (this.mesesDeSuscripcion < p.mesesDeSuscripcion)
            {
                return true;
            }
            return false;
        }

        public override bool sosMayor(Comparable c)
        {
            Suscriptor p = (Suscriptor)c;
            if (this.mesesDeSuscripcion > p.mesesDeSuscripcion)
            {
                return true;
            }
            return false;
        }

    }
}
