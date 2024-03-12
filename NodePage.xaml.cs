namespace NodesPage;

public partial class NodePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    //Método Construtor
	public NodePage()
	{
		InitializeComponent();

        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);
    }
    private  void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        File.WriteAllText(_fileName, TextEditor.Text);
        
    }
    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if(!File.Exists(_fileName,TextEditor))
        {
            await DisplayAlert(
                nameof(NodePage),
                "Aquivo criado com sucesso");
        }
        // Delete the file.
        if (File.Exists(_fileName))
            File.Delete(_fileName);
        TextEditor.Text = string.Empty;
    }
}