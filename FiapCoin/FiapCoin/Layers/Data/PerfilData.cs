using System;
using System.Collections.Generic;
using System.Linq;

namespace APPCompassSP.Layers.Data
{
    public class PerfilData
    {
        private Config.DbConnection _dbConn;

        public PerfilData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.PerfilModel>();
        }

        public List<Model.PerfilModel> GetList()
        {
            return _dbConn.Connection.Table<Model.PerfilModel>().ToList();
        }

        public Model.PerfilModel Get(int _id)
        {
            return _dbConn.Connection.Table<Model.PerfilModel>()
                          .Where(p => p.IdPerfil == _id).SingleOrDefault();
        }

        public void Insert(Model.PerfilModel _perfilModel){
            _dbConn.Connection.Insert(_perfilModel);
        }

        public void Update(Model.PerfilModel _perfilModel)
        {
            _dbConn.Connection.Update(_perfilModel);
        }

        public void Delete(Model.PerfilModel _perfilModel)
        {
            _dbConn.Connection.Delete(_perfilModel);
        }


    }
}
