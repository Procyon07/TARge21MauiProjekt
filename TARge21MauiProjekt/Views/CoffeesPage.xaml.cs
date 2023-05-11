namespace Views;

public partial class CoffeesPage : ContentPage
{
    private const uint AnimationDuration = 800u;
    public CoffeesPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularCoffees.ItemsSource = CoffeeServices.GetFeaturedCoffees();
        lstAllCoffees.ItemsSource = CoffeeServices.GetAllCoffees();
    }
    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {
        await CloseMenu();
    }
    //async void Coffees_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    //{
    //    await Navigation.PushAsync(new CoffeeDetailsPage(e.CurrentSelection.First() as Coffee));
    //}

    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
        // Reveal our menu and move the main content out of the view
        _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
        _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
    }
    private async Task CloseMenu()
    {
        _ = MainContentGrid.FadeTo(1, AnimationDuration);
        _ = MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }
}