using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVector10
{
    class PruebaVector10
    {
        private string[] nombres;
        private int[] edades;

        public void Cargar()
        {
            nombres = new string[10];

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre:");
                nombres[f] = Console.ReadLine();
            }
        }

        public void MayoresEdad()
        {

            for (int f = 0; f < nombres.Length; f++)
            {

                {
                    Console.WriteLine(nombres[f]);
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector10 pv = new PruebaVector10();
            pv.Cargar();
            pv.MayoresEdad();
        }
    }
}