using CallNetFromJavascript.Services;
using Microsoft.AspNetCore.Components;

namespace CallNetFromJavascript.Pages;

public partial class FavoritePizzaPrice : IDisposable
{
    [Inject] IJSRuntime JSRuntime { get; set; }

    DotNetObjectReference<PizzaService> PizzaService;

    async Task ShowPizzaPrize()
    {
        if(PizzaService == null)
        {
            PizzaService = DotNetObjectReference.Create(new PizzaService());
        }

        await JSRuntime.InvokeVoidAsync("showFavoritePizzaPrice", PizzaService);
    }

    public void Dispose() => PizzaService?.Dispose();
}
