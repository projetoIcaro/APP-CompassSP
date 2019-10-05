using System;
using APPCompassSP.Layers.Service;
using APPCompassSP.Model;

namespace APPCompassSP.Layers.Business
{
    public class UsuarioBusiness
    {

        public Model.InvestidorModel Login(string email, string senha)
        {

            // Efetuar o login
            var _usuario =
                    new UsuarioService().Login(new Usuario(email.ToLower(), senha.ToLower()));

            // Consultar os dados do Investidor (Caso login sucesso).
            var _investidor = new InvestidorModel();

            if (_usuario.IdUsuario != 0)
            {
                _investidor = new InvestidorService().Get(_usuario.IdUsuario);

                if (_investidor != null)
                {
                    // Grava os dados do investidor no dispositivo
                    new InvestidorBusiness().SaveInvestidorLogged(_investidor);
                }

            }

            if ( _investidor == null ) {
                throw new Exception("Não foi possível efetuar o logon");
            }
                

            return _investidor;


        }

    }
}
