using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    abstract public class Perfil:Comparable{
        private string nombre;
        private int id;

        public Perfil(string n, int i)
        {
            this.nombre = n;
            this.id = i;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getId()
        {
            return id;
        }

        public virtual bool sosIgual(Comparable c)
        {
            Perfil p = (Perfil)c;
            if(this.id == p.id)
            {
                return true;
            }
            return false;
        }

        public virtual bool sosMenor(Comparable c)
        {
            Perfil p = (Perfil)c;
            if (this.id < p.id)
            {
                return true;
            }
            return false;
        }

        public virtual bool sosMayor(Comparable c)
        {
            Perfil p = (Perfil)c;
            if (this.id > p.id)
            {
                return true;
            }
            return false;
        }

    }
}
