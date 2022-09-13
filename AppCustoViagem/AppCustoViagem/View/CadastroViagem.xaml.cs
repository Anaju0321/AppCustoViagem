using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCustoViagem.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using System.IO;
using AppCustoViagem.Helper;

namespace AppCustoViagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroViagem : ContentPage
    {
        public CadastroViagem()
        {
            InitializeComponent();

           
        }

        private async void ToolbarItem_ClickedAsync(object sender, EventArgs e)
        {
            try
            {
                Pedagio p = new Pedagio
                {
                    Localizacao = txt_localizacao.Text,
                    Valor = Convert.ToDouble(txt_valor.Text),
                    Valido = txt_valido.Text
                };

                 App.ListaPedagios.Add(p);
                await App.Database.Insert(p);


                await DisplayAlert("Deu Certo!", "Pedágio Adicionado", "OK");

                await Navigation.PopAsync();

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}