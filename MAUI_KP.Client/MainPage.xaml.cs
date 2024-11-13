using System.Security.AccessControl;

namespace MAUI_KP.Client
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            //InitializeComponent();
            Title = "Main";
            Button toCommonPageBtn = new Button
            {
                Text = "Common",
                HorizontalOptions = LayoutOptions.Start
            };
            toCommonPageBtn.Clicked += ToCommonPage;

            Button toModalPageBtn = new Button
            {
                Text = "Modal",
                HorizontalOptions = LayoutOptions.Start
            };
            toModalPageBtn.Clicked += ToModalPage;

            Content = new StackLayout { Children = { toCommonPageBtn, toModalPageBtn } };
        }
        private async void ToModalPage(object? sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Client());
        }
        private async void ToCommonPage(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Employee());
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
            Navigation.PushAsync(new Employee());
        }
    }

}
