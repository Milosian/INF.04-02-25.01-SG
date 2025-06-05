namespace SmartHomeMaui
{
    public partial class MainPage : ContentPage
    {
        bool cleanerState = false;
        int progNUm = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Clicked(object sender, EventArgs e)
        {
            progNUm = Convert.ToInt32(ProgNumberEntry.Text);
            if (progNUm > 0 && progNUm < 12)
            {
                ProgNumberLbl.Text = $"Numer prania: {progNUm}";
            }
        }

        private void OnBtn_Clicked(object sender, EventArgs e)
        {
            if (!cleanerState)
            {
                cleanerState = true;
                OnBtn.Text = "Wyłącz";
                CleanerStateLbl.Text = "Odkurzacz włączony";
            }
            else
            {
                cleanerState = false;
                OnBtn.Text = "Włącz";
                CleanerStateLbl.Text = "Odkurzacz wyłączony";
            }
        }
    }

}
