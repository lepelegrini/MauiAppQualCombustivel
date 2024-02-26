namespace MauiAppQualCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double gasolina = Convert.ToDouble(txt_gasolina.Text);
            double etanol = Convert.ToDouble(txt_etanol.Text);

            string msg = $"Compensa mais ";

            if (etanol > (gasolina * 0.7))
            {
                msg += "a gasolina";
            }else
            {
                msg += "o etanol";
            }

            DisplayAlert("Resultado", msg, "Fechar");
        }
    }
}