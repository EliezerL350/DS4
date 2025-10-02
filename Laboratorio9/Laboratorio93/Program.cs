/*Ingresar 3 datos y decir que clase de triangulo es. Para formar un triángulo hay que tener
en cuenta que la suma de sus dos lados inferiores tiene que ser mayor al lado superior*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el lado A: ");
        Console.WriteLine("Ingrese el lado B: ");
        Console.WriteLine("Ingrese el lado C: ");

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("El triangulo es isosceles");
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno");
            }
        }
        else
        {
            Console.WriteLine("No es un triangulo");
        }
    }
}