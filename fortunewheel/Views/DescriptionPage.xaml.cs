namespace Views;


public partial class DescriptionPage : ContentPage
{
    public DescriptionPage(string description)
    {
        InitializeComponent();
        DescriptionLabel.Text = description;
    }

    private async void OnBackToWheelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
