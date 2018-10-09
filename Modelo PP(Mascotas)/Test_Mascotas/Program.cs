using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mascotas;

namespace Test_Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mascota> masco = new List<Mascota>();

            Perro p1 = new Perro("lucho", "dogo", 10, true);
            Perro p2 = new Perro("garflied", "acuaman", 11, false);
            int edadPerro;

            masco.Add(p1);
            masco.Add(p2);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 != p2);
            edadPerro = (int)p1;
            Console.WriteLine("Edad perro: {0}\r", edadPerro);

            Console.WriteLine("------------Gato---------\r");

            Gato g1 = new Gato("michi", "arabe");
            Gato g2 = new Gato("carla", "chui");

            masco.Add(g1);
            masco.Add(g2);

            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1 == g2);
            Console.WriteLine(g1 != g2);

            Console.WriteLine("\n\n ------La posta-------\r\r\n");

            Grupo g = new Grupo("Rio", Grupo.TipoManada.Mixta);

            g += p1;
            g += p2;
            g += g1;
            g -= p1;

            Console.WriteLine(g);



            Console.ReadLine();
        }
    }
}
