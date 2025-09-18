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

            int calcular = calculosMatematicos.calcular(primerNumero, segundoNumero);
            Console.WriteLine("Resultado {0}", calcular);
        }
    }
    public class CalculosMatematicos
    {
        //Metodo de calculo
        public int calcular (int primerNumero, int segundoNumero)
        {
            int calcular = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);
            return calcular;
        }    
    }

}