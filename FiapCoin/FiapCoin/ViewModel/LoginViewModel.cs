using System.Windows.Input;
using Xamarin.Forms;
using APPCompassSP.Model;
using System;
using APPCompassSP.Layers.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace APPCompassSP.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public ICommand EntrarClickedCommand { get; private set; }

        public ICommand ScannerClickedCommand { get; private set; }


        public Usuario _usuario;
        public Usuario Usuario { 
            get {
                return _usuario;
            }
            set {
                _usuario = value;
                NotifyPropertyChanged();
            }
        }



        public LoginViewModel() {

            Usuario = new Usuario();
            Usuario.Email = "admin@fiap.com.br";
            Usuario.Senha = "123456";


            EntrarClickedCommand = new Command(() => {
                try
                {
                    var investidor = 
                        new Layers.Business.UsuarioBusiness().Login(Usuario.Email,Usuario.Senha);

                    App.LoadGlobalVariables();

                    MessagingCenter.Send<LoginViewModel>(this, "LoginSucesso");
                } catch (Exception ex) {
                    App.MensagemAlerta("Login ou senha inválida. Detalhe: " + ex.Message);
                }
            });


            ScannerClickedCommand = new Command( async () =>
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                var result = await scanner.Scan();

                if (result != null)
                {
                    var valores = result.Text.Split(';');
                    this.Usuario = new Usuario();
                    this.Usuario.Email = valores[0];
                    this.Usuario.Senha = valores[1];
                }

            });

        }
    }
}
