using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Continue_Tapped(object sender, EventArgs e)
        {
            if (await validarFormulario())
            {
                await DisplayAlert("Exito","Todos los campos cumplieron las validaciones","Ok");
            }
        }

        private async Task<bool> validarFormulario()
        {
            //Valida si el valor en el Entry se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(UserName.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del nombre es obligatorio", "Ok");
                return false;
            }
            //Valida que solo se ingresen letras
            else if (!UserName.Text.ToCharArray().All(Char.IsLetter))
            {
                await this.DisplayAlert("Advertencia", "Tu informacion contiene numeros, favor de validar", "Ok");
                return false;
            }
            else
            {
                //Valida si se ingresan caracteres especiales
                string caractEspecial = @"^[^ ] [a-zA-Z]+[^]$";
                bool resultado = Regex.IsMatch(UserName.Text, caractEspecial, RegexOptions.IgnoreCase);
                if (!resultado)
                {
                    await this.DisplayAlert("Advertencia","No se aceptan caracteres especiales, intente de nuevo","OK");
                    return false;
                }
            }
            return true;
        }
        
	}
}
