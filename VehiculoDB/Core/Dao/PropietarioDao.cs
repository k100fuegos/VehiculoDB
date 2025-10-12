using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculoDB.Core.Clases;
using VehiculoDB.Core.Lib;

namespace VehiculoDB.Core.Dao
{
    internal class PropietarioDao : Cnn, IPropietario
    {

        SqlConnection Con = null;
        SqlCommand command = null;

        public bool Delete(int idPropietario)
        {
            throw new NotImplementedException();
        }

        public List<Propietario> GetAll(string filtro = "")
        {
            throw new NotImplementedException();
        }

        public Propietario GetById(int idPropietario)
        {
            throw new NotImplementedException();
        }

        public int Insert(Propietario paPropietario)
        {
            throw new NotImplementedException();
        }

        public bool Update(Propietario paPropietario)
        {
            throw new NotImplementedException();
        }
    }
}
