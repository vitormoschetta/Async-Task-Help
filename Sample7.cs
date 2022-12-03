namespace Teste;

public class Sample7
{
    /// <summary>
    /// Métodos assíncronos retornando void
    /// Não é recomendado utilizar métodos assíncronos que retornam void. A não ser que você esteja utilizando o método em um evento.
    /// Em métodos async void não é possível utilizar await para a guardar o resultado da execução do método.
    /// A thread principal não aguarda a execução do método async void, e por esse motivo, não é possivel validar se a execução do método foi bem sucedida ou não.
    /// </summary>
    public static async Task Execute()
    {
        MetodoA();
        MetodoB();

        await Task.CompletedTask;
    }

    private static async void MetodoA()
    {
        await Task.Delay(1000);
        Console.WriteLine("MetodoA");
    }

    private static async void MetodoB()
    {
        await Task.Delay(2000);
        Console.WriteLine("MetodoB");
    }
}