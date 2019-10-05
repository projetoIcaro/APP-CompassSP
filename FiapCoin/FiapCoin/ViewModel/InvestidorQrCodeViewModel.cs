using System;
namespace APPCompassSP.ViewModel
{
    public class InvestidorQrCodeViewModel
    {
        public InvestidorQrCodeViewModel()
        {
            this.Investidor = Model.Global.Investidor;
        }

        private Model.InvestidorModel investidor;
        public Model.InvestidorModel Investidor
        {
            get { return investidor; }
            set { investidor = value; }
        }
    }
}
