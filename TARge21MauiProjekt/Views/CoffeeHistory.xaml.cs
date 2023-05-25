namespace Views;

public partial class CoffeeHistory : ContentPage
{
	public CoffeeHistory()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new CoffeesPage());
}