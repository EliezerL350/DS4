using System;
class Persona
{
    public string nombre;
    public int edad;
    public string nif;

    void cumpleaños()
    {
        edad++;
    }

    public Persona (string nombre, int edad, string nif)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.nif = nif;
    }
}

class Trabajador : Persona
{
    public int sueldo;

    public Trabajador(string nombre, int edad, string nif, int sueldo)
        : base(nombre, edad, nif)
    {
        this.sueldo = sueldo;
    }

}

class Program
{
    public static void Main()
    {
        Trabajador p = new Trabajador("Josam", 22, "77588260-Z", 100000);
        Console.WriteLine("Nombre = " + p.nombre);
        Console.WriteLine("Edad = " + p.edad);
        Console.WriteLine("NIF = " + p.nif);
        Console.WriteLine("Sueldo = " + p.sueldo);
        Console.ReadKey();
    }
}