using System;

class Program
{
    static void Main()
    {
        string[] nombres = {
            "Manzana", "Banana", "Naranja", "Pera", "Uva",
            "Sandía", "Melón", "Fresa", "Piña", "Mango"
        };


        decimal[] precios = {
            25.99m, 15.50m, 150.00m, 750.00m, 10.00m,
            89.99m, 120.50m, 199.99m, 35.00m, 45.75m
        };

        Console.WriteLine("Productos disponibles:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]} - {precios[i]:C}");
        }

        Console.Write("\nIngrese el nunmero del producto (1-10): ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion < 1 || opcion > 10)
        {
            Console.WriteLine("Producto no válido.");
            return;
        }

        string nombreProducto = nombres[opcion - 1];
        decimal precio = precios[opcion - 1];

        Console.WriteLine($"El precio de : {nombreProducto} - es de: {precio:C}");

        Console.WriteLine("Forma de pago:");
        Console.WriteLine("marque 1 para efectivo --- marque 2 para tarjeta");

        string formaPago = Console.ReadLine();

        if (formaPago == "2")
        {
            Console.Write("Ingrese nnmero de cuenta: ");
            string cuenta = Console.ReadLine();

            if (cuenta.Length == 16 && long.TryParse(cuenta, out _))
            {
                Console.WriteLine("Pago con tarjeta exitoso.");
            }
            else
            {
                Console.WriteLine("Número de cuenta inválido. (Debe tener 16 digitos)");
                return;
            }
        }
        else if (formaPago == "1")
        {
            Console.WriteLine("Pago en efectivo exitoso.");
        }
        else
        {
            Console.WriteLine("Forma de pago no válida.");
        }

        Console.WriteLine("\nGracias por su compra!");
    }
}
