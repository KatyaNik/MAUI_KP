namespace MAUI_KP.Client;

public partial class Client : ContentPage
{

    public Client()
    {
        Title = "Modal";
        Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
        Label label = new Label { Text = "Modal Message..." };
        //  ������� � ��������� �������� �����
        backButton.Clicked += async (o, e) => await Navigation.PopModalAsync();
        Content = new StackLayout { Children = { label, backButton } };
    }
}