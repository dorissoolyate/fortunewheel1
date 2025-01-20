namespace Views;



public partial class WelcomePage : ContentPage
{
    public WelcomePage()

    {
        InitializeComponent();
        StartImageRotation();
    }

    private async void OnStartClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WheelPage());
    }


    private async void StartImageRotation()
    {
        while (true) 
        {
            
            for (int i = 0; i < 360; i++)
            {
                RotatingImage.Rotation = i; 
                await Task.Delay(10);
            }
        }
    }
}
