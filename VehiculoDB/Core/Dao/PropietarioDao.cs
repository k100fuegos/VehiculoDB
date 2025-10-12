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
            var lista = new List<Propietario>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"
                             SELECT idPropietario, Nombre, Apellido, DUI, Telefono, Direccion
                             FROM Propietarios /**WHERE**/
                             ORDER BY IdPropietario DESC;";
                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    sql = sql.Replace("/**WHERE**/", "WHERE Nombre LIKE @f OR Apellido LIKE qf OR DUI @f");
                }
                else
                {
                    sql = sql.Replace("/**WHERE**/", string.Empty);
                }

                command = new SqlCommand(sql, Con);
                if (!string.IsNullOrWhiteSpace(filtro))
                    command.Parameters.Add("@f", System.Data.SqlDbType.NVarChar, 120).Value = $"%{filtro}%";

                rd = command.ExecuteReader();

                while (rd.Read())
                {
                    lista.Add(Map(rd));
                }
            }
            finally
            {
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }
            return lista;
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
