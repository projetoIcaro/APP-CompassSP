using System;
namespace APPCompassSP.Layers.Business
{
    public class LogoffBusiness
    {

        public void Logoff(){

            new Data.InvestidorData().Delete(Model.Global.Investidor);
            Model.Global.Investidor = null;

        }

    }
}
