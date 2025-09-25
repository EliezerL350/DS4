using System;

namespace Laboratorio31
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

            int primerNumero, segundoNumero;

            Console.Write("Introduce el primer numero: ");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo numero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            int calcularOperacion = calculosMatematicos.calcularOperacion(primerNumero, segundoNumero);
            Console.WriteLine("Resultado {0}", calcularOperacion);
        }
    }
    public class CalculosMatematicos
    {
        //Metodo de calculo para la operacion
        public int calcularOperacion (int primerNumero, int segundoNumero)
        {
            int resultado = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);
            return resultado;
        }
    }

}