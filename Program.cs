using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomestico> elList = new List<Electrodomestico>();

            Electrodomestico elEstandar = new Electrodomestico( 500, 12, "negro",  "a");
            Lavadora lav1 = new Lavadora(1200, 50);
            Television tele1 = new Television(1000, 15);
            
            

            elList.Add(elEstandar);
            elList.Add(lav1);
            elList.Add(tele1);

            float costoTotalElectro=0;
            float costoTotalLavadoras = 0;
            float costoTotalTeles = 0;


            foreach (Electrodomestico i in elList)
            {
                i.precioFinal();
                costoTotalElectro += i.PrecioBase;
                if (i is Lavadora)
                {
                    costoTotalLavadoras += i.PrecioBase;
                }
                if (i is Television)
                {
                    costoTotalTeles += i.PrecioBase;
                }
            }

          
            Console.WriteLine("El costo total de Lavadoras es $"+costoTotalLavadoras);
            Console.WriteLine("El costo total de Televisiones es $"+costoTotalTeles);
            Console.WriteLine("Costo total de Electrodomesticos es $" + costoTotalElectro);
            Console.ReadKey();
        }
    }
}
