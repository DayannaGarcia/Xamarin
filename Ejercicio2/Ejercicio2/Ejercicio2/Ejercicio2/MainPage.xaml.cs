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
        void btnSimular_Clicked(object sender, System.EventArgs e)
        {
            var progreso = progressNum.Progress;

            if (progreso == 1)
            {
                progressNum.ProgressTo(.1, 250, Easing.SpringOut);
            }
            else
            {
                progressNum.ProgressTo(1,300,Easing.Linear);
            }
        }
    }
}
