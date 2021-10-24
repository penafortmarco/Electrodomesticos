using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Television : Electrodomestico
    {
        private int _resolucion;
        private Boolean _sintTDT;


        public int Resolucion { get => _resolucion; set => _resolucion = value; }
        public bool SintTDT { get => _sintTDT; set => _sintTDT = value; }

        public Television() 
            : base()
        {
            this._resolucion = 20;
            this._sintTDT = false;
        }

        public Television(float precioBase, float peso, string color, string consumoEnergetico, int resolucion, bool sintonizador) 
            : base(precioBase, peso, color, consumoEnergetico)
        {
            this._resolucion = resolucion;
            this._sintTDT = sintonizador;
        }

        public Television(float precioBase, float peso) 
            : base(precioBase, peso)
        {
            this._resolucion = 20;
            this._sintTDT = false;
        }

        public new void precioFinal()
        {
            base.precioFinal();
            if (_resolucion > 40) { this._precioBase += PrecioBase * 0.30f; }
            if (_sintTDT == true) { this._precioBase += PrecioBase * 0.50f; }
        }
    }
}
