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
            if (await ValidarFormulario())
            {
                await DisplayAlert("Exito","Todos los campos cumplieron las validaciones","Ok");
            }
        }

        private async Task<bool> ValidarFormulario()
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
                    await this.DisplayAlert("Advertencia", "No se aceptan caracteres especiales, intente de nuevo", "OK");
                    return false;
                }
            }

            if (String.IsNullOrWhiteSpace(UserLastName.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del apellido es obligatorio", "Ok");
                return false;
            }
            //Valida que solo se ingresen letras
            else if (!UserLastName.Text.ToCharArray().All(Char.IsLetter))
            {
                await this.DisplayAlert("Advertencia", "Tu informacion contiene numeros, favor de validar", "Ok");
                return false;
            }
            else
            {
                //Valida si se ingresan caracteres especiales
                string caractEspecial = @"^[^ ] [a-zA-Z]+[^]$";
                bool resultado = Regex.IsMatch(UserLastName.Text, caractEspecial, RegexOptions.IgnoreCase);
                if (!resultado)
                {
                    await this.DisplayAlert("Advertencia", "No se aceptan caracteres especiales, intente de nuevo", "OK");
                    return false;
                }
            }

            bool isEmail = Regex.IsMatch(UserEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[az0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-
9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                await this.DisplayAlert("Advertencia", "El formato del correo electrónico es incorrecto, revíselo e intente de nuevo.", "OK");
 return false;
            }

            if (String.IsNullOrWhiteSpace(UserCelular.Text))
            {
                await this.DisplayAlert("Advertencia","El campo del numero de celular es obligatorio","Ok");
                return false;
            }
            //Valida si lacantidad de digitos ingresados es menor a 10
            else if (UserCelular.Text.Length != 10)
            {
                await this.DisplayAlert("Advertencia","Faltan digitos, favor ingresar su numero a 10 digitos","Ok");
                return false;
            }
            else
            {
                //Valida que solo se ingresan numeros
                if (!UserCelular.Text.ToCharArray().All(Char.IsDigit))
                {
                    await this.DisplayAlert("Advertencia", "El formato del celular es incorrecto, solo se aceptan numeros", "Ok");
                    return false;
                }
            }


            return true;
        }
            
        }

       
        
	}

