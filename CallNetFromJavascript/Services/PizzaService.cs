namespace CallNetFromJavascript.Services;

public class PizzaService
{
    [JSInvokable]
    public static Task<string> GetPizzaNameAsync(int pizzaId) =>
        pizzaId switch
        {
            1 => Task.FromResult("Margherita"),
            2 => Task.FromResult("Tocinator"),
            3 => Task.FromResult("Pepperony"),
            _ => Task.FromResult("Unknown")
        };
       
    [JSInvokable]
    public Task<double> GetPizzaPriceAsync(int pizzaId) =>
        pizzaId switch
        {
            1 => Task.FromResult(250.0),
            2 => Task.FromResult(125.0),
            3 => Task.FromResult(333.33),
            _ => throw new Exception($"Unknow pizza Id: {pizzaId}")
        };
}
