using System;
namespace APPCompassSP.ViewModel
{
    public class PosicaoDetalheViewModel
    {

        public PosicaoDetalheViewModel()
        {
            Moeda = Model.Global.MoedaPosicaoDetalhe;
        }


        public PosicaoDetalheViewModel(Model.MoedaModel _moeda)
        {
            Moeda = _moeda;
        }

        private Model.MoedaModel moeda;
        public Model.MoedaModel Moeda
        {
            get
            {
                return moeda;
            }
            set
            {
                moeda = value;
            }
        }

    }
}
