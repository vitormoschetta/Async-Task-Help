namespace Teste;

public class Sample2
{
    /// <summary>
    /// Idem Sample1, porém com MetodoA retornando string
    /// </summary>
    public static void Execute()
    {
        var taskA = Task.Run(() => MetodoA());
        var taskB = Task.Run(() => MetodoB());

        Task.WaitAll(taskA, taskB);
        Console.WriteLine(taskA.Result);
    }

    private static string MetodoA()
    {
        Thread.Sleep(1000);
        return "MetodoA";
    }

    private static void MetodoB()
    {        
        Thread.Sleep(1000);
        Console.WriteLine("MetodoB");
    }
}