using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APPCompassSP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}


        public void ContatoClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<ContatoPage>(new ContatoPage(), "ContatoPageAbrir");
        }

        public void InvestidoresClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<string>("", "InvestidoresPageAbrir");
        }


        public void QuemSomosClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<String>("", "QuemSomosPageAbrir");
        }


        public void SairClicked(object o, EventArgs e) {

            MessagingCenter.Send<String>("","Logoff");
            
        }



    }
}