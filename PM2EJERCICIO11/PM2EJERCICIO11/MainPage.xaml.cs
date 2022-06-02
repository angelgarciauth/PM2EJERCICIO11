using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            datos();
            resultado = suma(n1, n2);

            await DisplayAlert("Aviso", resultado.ToString(), "OK");
        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            datos();
            resultado = resta(n1, n2);

            await DisplayAlert("Aviso", resultado.ToString(), "OK");
        }

        private async void btnMulti_Clicked(object sender, EventArgs e)
        {
            datos();
            resultado = multiplicacion(n1, n2);

            await DisplayAlert("Aviso", resultado.ToString(), "OK");
        }

        private async void btnDiv_Clicked(object sender, EventArgs e)
        {
            datos();
            resultado = division(n1, n2);

            await DisplayAlert("Aviso", resultado.ToString(), "OK");
        }





        /*FUNCIONES*/
        public static double suma(double n1, double n2)
        {
            double suma = 0;
            suma = n1 + n2;
            return suma;
        }

        public static double resta(double n1, double n2)
        {
            double resta = 0;
            resta = n1 - n2;
            return resta;
        }

        public static double multiplicacion(double n1, double n2)
        {
            double multi = 0;
            multi = n1 * n2;
            return multi;
        }

        public static double division(double n1, double n2)
        {
            double division = 0;
            division = n1 / n2;
            return division;
        }


    }



}
