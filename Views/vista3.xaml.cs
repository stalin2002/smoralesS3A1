namespace smoralesS3A1.Views;

public partial class vista3 : ContentPage
{
	public vista3()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		String usuario = txttUsuario.Text;
		String clave = txtClave.Text;
		DisplayAlert("Alerta", "Usuario guardado", "ok");
		Navigation.PushAsync(new Views.vista1(usuario, clave));
    }
}