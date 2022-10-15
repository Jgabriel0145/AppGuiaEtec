using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaEtec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("tel:01436248585"));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("tel:01436223566"));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}