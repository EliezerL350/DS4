using System;

namespace Laboratorio33
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

            float horizontales, verticales;

            Console.Write("Introduce el tamaño de uno de los lados horizontales: ");
            horizontales = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el tamaño de uno de los lados vertivales: ");
            verticales = Convert.ToInt32(Console.ReadLine());

            float perimetro = calculosMatematicos.calcular(horizontales, verticales);
            Console.WriteLine("Resultado {0}", perimetro);
        }
    }
    public class CalculosMatematicos
    {
        //Metodo de calculo del perimetro
        public float calcular(float ladosHorizontales, float ladosVerticales)
        {
            float resultado = (ladosHorizontales * 2) + (ladosVerticales * 2);
            return resultado;
        }
    }

}
