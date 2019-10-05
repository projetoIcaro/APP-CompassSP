using System;
using System.Collections.Generic;

namespace APPCompassSP.Layers.Business
{
    public class PosicaoBusiness
    {

        public IList<Model.MoedaModel> ListPosicaoInvestidor(int _idInvestidor) {

            return new List<Model.MoedaModel>(){
                new Model.MoedaModel(1,"BitCoin",10000.00, 50),
                new Model.MoedaModel(1,"Iota",5000.00, 25),
                new Model.MoedaModel(1,"Ethereum",5000.00, 25)
            };
        }



    }
}
