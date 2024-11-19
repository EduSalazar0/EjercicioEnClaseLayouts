namespace EjercicioEnClaseLayouts;

public partial class PaginaAbsolute : ContentPage
{
	public PaginaAbsolute()
	{
		InitializeComponent();
	}
	private void Boton1_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PaginaFlex());
	}
}