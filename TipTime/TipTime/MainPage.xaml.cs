namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        double valor = 0;
        double gorjeta = 0;
        double total = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button15_Clicked(object? sender, EventArgs e)
        {
            if(TextValor.Text != "")
            {
                valor = 0.15 * Slider.Maximum;
                Slider.Value = valor;
            }
        }

        private void Button30_Clicked(object? sender, EventArgs e)
        {
            if (TextValor.Text != "")
            {
                valor = 0.3 * Slider.Maximum;
                Slider.Value = valor;
            }    
        }

        private void Slider_ValueChanged(object? sender, ValueChangedEventArgs e)
        {
            if (TextValor.Text != "")
            {
                valor = Slider.Value;
                gorjeta = double.Parse(TextValor.Text) / Slider.Maximum * valor;
                TextGorjeta.Text = gorjeta.ToString();
                total = double.Parse(TextValor.Text) + double.Parse(TextGorjeta.Text);
                TextTotal.Text = total.ToString();
            }
        }

        private void Clicked_Cima(object? sender, EventArgs e)
        {
            gorjeta = Math.Ceiling(gorjeta);
            TextGorjeta.Text = gorjeta.ToString();
            total = double.Parse(TextValor.Text) + double.Parse(TextGorjeta.Text);
            TextTotal.Text = total.ToString();
        }

        private void Clicked_Baixo(object? sender, EventArgs e)
        {
            gorjeta = Math.Floor(gorjeta);
            TextGorjeta.Text = gorjeta.ToString();
            total = double.Parse(TextValor.Text) + double.Parse(TextGorjeta.Text);
            TextTotal.Text = total.ToString();
        }
    }

}
