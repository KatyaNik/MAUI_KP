namespace MAUI_KP.Client;

public partial class Employee : ContentPage
{

    public Employee()
    {
        Title = "Common";
        Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
        Label label = new Label { Text = "Lorem Ipsum is simply dummy text of the printing..." };
        //  переход с обычной страницы назад
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();
        Content = new StackLayout { Children = { label, backButton } };
    }
}