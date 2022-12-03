namespace Teste;

public class Sample4
{
    /// <summary>
    /// Metodos assincronos retornando Task
    /// </summary>
    public static void Execute()
    {
        var taskA = MetodoA();
        var taskB = MetodoB();

        Task.WaitAll(taskA, taskB);        
    }

    private static async Task MetodoA()
    {
        await Task.Delay(1000);
        Console.WriteLine("MetodoA");
    }

    private static async Task MetodoB()
    {
        await Task.Delay(1000);
        Console.WriteLine("MetodoB");
    }
}