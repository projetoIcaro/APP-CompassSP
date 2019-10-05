using System;
using System.Collections.Generic;
using System.Windows.Input;
using APPCompassSP.Views.Components;
using Xamarin.Forms;

namespace APPCompassSP.ViewModel
{
    public class PosicaoViewModel
    {
        public PosicaoViewModel()
        {
            ListaMoedasPosicao = 
                new Layers.Business.PosicaoBusiness().ListPosicaoInvestidor(Model.Global.Investidor.IdUsuario);


            MoedaTappedCommand = new Command(() =>
            {
                //DependencyService.Get<IMessage>().LongAlert(MoedaSelecionada.NomeMoeda);
                MessagingCenter.Send<Model.MoedaModel>(MoedaSelecionada, "PosicaoDetalheAbrir");
            });
        }

        private IList<Model.MoedaModel> listaMoedasPosicao;
        public IList<Model.MoedaModel> ListaMoedasPosicao
        {
            get
            {
                return listaMoedasPosicao;
            }
            set
            {
                listaMoedasPosicao = value;
            }
        }


        private Model.MoedaModel moedaSelecionada;
        public Model.MoedaModel MoedaSelecionada
        {
            get
            {
                return moedaSelecionada;
            }
            set
            {
                moedaSelecionada = value;
            }
        }

        public ICommand MoedaTappedCommand { get; private set; }

    }
}
