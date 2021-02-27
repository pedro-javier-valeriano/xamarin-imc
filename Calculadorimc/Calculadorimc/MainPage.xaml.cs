using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadorimc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(altura.Text)&& !string.IsNullOrEmpty(peso.Text))
            {
                var Altura = double.Parse(altura.Text);
                var Peso = double.Parse(peso.Text);
                var Imc = Peso / (Altura * Altura);
                imc.Text = Imc.ToString();
                string resultado = "";
                if (Imc < 18.5)
                {
                    resultado = "tienes bajo peso";
                }
                else
                {
                    if (Imc >= 18.5 && Imc <= 24.9)
                    {
                        resultado = "tu peso es normal";
                    }
                    else
                    {
                        resultado = "tienes sobrepeso cuidate";
                    }
                }

                DisplayAlert("RESULTADO", resultado, "OK");
            }

            else
            {
                DisplayAlert("Datos erroneos", "porfavor llene la informacion", "ok");
            }

        }
    }
}
