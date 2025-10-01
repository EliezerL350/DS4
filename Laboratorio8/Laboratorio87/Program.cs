internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrio la aplicacion");
    }
}

class ClaseBase //palabra reservada sealed borrada para permitir que herede
{
    public void test()
    {

    }

    public void moreTesting()
    {

    }
}
class ClaseHijo : ClaseBase
{

}

