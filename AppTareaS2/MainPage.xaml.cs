using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTareaS2
{
	public partial class MainPage : ContentPage
	{
		public MainPage(String user)
		{
			InitializeComponent();
		}

		private void btnEvaluar_Clicked(object sender, EventArgs e)
		{
			try
			{
				//Variables Calculos
				double parcial1 = 0;
				double parcial2 = 0;
				double notaFinal = 0;

				//Almacenar en variables notas
				double nota1 = Convert.ToDouble(txtNotaUno.Text);
				double examen1 = Convert.ToDouble(txtExamenUno.Text);

				double nota2 = Convert.ToDouble(txtNotaDos.Text);
				double examen2 = Convert.ToDouble(txtExamenDos.Text);

				//Operaciones
				if (nota1 > 10 || examen1 > 10 || nota2 > 10 || examen2 > 10)
				{
					DisplayAlert("Error en  Notas", "Las notas no deben ser mayor a 10", "ok");
				}
				else if (nota1 < 0 || examen1 < 0 || nota2 < 0 || examen2 < 0)
				{
					DisplayAlert("Error en  Notas", "Las notas no deben ser negativas", "ok");
				}
				else
				{
					parcial1 = (nota1 * 0.3) + (examen1 * 0.2);
					parcial2 = (nota2 * 0.3) + (examen2 * 0.2);
					notaFinal = parcial1 + parcial2;
				}

				//Visualizar Notas
				txtParcialUno.Text = parcial1.ToString();
				txtParcialDos.Text = parcial2.ToString();
				txtNotaFin.Text = notaFinal.ToString();

				//Estado
				if (notaFinal>=7)
				{
					txtEstado.Text = "APROBADO";
					txtEstado.TextColor = Color.Green;
				}
				else if (notaFinal >= 5 && notaFinal<7)
				{
					txtEstado.Text = "COMPLEMENTARIO";
					txtEstado.TextColor = Color.Orange;
				}
				else
				{
					txtEstado.Text = "REPROBADO";
					txtEstado.TextColor = Color.Red;
				}
			}
			catch (Exception ex)
			{
				DisplayAlert("Mensaje de alerta", ex.Message, "ok");
			}
		}
	}
}
