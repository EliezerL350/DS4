static void Main (string[] args)
{
    int n, x = 0;
    string linea;

    Console.WriteLine("Ingrese el valor de n:");
    linea = Console.ReadLine();
    
    n = 5;
    while (x <= n)
    {
        Console.WriteLine(x);
        Console.WriteLine(" , ");
        x++;
    }
    Console.ReadKey();
}