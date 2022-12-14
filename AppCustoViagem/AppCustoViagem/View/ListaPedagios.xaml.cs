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
    public partial class ListaPedagios : ContentPage
    {
        public ListaPedagios()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroViagem());
        }

        protected override void OnAppearing()
        {
            try
            {
                lst_pedagios.ItemsSource = App.ListaPedagios;

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }



        private async void MenuItem_ClickedAsync(object sender, EventArgs e)
        {


            MenuItem disparador = (MenuItem)sender;


            /**
             * Obtendo qual foi o produto que estava anexado no BindingContext
             */
            //Pedagio produto_selecionado = (Pedagio)disparador.BindingContext;

            /**
             * Perguntando ao usuário se ele realmente deseja remover. Note o await para aguardar
             * a resposta do usuário antes de prosseguir com o código.
             */
            Pedagio pedagio_selecionado = (Pedagio)disparador.BindingContext;

            bool confirmacao = await DisplayAlert("Tem certeza?",
                                                  "Excluir pedágio " + pedagio_selecionado.Localizacao + "?",
                                                  "Sim", "Não");
            if (confirmacao)
            {
                App.ListaPedagios.Remove(pedagio_selecionado);

                lst_pedagios.ItemsSource = new List<Pedagio>();
                lst_pedagios.ItemsSource = App.ListaPedagios;
            }
        }
    }
}