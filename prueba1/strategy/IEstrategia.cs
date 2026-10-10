using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.strategy
{
    public interface IEstrategia
    {
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMenor(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
    }
}
