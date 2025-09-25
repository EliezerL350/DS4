using System;

namespace Laboratorio33
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

            float ladosHorizontales, ladosVerticales;
            Console.Write("Introduce el tamaño de uno de los lados verticales: ");
            ladosHorizontales = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el tamaño de uno de los lados horizontales: ");
            ladosVerticales = Convert.ToInt32(Console.ReadLine());

            float calcularOperacion = calculosMatematicos.calcularPerimetro(ladosHorizontales, ladosVerticales);
            Console.WriteLine("Resultado {0}", calcularOperacion);
        }
    }
    public class CalculosMatematicos
    {
        //Metodo de calculo para la operacion
        public float calcularPerimetro (float ladosHorizontales, float ladosVerticales)
        {
            float resultado = (ladosHorizontales * 2) + (ladosVerticales * 2);
            return resultado;
        }
    }

}
