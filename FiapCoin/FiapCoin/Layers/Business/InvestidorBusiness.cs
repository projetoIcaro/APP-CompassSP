using System;
using APPCompassSP.Model;
using System.Linq;

namespace APPCompassSP.Layers.Business
{
    public class InvestidorBusiness
    {

        public Model.InvestidorModel GetInvestidorLogged(){
            var investidor = new Data.InvestidorData().Get();

            if ( investidor != null ) {
                investidor.PerfilInvestidor =
                              Global.Perfis.SingleOrDefault(
                                  p => p.IdPerfil == investidor.IdPerfil);
            }

            return investidor;
        }


        public Model.InvestidorModel Get(int _id)
        {
            var investidor = new Service.InvestidorService().Get(_id);

            if (investidor != null)
            {
                investidor.PerfilInvestidor =
                              Global.Perfis.SingleOrDefault(
                                  p => p.IdPerfil == investidor.PerfilInvestidor.IdPerfil);
            }

            // Atualiza os dados Globais com o investidor.
            Global.Investidor = investidor;

            return investidor;
        }


        public void SaveInvestidorLogged(InvestidorModel _investidor){
            new Data.InvestidorData().Insert(_investidor);
        }

        public void Save(InvestidorModel _investidor)
        {
            new Service.InvestidorService().Save(_investidor);
            new Data.InvestidorData().Update(_investidor);
        }



    }
}
