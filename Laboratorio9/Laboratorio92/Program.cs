/*Recorrer los números del 1 al 100. Mostrar los números pares o divisibles entre 3.*/
using System;

class Program 
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
        {
            if (i % 2 == 0 || i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

}