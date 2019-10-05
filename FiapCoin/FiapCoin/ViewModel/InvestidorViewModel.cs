using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using APPCompassSP.Layers.Service;
using APPCompassSP.Model;
using APPCompassSP.Views.Components;
using Xamarin.Forms;

namespace APPCompassSP.ViewModel
{
    public class InvestidorViewModel
    {
        private InvestidorModel _investidor;
        public InvestidorModel Investidor
        {
            get
            {
                return _investidor;
            }
            set
            {
                _investidor = value;
                Global.Investidor = _investidor;
            }
        }


        public InvestidorViewModel()
        {
            _investidor = Global.Investidor;
            _perfis = Global.Perfis;

            // Definindo Perfil para Seleção no Picker;
            _investidor.PerfilInvestidor =
                _perfis.Where(p => p.IdPerfil == _investidor.IdPerfil).SingleOrDefault();


            GravarClickedCommand = new Command(() => {
                var mensagem = "Dados do investidor alterados com sucesso!";
                try
                {
                    new InvestidorService().Save(_investidor);
                } catch (Exception ex) {
                    mensagem = "Não foi possível alterar os dados do investidor. Verifique sua conexão! \n Detalhe: " +
                        ex.Message;
                }

                DependencyService.Get<IMessage>().ShortAlert(mensagem);
            });


            GerarQrCodeClickedCommand = new Command( () =>
            {
                MessagingCenter.Send<string>("", "InvestidorQrCodeAbrir");
            });


        }

        // Commando Clicked
        public ICommand GravarClickedCommand { get; private set; }


        public ICommand GerarQrCodeClickedCommand { get; private set; }



        private IList<PerfilModel> _perfis;
        public IList<PerfilModel> Perfis
        {
            get
            {
                return _perfis;
            }
            set
            {
                _perfis = value;
            }
        }



    }
}
