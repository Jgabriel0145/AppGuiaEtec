using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppGuiaEtec.Models;

namespace AppGuiaEtec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void btnBanco2_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Sistemas Embarcados  ",
                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados.  ",
                    ValoresAtitudes = "• Fortalecer a persistência e o interesse na resolução de situações-problema. \n• Estimular a organização. \n• Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnDS_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto. \n• Codificar e depurar programas. ",
                    ValoresAtitudes = "• Fortalecer a persistência e o interesse na resolução de situações-problema. \n• Incentivar ações que promovam a cooperação. \n• Desenvolver a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnEtica_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Ética e Cidadania Organizacional  ",
                    AtribuicoesResponsabilidades = "Atuar de acordo com princípios éticos nas relações de trabalho.  ",
                    ValoresAtitudes = "• Estimular atitudes respeitosas. \n• Incentivar comportamentos éticos. \n• Comprometer-se com a igualdade de direitos.  "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnMobile1_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I ",
                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis. ",
                    ValoresAtitudes = "• Incentivar a criatividade. \n• Responsabilizar-se pela produção, utilização e divulgação de informações. \n• Estimular a organização.  "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnWeb2_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Programação Web II",
                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação para web ",
                    ValoresAtitudes = "• Responsabilizar-se pela produção, utilização e divulgação de informações. \n• Fortalecer a persistência e o interesse na resolução de situações-problema. \n• Incentivar a criatividade.  "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnEmbarcados_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Sistemas Embarcados  ",
                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados.  ",
                    ValoresAtitudes = "• Fortalecer a persistência e o interesse na resolução de situações-problema. \n• Estimular a organização. \n• Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}