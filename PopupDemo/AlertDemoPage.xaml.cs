using System.Diagnostics;

namespace PopupDemo;

public partial class AlertDemoPage : ContentPage
{
	public AlertDemoPage()
	{
		InitializeComponent();
	}

    private async void btnShowAlertClickedAsync(object sender, EventArgs e)
    {
        await DisplayAlert("Alert", "You have been alerted", "OK");
    }

    private async void btnShowConfirmDialogClickedAsync(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Please confirm?", "Are you sure you want to delete?", "Yes", "No");
        Debug.WriteLine("Answer: " + answer);
    }
}