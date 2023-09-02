namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnRolarDadoClicked(object sender, EventArgs e)
    {
        if (LadosPicker.SelectedIndex >= 0)
        {
            int numeroDeLados = (int)LadosPicker.ItemsSource[LadosPicker.SelectedIndex];
            int resultado = RolarDado(numeroDeLados);
            ResultadoLabel.Text = $"{resultado}";
        }
        else
        {
            ResultadoLabel.Text = "Escolha o número de lados do dado!";
        }
    }

    private int RolarDado(int lados)
    {
        Random random = new Random();
        return random.Next(1, lados + 1);
    }
}

