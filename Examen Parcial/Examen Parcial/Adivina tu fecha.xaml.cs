using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_Parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adivina_tu_fecha : ContentPage
    {
        public Adivina_tu_fecha()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(resultado.Text);
            int cifra1, cifra2, cifra3, cifra4;
            result = result - 365;
            cifra1 = (result % 10000) / 1000;
            cifra2 = (result % 10000) % 1000 / 100;
            cifra3 = ((result % 10000) % 1000) % 100 / 10;
            cifra4 = (((result % 10000) % 1000) % 100) % 10;
            string respuesta = ("Muy bien el dia de tu cumpleaños es: " + cifra1 + cifra2 + "y el  mes de tu cumpleaños es:" + cifra3 + cifra4);
            DisplayAlert("respuesta", respuesta, "Exelente");

        }
    }
}