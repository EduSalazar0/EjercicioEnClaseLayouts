namespace EjercicioEnClaseLayouts;

public partial class PaginaGrid : ContentPage
{
	public PaginaGrid()
	{
		InitializeComponent();
	}
	private void Boton1_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PaginaStack());

		//Navigation.PopAsync(); // Cierra la pantalla

		//Navigation.PopToRootAsync(); // Te lleva a la pantalla principal
	}


}