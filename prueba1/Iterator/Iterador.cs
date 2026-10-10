using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}
