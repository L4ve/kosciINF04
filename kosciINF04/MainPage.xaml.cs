namespace kosciINF04
{
    public partial class MainPage : ContentPage
    {
        int roll1, roll2, roll3, roll4, roll5;
        int totalSum = 0;
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            roll1 = random.Next(1, 7);
            roll2 = random.Next(1, 7);
            roll3 = random.Next(1, 7);
            roll4 = random.Next(1, 7);
            roll5 = random.Next(1, 7);

            int[] rolls = { roll1, roll2, roll3, roll4, roll5 };

            int wynik = rolls
                .GroupBy(x => x)
                .Where(g => g.Count() >= 2)
                .SelectMany(g => g)
                .Sum();

            totalSum += wynik;

            Dice1.Source = $"k{roll1}.jpg";
            Dice2.Source = $"k{roll2}.jpg";
            Dice3.Source = $"k{roll3}.jpg";
            Dice4.Source = $"k{roll4}.jpg";
            Dice5.Source = $"k{roll5}.jpg";

            Label6.Text = "Wynik: " + totalSum;
            Label7.Text = "Wynik tego rzutu: " + wynik;
        }

        private void ResetClicked(object? sender, EventArgs e)
        {
            roll1 = roll2 = roll3 = roll4 = roll5 = 0;
            totalSum = 0;

            Dice1.Source = "question.jpg";
            Dice2.Source = "question.jpg";
            Dice3.Source = "question.jpg";
            Dice4.Source = "question.jpg";
            Dice5.Source = "question.jpg";

            Label6.Text = "Wynik: 0";
            Label7.Text = "Wynik tego rzutu: 0";
        }
    }
}
