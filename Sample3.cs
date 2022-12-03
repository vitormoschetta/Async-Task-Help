namespace Teste;

public class Sample3
{
    /// <summary>
    /// Retorna Task
    /// </summary>
    public static void Execute()
    {
        var taskA = Task.Run(() => MetodoA());
        var taskB = Task.Run(() => MetodoB());

        Task.WaitAll(taskA, taskB);
    }

    private static Task MetodoA()
    {
        Task.Delay(1000).Wait();
        Console.WriteLine("MetodoA");
        return Task.CompletedTask;
    }

    private static Task MetodoB()
    {
        Task.Delay(1000).Wait();
        Console.WriteLine("MetodoB");
        return Task.CompletedTask;
    }
}