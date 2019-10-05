using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace APPCompassSP.Layers.Data
{
    public class InvestidorData
    {
        
        private Config.DbConnection _dbConn;

        public InvestidorData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.InvestidorModel>();
        }


        public Model.InvestidorModel Get()
        {
            return _dbConn.Connection.Table<Model.InvestidorModel>().FirstOrDefault();
        }

        public void Insert(Model.InvestidorModel _investidorModel)
        {
            _dbConn.Connection.Insert(_investidorModel);
        }


        public void Update(Model.InvestidorModel _investidorModel)
        {
            _dbConn.Connection.Update(_investidorModel);
        }

        public void Delete(Model.InvestidorModel _investidorModel)
        {
            _dbConn.Connection.Delete(_investidorModel);
        }

        public void DropTable(){
            _dbConn.Connection.DropTable<Model.InvestidorModel>();
        }
    }
}
