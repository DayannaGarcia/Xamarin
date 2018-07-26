using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Views : ContentPage
	{
		public Views ()
		{
			InitializeComponent ();
            dtpFecha.MinimumDate = new DateTime(1970,1,1);
            dtpFecha.DateSelected += DtpFecha_DateSelected;
		}

        private void DtpFecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Fecha",e.NewDate.ToString(),"Okey");
        }

        private void btnEnviarClicked(object sender,EventArgs args)
        {
            DisplayAlert("Ingreso", "Bienvenido a la aplicacion", "Aceptar");
        }

    }
}