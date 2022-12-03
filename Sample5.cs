namespace Teste;

public class Sample5
{
    /// <summary>
    /// Métodos assíncronos retornando Task e Task<string>
    /// </summary>
    public static void Execute()
    {
        var taskA = MetodoA();
        var taskB = MetodoB();

        Task.WaitAll(taskA, taskB);
        Console.WriteLine(taskA.Result);
    }

    private static async Task<string> MetodoA()
    {
        await Task.Delay(1000);
        return "MetodoA";
    }

    private static async Task MetodoB()
    {
        await Task.Delay(1000);
        Console.WriteLine("MetodoB");
    }
}