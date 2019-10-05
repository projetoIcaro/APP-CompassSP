using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace APPCompassSP.Views
{
    public partial class PosicaoDetalhePage : ContentPage
    {
        public PosicaoDetalhePage()
        {
            InitializeComponent();
        }


        public void VoltarClicked(object o, EventArgs e){
            Navigation.PopAsync();
        }

    }
}
