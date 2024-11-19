namespace EjercicioEnClaseLayouts;

public partial class PaginaStack : ContentPage
{
	public PaginaStack()
	{
		InitializeComponent();
	}
	private void Boton1_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PaginaAbsolute());
	}
}