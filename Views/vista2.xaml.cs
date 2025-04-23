namespace smoralesS3A1.Views;

public partial class vista2 : ContentPage
{
	public vista2(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "USUARIO CONECTADO: " + usuario;
	}

    private void btnVerFromularioRegistro(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Views.vista3());
    }

    private void btnSalir_Clicek(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vista1());
    }
    
}