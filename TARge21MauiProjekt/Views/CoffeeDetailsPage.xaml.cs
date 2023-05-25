namespace Views;

public partial class CoffeeDetailsPage : ContentPage
{
	public CoffeeDetailsPage(Coffee coffee)
	{
		InitializeComponent();
		this.BindingContext = coffee;
	}
	async void BackButton_Clicked(System.Object senver, System.EventArgs e)
	{
		await Navigation.PopAsync();
	}
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}