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
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void btnAnalise_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Análise e Projeto de Sistemas",
                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.  ",
                    ValoresAtitudes = "• Estimular a organização. \n• Incentivar a criatividade. \n• Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message,"OK");
            }
                
        }

        private async void btnBanco1_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Banco de Dados I",
                    AtribuicoesResponsabilidades = "Modelar banco de dados. ",
                    ValoresAtitudes = "• Estimular a organização. \n• Fortalecer a persistência e o interesse na resolução de situações-problema. \n• Promover ações que considerem o respeito às normas estabelecidas."
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnDesign_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Design Digital",
                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e sites.  ",
                    ValoresAtitudes = "• Incentivar a criatividade. \n• Respeitar as manifestações culturais de outros povos. \n• Incentivar ações que promovam a cooperação. "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnFundamentos_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Fundamentos da Informática",
                    AtribuicoesResponsabilidades = "Operar sistemas computacionais.  ",
                    ValoresAtitudes = "• Desenvolver a criticidade. \n• Incentivar comportamentos éticos. \n• Promover ações que considerem o respeito às normas estabelecidas.  "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnWeb1_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Programação Web I",
                    AtribuicoesResponsabilidades = "Desenvolver sites para Web. ",
                    ValoresAtitudes = "• Incentivar a criatividade. \n• Estimular a organização. \n• Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnTecnicas_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Técnicas de Programação e Algoritimo",
                    AtribuicoesResponsabilidades = "Desenvolver programas de computador, utilizando princípios de boas práticas. \n• Realizar versionamento no desenvolvimento de programas.  \n• Verificar usabilidade no desenvolvimento de programas.  ",
                    ValoresAtitudes = "• Incentivar a criatividade. \n• Incentivar comportamentos éticos. \n• Fortalecer a persistência e o interesse na resolução de situações-problema. "
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