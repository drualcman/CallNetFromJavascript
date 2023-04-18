function showFavoritePizzaName() {
    DotNet.invokeMethodAsync("CallNetFromJavascript", "GetPizzaNameAsync", 3)
        .then(pizzaName => {
            alert(`Your favorite pizza is ${pizzaName}`);
        });
}

function showFavoritePizzaPrice(dotNetHelper) {
    dotNetHelper.invokeMethodAsync("GetPizzaPriceAsync", 3)
        .then(pizzaPrice => {
            alert(`Your favorite pizza price is ${pizzaPrice}`);
        });
}