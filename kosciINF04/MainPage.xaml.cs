

namespace kosciINF04
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int roll1 = 0;
        int roll2 = 0;
        int roll3 = 0;
        int roll4 = 0;
        int roll5 = 0;
        int wynik = 0;
        int totalSum = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            var random = new Random();

            roll1 = random.Next(1, 7);
            roll2 = random.Next(1, 7);
            roll3 = random.Next(1, 7);
            roll4 = random.Next(1, 7);
            roll5 = random.Next(1, 7);

            int wynik = roll1 + roll2 + roll3 + roll4 + roll5;

            totalSum += wynik;

            Label1.Text = roll1.ToString();
            Label2.Text = roll2.ToString();
            Label3.Text = roll3.ToString();
            Label4.Text = roll4.ToString();
            Label5.Text = roll5.ToString();
            Label6.Text = "Wynik: " + totalSum;
        }

        private void ResetClicked(object? sender, EventArgs e)
        {
            roll1 = 0;
            roll2 = 0;
            roll3 = 0;
            roll4 = 0;
            roll5 = 0;
            wynik = 0;
            totalSum = 0;

            Label1.Text = "0";
            Label2.Text = "0";
            Label3.Text = "0";
            Label4.Text = "0";
            Label5.Text = "0";
            Label6.Text = "Wynik: 0";
        }
    }
}
