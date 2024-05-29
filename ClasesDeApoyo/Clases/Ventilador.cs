using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeApoyo.Clases
{
     public class Ventilador
    
    {
        //CAMPOS
        private string Color;
        private string Marca;
        private bool Encendido;

        //Propiedades 
        public int Velocidad { get; set; }
        public int Movimiento { get; set; }

        public Ventilador(string color, string marca)
        {
            Color = color;
            Marca = marca;
        }
        public void Encender()
        {
            this.Encendido = true;
        }
      
    }
      
    

}
