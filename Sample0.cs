namespace Teste;

public class Sample0
{
    public static void Execute()
    {
        MetodoA();
        MetodoB();
    }

    private static void MetodoA()
    {
        Thread.Sleep(1000);
        Console.WriteLine("MetodoA");
    }

    private static void MetodoB()
    {
        Thread.Sleep(1000);
        Console.WriteLine("MetodoB");        
    }
}
