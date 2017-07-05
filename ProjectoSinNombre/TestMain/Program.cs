using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestMain
{
    class Program
    {
        static void Metodito()
        {
            Console.WriteLine("\n~~ El empleado sigue cobrando mucho!  ~~\n");
        }

        public void Metodito2()
        {
            Console.WriteLine("\n~~ El empleado cobra mucho!  ~~\n");
        }

        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Juan", "Perez", 2);
            Program p = new Program();

            try
            {
                e1.Sueldo = -5;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            e1.SueldoEvent += p.Metodito2;
            e1.SueldoEvent += Metodito;
            e1.Sueldo = 9501;

            e1.SueldoEvent -= p.Metodito2;
            e1.Sueldo = 9502;

            Console.WriteLine(e1.ToString());

            Console.ReadLine();
        }
    }
}
