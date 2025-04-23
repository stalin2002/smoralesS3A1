namespace smoralesS3A1.Views;

public partial class vista1 : ContentPage
{
	public vista1()
	{
		InitializeComponent();
	}

    String usuarioFinal = "";
    String clvaeFinal = "";
    public vista1(string usuario,string clave)
    {
        InitializeComponent();
        this.usuarioFinal = usuario;
        this.clvaeFinal = clave;
    }

    

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        if(txtUsuario.Text == usuarioFinal && txtClave.Text ==  clvaeFinal)
        {
            Navigation.PushAsync(new Views.vista2(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o clave incorrecta", "Ok");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vista3());
    }
}