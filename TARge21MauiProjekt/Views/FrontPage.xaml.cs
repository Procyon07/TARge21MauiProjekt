namespace Views;

public partial class FrontPage : ContentPage
{
	public FrontPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (this.AnimationIsRunning("TransistionAnimation"))
        {
            return;
        }
        var parentAnimation = new Animation();

        //parentAnimation.Add(0, 0.2, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        
        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);

        //Intro Box
        parentAnimation.Add(0.7, 1, new Animation(v => frmIntro.Opacity = v, 0, 1, Easing.CubicIn));

    }
    async void Welcome_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new CoffeesPage());
}