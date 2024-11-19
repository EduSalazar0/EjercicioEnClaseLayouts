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

}