using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PM2EJERCICIO11.Views;

namespace PM2EJERCICIO11
{

    public partial class MainPage : ContentPage
    {

        double resultado;
        double n1;
        double n2;
        public MainPage()
        {
            InitializeComponent();
             
        }
        
        public void datos()
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
        }


        private async void btnSuma_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN1.Text) || string.IsNullOrWhiteSpace(txtN2.Text))
            {
                await DisplayAlert("Error", "Debe ingresar los 2 numeros", "OK");
                return;
            }
            datos();
            resultado = n1 + n2;
            await Navigation.PushAsync(new PageResultado(resultado));

        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN1.Text) || string.IsNullOrWhiteSpace(txtN2.Text))
            {
                await DisplayAlert("Error", "Debe ingresar los 2 numeros", "OK");
                return;
            }
            datos();
            resultado = n1- n2;
            await Navigation.PushAsync(new PageResultado(resultado));

        }

        private async void btnMulti_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN1.Text) || string.IsNullOrWhiteSpace(txtN2.Text))
            {
                await DisplayAlert("Error", "Debe ingresar los 2 numeros", "OK");
                return;
            }
            datos();
            resultado = n1 * n2;
            await Navigation.PushAsync(new PageResultado(resultado));
        }

        private async void btnDiv_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN1.Text) || string.IsNullOrWhiteSpace(txtN2.Text))
            {
                await DisplayAlert("Error", "Debe ingresar los 2 numeros", "OK");
                return;
            }
            if (Convert.ToDouble(txtN2.Text) == 0)
            {
                await DisplayAlert("Error", "No se puede dividir entre 0" +
                    "", "OK");
                return;
            }
            datos();
            resultado = n1 / n2;
            await Navigation.PushAsync(new PageResultado(resultado));
        }

  

}



}
