using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio94
{
    internal class Aleatorios
    {
        private Random random = new Random();

        public Aleatorios()
        {
            random = new Random();
        }

        public int GenerarNumero(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public int[] GenerarArreglo(int cantidad, int min, int max)
        {
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = GenerarNumero(min, max);
            }
            return arreglo;
        }
    }
}
