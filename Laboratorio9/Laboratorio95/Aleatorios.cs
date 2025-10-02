using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio95
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

        public int[] GenerarArreglosNoRepetidos(int cantidad, int min, int max) 
        {
            if (cantidad > (max - min + 1))
            {
                throw new ArgumentException("No se puede generar mas numeros sin que se repita");
            }

            List<int> posiblesNumeros = new List<int>();
            for (int i = min; i <= max; i++)
            {
                posiblesNumeros.Add(i);
            }

            for (int i = posiblesNumeros.Count - 1; i >= 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = posiblesNumeros[j];
                posiblesNumeros[j] = temp;
            }

            return posiblesNumeros.GetRange(0, cantidad).ToArray();
        }
    }
}
