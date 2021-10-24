using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
     class Electrodomestico
    {
        protected float _precioBase = 0;
        protected float _peso;
        protected String _color, _consumoEnergetico;


        public float PrecioBase { get => _precioBase;  }
        public string Color { get => _color; set => _color = value; }
        public float Peso { get => _peso; set => _peso = value; }
        public String ConsumoEnergetico { get => _consumoEnergetico; set => _consumoEnergetico = value; }

        public Electrodomestico(float precioBase, float peso, string color, string consumoEnergetico) : this(precioBase, peso)
        {
            _precioBase = precioBase;
            _peso = peso;
            _color = color.ToUpper();
            _consumoEnergetico = consumoEnergetico.ToUpper();
        }


        public Electrodomestico()
        {
            this._precioBase = 100;
            _peso = 5;
            comprobarColor("x");
            comprobarConsumo("x");
        }

        public Electrodomestico(float precioBase, float peso)
        {
            _precioBase = precioBase;
            _peso = peso;
            comprobarColor("x");
            comprobarConsumo("x");
        }

        public void comprobarConsumo(String letra)
        {
            letra = letra.ToUpper();
            if (letra == "A" || letra == "B" || letra == "C" || letra == "D" || letra == "E" || letra == "F")
            {
                ConsumoEnergetico = letra;
            }
            else
            {
                ConsumoEnergetico = "F";
            }
        }
        public void comprobarColor(String color)
        {
            color = color.ToUpper();
            if (color == "BLANCO" || color == "NEGRO" || color == "ROJO" || color == "AZUL" || color == "GRIS")
            {
                _color = color;
            }
            else
            {
                Color = "BLANCO";
            }
        }

        public virtual void precioFinal()
        {
            float pFinal = this._precioBase;

            //Cálculo por consumo
            if      (_consumoEnergetico == "A") { pFinal += 100;}
            else if (_consumoEnergetico == "B") { pFinal += 80; }
            else if (_consumoEnergetico == "C") { pFinal += 60; }
            else if (_consumoEnergetico == "D") { pFinal += 50; }
            else if (_consumoEnergetico == "E") { pFinal += 30; } 
            else if (_consumoEnergetico == "F") { pFinal += 10; }
            
            //Cálculo por peso
            if      (_peso <  0 && _peso >= 19) { pFinal += 10; }
            else if (_peso >= 20 && _peso<= 49) { pFinal += 50; }
            else if (_peso >= 50 && _peso <= 80){ pFinal += 80; }
            else if (_peso >  80)               { pFinal += 100;}

            this._precioBase = pFinal;
        }

        /*
        private void mostrarDatosGenerales(Electrodomestico el1)
        {
            Console.WriteLine("Precio: "+PrecioBase);
            Console.WriteLine("Peso: "+Peso+"kg");
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Consumo energetico: "+ConsumoEnergetico);
        }
        public void mostrarDatos(Electrodomestico el1)
        {
            if (el1 is Electrodomestico) 
            {
                Console.WriteLine("Electrodoméstico");
                mostrarDatosGenerales(el1);  
            }
            else if (el1 is Lavadora) 
            { 
                Console.WriteLine("Lavadora");
                mostrarDatosGenerales(el1);
            }
            else if (el1 is Television) 
            { 
                Console.WriteLine("Television");
                mostrarDatosGenerales(el1);
            }


        }
        */
    }
}
