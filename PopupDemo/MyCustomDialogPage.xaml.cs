namespace PopupDemo;

public partial class MyCustomDialogPage : ContentPage
{
	public MyCustomDialogPage()
	{
		InitializeComponent();
	}

    private async void BtnCancelClickedAsync(object sender, EventArgs e)
    {
        //Close MyCustomDialogPage
        await Navigation.PopModalAsync();
    }
}