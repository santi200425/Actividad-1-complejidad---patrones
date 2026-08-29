using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public interface Coleccionable{
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene(Comparable c);
    }
}
