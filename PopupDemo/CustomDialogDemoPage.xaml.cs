
namespace PopupDemo;

public partial class CustomDialogDemoPage : ContentPage
{
	public CustomDialogDemoPage()
	{
		InitializeComponent();
	}

    private async void BtnOpenCustomDialogClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MyCustomDialogPage());
    }
}