
namespace PopupDemo;

public partial class DisplayPromptDemoPage : ContentPage
{
    public string Name { get; set; } = "Please click the button!";
    public DisplayPromptDemoPage()
	{
		InitializeComponent();
	}

    private async void BtnDisplayPromptClickedAsync(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Question 1", "What's your name?");
        if (!string.IsNullOrEmpty(result))
        {
            Name = result;
        }
        lblName.Text = Name;
    }

    private async void BtnDisplayPromptArgsClickedAsync(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Question 2", "What's 5 + 5?", initialValue: "10", maxLength: 2, keyboard: Keyboard.Numeric);
        lblAnswer.Text = result;
    }
}