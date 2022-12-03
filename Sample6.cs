namespace Teste;

public class Sample6
{
    /// <summary>
    /// Métodos assíncronos retornando Task<string>
    /// </summary>
    public static async Task Execute()
    {
        // os métodos são executados em paralelo, e em segundo plano.
        var taskA = MetodoA();
        var taskB = MetodoB();

        // quando utilizamos o await, então a thread principal é bloqueada até que a taskA seja concluída. 
        // E apenas depois disso, a thread principal é liberada para executar a linha seguinte.
        Console.WriteLine(await taskA); 
        Console.WriteLine(await taskB);
    }

    private static async Task<string> MetodoA()
    {
        await Task.Delay(1000);
        return "MetodoA";
    }

    private static async Task<string> MetodoB()
    {
        await Task.Delay(2000);
        return "MetodoB";
    }
}