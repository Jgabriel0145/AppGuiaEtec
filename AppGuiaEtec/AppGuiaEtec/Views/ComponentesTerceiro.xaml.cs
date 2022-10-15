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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void btnTCC_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas   ",
                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais.  ",
                    ValoresAtitudes = "• Planejar ações mais eficazes no desenvolvimento de sistemas. \n• Demonstrar comprometimento com equipe e o trabalho.  "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnMobile2_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile II ",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis. ",
                    ValoresAtitudes = "• Responsabilizar-se pela produção, utilização e divulgação de informações. \n• Incentivar a criatividade. \n• Estimular a organização. "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnWeb3_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Programação Web III  ",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para web. ",
                    ValoresAtitudes = "• Responsabilizar-se pela produção, utilização e divulgação de informações. \n• Fortalecer a persistência e o interesse na resolução de situações-problema. \n• Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnQualidade_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Qualidade e Teste de Software  ",
                    AtribuicoesResponsabilidades = "Testar softwares para melhoria da qualidade de sistemas. \n• Elaborar registros e planilhas de acompanhamento e controle das atividades.  ",
                    ValoresAtitudes = "• Responsabilizar-se pela produção, utilização e divulgação de informações. \n• Estimular a proatividade. \n• Desenvolver criticidade. \n• Incentivar comportamentos éticos. "
                };

                await Navigation.PushAsync(new VerComponente(componente));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btnSeguranca_Clicked(object sender, EventArgs e)
        {
            try
            {
                var componente = new Componente
                {
                    Nome = "Segurança de Sistemas de Informação  ",
                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança da informação. ",
                    ValoresAtitudes = "• Estimular atitudes respeitosas. \n• Incentivar comportamentos éticos. \n• Desenvolver a criticidade.  "
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