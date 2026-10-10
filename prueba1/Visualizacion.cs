using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class Visualizacion:Comparable{
        private int cantidad;
        public Visualizacion(int c){
            this.cantidad = c;
        }
        public int getcantidad() {
            return cantidad;
        }

        public bool sosIgual(Comparable c){
            
            if (c is Visualizacion){
                Visualizacion v = (Visualizacion)c;
                return this.cantidad == v.getcantidad();
            }
            else{
                return false;
            }
        }

        public bool sosMenor(Comparable c){
            
            if (c is Visualizacion){
                Visualizacion v = (Visualizacion)c;
                return this.cantidad < v.getcantidad();

            }
            else {
                return false;
            }
        }

        public bool sosMayor(Comparable c){
            
            if (c is Visualizacion){
                Visualizacion v = (Visualizacion)c;
                return this.cantidad > v.getcantidad();

            }
            else{
                return false;
            }
        }

    }
}
