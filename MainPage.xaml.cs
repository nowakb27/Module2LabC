namespace Module2LabC;

public partial class MainPage : ContentPage
{
    string LetterOne = "";
    string LetterTwo = "";

    public MainPage()
    {
        InitializeComponent();
    }

    private void AddLetterOne(object sender, EventArgs e)
    {
        string nextLetter = ((Button)sender).Text;
        if (nextLetter == "Space")
        {
            MessageOne.Text += Morse.MorseCoder(LetterOne);
            LetterOne = "";
        }
        else
        {
            LetterOne += nextLetter;
        }
    }
    private void AddLetterTwo(object sender, EventArgs e)
    {
        string nextLetter = ((Button)sender).Text;
        if (nextLetter == "Space")
        {
            MessageOne.Text += Morse.MorseCoder(LetterTwo);
            LetterTwo = "";
        }
        else
        {
            LetterTwo += nextLetter;
        }
    }
}