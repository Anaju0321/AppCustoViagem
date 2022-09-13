using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AppCustoViagem.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCustoViagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DadosViagem : ContentPage
    {
        public DadosViagem()
        {
            InitializeComponent();

            //NavigationPage.SetHasNavigationBar(this, false);

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaPedagios());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            double distancia = Convert.ToDouble(txt_distancia.Text);
            double preco_combustivel = Convert.ToDouble(txt_preco_combustivel.Text);
            double km_litro = Convert.ToDouble(txt_km_litro.Text);

            double custo_combustivel = (distancia / km_litro) * preco_combustivel;

            //string valido = txt_valido.Text;

            // Calculando valor do pedágio com LINQ
          //  if (valido = 's')
          //  {
                double custo_pedagio = App.ListaPedagios.Where(i => i.Valido == "s").Sum(i => i.Valor);




                // Custo total da viagem
                double custo_viagem = custo_combustivel + custo_pedagio;

                // Mostrando o resultado
                spn_custo_combustivel.Text = custo_combustivel.ToString("C");
                spn_custo_pedagios.Text = custo_pedagio.ToString("C");
                lbl_custo_viagem.Text = custo_viagem.ToString("C");
            //}
        }
    }
}