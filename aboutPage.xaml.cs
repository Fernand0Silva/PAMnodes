namespace Nodes;

public partial class aboutPage : ContentPage
{
	public aboutPage()
	{
		
		InitializeComponent();

		
	}

	private async void LearnMore_Click(object sender, EventArgs e )
	{
		await Launcher.Default.OpenAsync("https://www.todamateria.com.br/");

	}



}