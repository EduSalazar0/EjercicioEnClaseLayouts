﻿namespace EjercicioEnClaseLayouts
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void Boton1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaGrid());
        }
        private void Boton2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaAbsolute ());
        }
        private void Boton3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaFlex());
        }
        private void Boton4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaStack());
        }
    }
    

}
