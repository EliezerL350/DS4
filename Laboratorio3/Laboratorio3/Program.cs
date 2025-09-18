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

            Console.WriteLine("Resultado {0}", calculosMatematicos.calcular);
        }
    }
    public class CalculosMatematicos
    {
        int primerNumero, segundoNumero, calcular;

        //Metodo de calculo
        calcular = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);
    }

}