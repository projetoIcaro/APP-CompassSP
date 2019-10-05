using APPCompassSP.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APPCompassSP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        protected LoginViewModel loginViewModel;
		
        public LoginPage ()
		{
			InitializeComponent ();
        }
    }
}