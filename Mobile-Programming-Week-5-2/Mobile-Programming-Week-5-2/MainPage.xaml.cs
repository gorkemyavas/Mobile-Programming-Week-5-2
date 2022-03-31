using Xamarin.Forms;

namespace Mobile_Programming_Week_5_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new BoxView
            {
                Color = Color.Blue,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 200,
                HeightRequest = 100,
                CornerRadius = 5
            };
        }
    }
}
