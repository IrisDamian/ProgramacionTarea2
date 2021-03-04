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
    public partial class Adivina_tu_numero : ContentPage
    {
        public Adivina_tu_numero()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numero.Text);
            num = num / 10;
            num = num - 4;
            string resul = Convert.ToString(num);
            DisplayAlert("El numero que imaginaste fue",resul,"Exelente");
        }
    }
}