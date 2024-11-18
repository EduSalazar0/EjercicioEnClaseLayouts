namespace EjercicioEnClaseLayouts;

public partial class PaginaFlex : ContentPage
{
	public PaginaFlex()
	{
		InitializeComponent();
	}
	private void Boton1_Clicked(object sender, EventArgs e)
	{
		Navigation.PopToRootAsync();
	}
    private void Boton2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaStack());
    }
    private void Boton3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaGrid());
    }
    private void Boton4_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaFlex());
    }

}