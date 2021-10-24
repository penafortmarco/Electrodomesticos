using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Lavadora : Electrodomestico
    {
        private int _carga;

        public int Carga { get => _carga; set => _carga = value; }

        public Lavadora() : base()
        {
            Carga = 5;
        }
       
        public Lavadora(float precioBase, float peso)
            : base(precioBase, peso)
        {
            Carga = 5;
        }

        public Lavadora(float precioBase, float peso, string color, string consumoEnergetico, int carga) 
            : base(precioBase, peso, color, consumoEnergetico)
        {
            this._carga = carga;
        }

        public new void precioFinal()
        {
            base.precioFinal();
            if (_carga > 30) { this._precioBase += 50; }
        }
    }
}
