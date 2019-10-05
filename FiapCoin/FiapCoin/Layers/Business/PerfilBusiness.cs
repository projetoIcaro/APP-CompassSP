using System;
using System.Collections.Generic;
using APPCompassSP.Model;

namespace APPCompassSP.Layers.Business
{
    public class PerfilBusiness
    {
        public IList<PerfilModel> GetList()
        {

            IList<PerfilModel> listaPerfis;

            Data.PerfilData perfilData = new Data.PerfilData();
            listaPerfis = perfilData.GetList();

            if (listaPerfis == null || listaPerfis.Count < 1)
            {
                listaPerfis = new Service.PerfilService().Get();

                foreach (var perfil in listaPerfis)
                {
                    perfilData.Insert(perfil);
                }
            }

            return listaPerfis;
        }
    }
}
