namespace Teste;

public class Sample1
{
    /// <summary>
    /// Quando todos os métodos retornam void. 
    /// Para executar de forma assíncrona, cria-se uma Task para cada método.
    /// Por fim, espera-se que todas as Tasks terminem, com o método Task.WaitAll().
    /// </summary>
    public static void Execute()
    {
        var taskA = Task.Run(() => MetodoA());
        var taskB = Task.Run(() => MetodoB());        

        Task.WaitAll(taskA, taskB);
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