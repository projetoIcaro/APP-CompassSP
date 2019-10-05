using System;
using APPCompassSP.Layers.Business;
using APPCompassSP.ViewModel;
using APPCompassSP.Views;
using Xamarin.Forms;

namespace APPCompassSP
{
    public partial class App : Application
	{
        

		public App ()
		{
			InitializeComponent();

            // Método Interno que carrega variáveis (Objetos) Globais
            LoadGlobalVariables();

            var a = new Layers.Data.InvestidorData();

            // Definindo se deve apresentar tela de login ou ir para tela principal
            if (Model.Global.Investidor != null)
            {
                MainPage = new  APPCompassSP.Views.PrincipalPage() ;
            }
            else
            {
                MainPage = new APPCompassSP.Views.LoginPage();
            }

        }

        protected override void OnStart()
        {

            // Handle when your app starts
            MessagingCenter.Subscribe<LoginViewModel>(this, "LoginSucesso",
                (sender) =>
                {
                    MainPage = new PrincipalPage();
                });

            // Handle when your app starts
            MessagingCenter.Subscribe<String>("", "Logoff",
                (sender) =>
                {

                    new LogoffBusiness().Logoff();
                    
                    MainPage = new LoginPage();
                });


        }

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        internal static void LoadGlobalVariables()
        {
            // Carregando a lista de Perfil para acesso Global
            Model.Global.Perfis = new PerfilBusiness().GetList();

            // Carregando o Investidor Logado
            Model.Global.Investidor = new InvestidorBusiness().GetInvestidorLogged();

        }


        internal static void MensagemAlerta(string texto)
        {
            App.Current.MainPage.DisplayAlert("Título", texto, "Ok");
        }




	}
}
