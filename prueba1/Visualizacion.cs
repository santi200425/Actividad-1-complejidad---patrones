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
            Visualizacion v = (Visualizacion)c;
            if (this.cantidad == v.getcantidad()){
                return true;
            }
            else{
                return false;
            }
        }

        public bool sosMenor(Comparable c){
            Visualizacion v = (Visualizacion)c;
            if (this.cantidad < v.getcantidad()){
                return true;

            }
            else {
                return false;
            }
        }

        public bool sosMayor(Comparable c){
            Visualizacion v = (Visualizacion)c;
            if (this.cantidad > v.getcantidad()){
                return true;

            }
            else{
                return false;
            }
        }

    }
}
