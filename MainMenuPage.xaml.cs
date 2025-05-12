namespace EinkaufslistenApp;

public partial class MainMenuPage : ContentPage
{
    public MainMenuPage()
    {
        InitializeComponent();
    }

    private async void OnCreateShoppingListClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateShoppingListPage());
    }

    private async void OnCreateSupermarketClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateSupermarketPage());
    }

    private async void OnShoppingClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShoppingPage());
    }
}
