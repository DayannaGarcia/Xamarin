using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var elementoSeleccionado = picker.SelectedItem as string;
            DisplayAlert("Seleccionado",elementoSeleccionado,"Ok");
        }
    }
}
