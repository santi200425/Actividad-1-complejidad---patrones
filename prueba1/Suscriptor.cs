using prueba1.Observer;
using prueba1.strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class Suscriptor:Perfil, IObservador, Mostrable{

        private int mesesDeSuscripcion;
        private int horasVistas;
        IEstrategia comparacion;

        public Suscriptor(string n, int i, int c, int h) : base(n, i)
        {
            this.mesesDeSuscripcion = c;
            this.horasVistas = h;
            comparacion=new porMesesDeSuscripcion();
        }

        public void actualizar(IObservado o)
        {
            if(o is Canal)
            {
                Canal canal = (Canal)o;
                if (canal.getUltimoEvento()=="contenido nuevo")
                {
                    this.verContenido();
                }
                else
                {
                    this.reaccionarANotificacion();
                }
            }
        }

        public void cambiarComparacion(IEstrategia nueva_comparacion)
        {
            comparacion = nueva_comparacion;
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
            return comparacion.sosIgual(this, c);
        }

        public override bool sosMenor(Comparable c)
        {
            return comparacion.sosMenor(this, c);
        }

        public override bool sosMayor(Comparable c)
        {
            return comparacion.sosMayor(this, c);
        }

        public override string ToString()
        {
            return "nombre: " + this.getNombre() + ", id: " + this.getId() + ", meses de suscripcion: " + this.mesesDeSuscripcion + ", horas vistas: " + this.horasVistas;
        }

        public void verContenido()
        {
            Console.WriteLine("viendo el nuevo contenido");
        }

        public void reaccionarANotificacion()
        {
            Random random = new Random();
            string[] reacciones = {"abriendo la notificacion", "lo veo despues", "silenciando notificaciones"};
            Console.WriteLine(reacciones[random.Next(reacciones.Length)]);
        }

        public string mostrarInfo()
        {
            return $"{this.getNombre()} - {this.getHorasVistas()} horas vistas";
        }

        public Suscriptor getSuscriptor()
        {
            return this;
        }

    }
}
