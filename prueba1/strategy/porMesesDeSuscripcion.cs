using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.strategy
{
    public class porMesesDeSuscripcion: IEstrategia
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            
            if (c1 is Suscriptor && c2 is Suscriptor)
            {
                Suscriptor s1 = (Suscriptor)c1;
                Suscriptor s2 = (Suscriptor)c2;
                return s1.getMesesDeSuscripcion() == s2.getMesesDeSuscripcion();
            }
            return false;
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            
            if (c1 is Suscriptor && c2 is Suscriptor)
            {
                Suscriptor s1 = (Suscriptor)c1;
                Suscriptor s2 = (Suscriptor)c2;
                return s1.getMesesDeSuscripcion() < s2.getMesesDeSuscripcion();

            }
            return false;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            
            if (c1 is Suscriptor && c2 is Suscriptor)
            {
                Suscriptor s1 = (Suscriptor)c1;
                Suscriptor s2 = (Suscriptor)c2;
                return s1.getMesesDeSuscripcion() > s2.getMesesDeSuscripcion();
            }
            return false;
        }
    }
}
