using Xamarin.Forms;

namespace Briscola
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        async void StartButtonClicked(object sender, System.EventArgs e) => await Navigation.PushAsync(new GamePage());
    }
}
