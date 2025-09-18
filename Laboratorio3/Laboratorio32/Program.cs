using System;

namespace Laboratorio32
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

            float radio;

            Console.Write("Introduce el radio del circulo para calcular su area ");
            radio = Convert.ToInt32(Console.ReadLine());

            float calcularArea = calculosMatematicos.calcularArea(radio);
            Console.WriteLine("Resultado {0}", calcularArea);
        }
    }
    public class CalculosMatematicos
    {
        //Metodo de calculo del area
        public int calcular(int primerNumero, int segundoNumero)
        {
            int calcular = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);
            return calcular;
        }

        public float calcularArea (float radio)
        {
            float area = (radio * radio) * 3.141516f;
            return area;    
        }
    }

}

