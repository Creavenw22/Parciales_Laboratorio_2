using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavadero;

namespace Test_Lavadero
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo("AAA 111", 5, EMarcas.Honda);
            Vehiculo v2 = new Vehiculo("AAA 222", 3, EMarcas.Scania);
            Vehiculo v3 = new Vehiculo("AAA 333", 6, EMarcas.Iveco);

            Auto a1 = new Auto("BBB 111", EMarcas.Fiat, 4);
            Auto a2 = new Auto("BBB 222", EMarcas.Ford, 5);
            Auto a3 = new Auto("BBB 333", EMarcas.Honda, 6);

            Camion c1 = new Camion(v1, 5000);
            Camion c2 = new Camion(v2, 7000);
            Camion c3 = new Camion(v3, 4000);

            Moto m1 = new Moto("CCC 111", 2, EMarcas.Honda);
            Moto m2 = new Moto("CCC 222", 4, EMarcas.Zanella);
            Moto m3 = new Moto("CCC 333", 2, EMarcas.Scania);

            Lavadero.Lavadero l1 = new Lavadero.Lavadero("San pepito");

            l1 += a1;
            l1 += a2;
            l1 += a3;
            l1 += c1;
            l1 += c2;
            l1 += c3;
            l1 += m1;
            l1 += m2;
            l1 += m3;

            Console.WriteLine(l1.LavaderoToString);
            Console.WriteLine(l1.MostrarTotalFacturado());
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Saco una moto y un camion\n");

            l1 -= c3;
            l1 -= m3;

            Console.WriteLine(l1.LavaderoToString);


            Console.ReadLine();

        }
    }
}
