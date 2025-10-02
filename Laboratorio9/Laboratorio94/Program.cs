/*Crear una clase llamada: Aleatorios
a. Como atributo tendrá un Random.
b. Tendrá los siguientes métodos, cuyos objetivos son:
i. Generar un numero entre 2 números
ii. Generar un arreglo de números entre dos números aleatorios*/
using Laboratorio94;
using System;
class Program
{
    static void Main()
    {
        Aleatorios aleatorio = new Aleatorios();

        int numero = aleatorio.GenerarNumero(10, 20);
        Console.WriteLine("Número aleatorio: " + numero);

        int[] numeros = aleatorio.GenerarArreglo(5, 1, 100);
        Console.WriteLine("Arreglo aleatorio:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
    }
}

