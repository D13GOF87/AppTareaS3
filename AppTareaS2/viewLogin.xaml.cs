using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTareaS2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class viewLogin : ContentPage
	{
		public viewLogin()
		{
			InitializeComponent();
		}


		private async void btnIngresar_Clicked(object sender, EventArgs e)
		{
			try {
				String user = "";
				int u = 0, c = 0;

				if (txtUsuario.Text.Equals("estudiante2021"))
				{
					u = 1;
					user = txtUsuario.Text;
				}
				else
					await DisplayAlert("Error datos de usuario", "Usuario incorrecto", "Ok");

				if (txtContrasena.Text.Equals("uisrael2021"))
					c = 1;
				else
					await DisplayAlert("Error datos de usuario", "Contraseña incorrecta", "Ok");

				if (u == 1 && c == 1)
					await Navigation.PushAsync(new MainPage(user));
			}
			catch (Exception ex)
			{
				await DisplayAlert("Mensaje de alerta", ex.Message, "ok");
			}
			
		}
	}
}