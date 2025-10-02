/*Utilizar la clase anterior de Aleatorios
a. Generar un arreglo de números no repetidos entre dos números aleatorios*/

using Laboratorio95;
using System;

class Program
{
    static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        int min = aleatorios.GenerarNumero(1, 20);
        int max = aleatorios.GenerarNumero(21, 40);

        if (min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }

        Console.WriteLine($"Rango generado: {min} a {max}");
        int cantidad = 5;

        try
        {
            int[] arreglosNoRepetidos = aleatorios.GenerarArreglosNoRepetidos(cantidad, min, max);
            Console.WriteLine("Arreglo no repetidos");
            foreach (int n in arreglosNoRepetidos)
            {
                Console.Write(n + " ");
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}