using System.Diagnostics.CodeAnalysis;

namespace DiceRoller;

public partial class MainPage : ContentPage
{
    int numSides = 6;

    public MainPage()
    {
        InitializeComponent();
        LadosPicker.SelectedIndex = 0;
    }

    public class Dice
    {
        public Dice() { }
        public Dice(int numSides)
        {
            this.numSides = numSides;
        }

        private int numSides;

        public int RolarDado()
        {
            int random = new Random().Next(1, numSides + 1);
            return random;
        }
    }


    private void OnRolarDadoClicked(object sender, EventArgs e)
    {
        numSides = Convert.ToInt32(LadosPicker.SelectedItem.ToString());
        Dice dice = new Dice(numSides);
        ResultadoLabel.Text = dice.RolarDado().ToString();
    }

    public void OnChangedOption(object sender, EventArgs e)
    {
        int diceSize = Int32.Parse(LadosPicker.SelectedItem.ToString());
        Image image = new Image { Source = $"d{diceSize}.png" };
        dadoImagem.Source = image.Source;


    }

}

