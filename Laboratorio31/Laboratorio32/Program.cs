using System;

namespace Laboratorio32
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

            float radio;

            Console.Write("Introduce el primer numero: ");
            radio = Convert.ToInt32(Console.ReadLine());


            float calcularOperacion = calculosMatematicos.calcularAreaCirculo(radio);
            Console.WriteLine("Resultado {0}", calcularOperacion);
        }
    }
    public class CalculosMatematicos
    {
        //Metodo de calculo para la operacion
        public float calcularAreaCirculo(float radio)
        {
            float resultado = (radio + radio) * 3.141516f;
            return resultado;
        }
    }

}