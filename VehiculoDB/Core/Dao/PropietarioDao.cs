using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            var list = new List<Propietario>();
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
                    sql = sql.Replace("/**WHERE**/", " WHERE Nombre LIKE @f OR Apellido LIKE @f OR DUI LIKE @f");
                }
                else
                {
                    sql = sql.Replace("/**WHERE**/", string.Empty);
                }

                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    command.Parameters.Add("@f", System.Data.SqlDbType.NVarChar, 120).Value = $"%{filtro}%";

                }

                rd = command.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(Map(rd));
                }

            }

            finally
            {
                rd?.Close();
                command?.Dispose();
                CloseDB();
            }



            return list;
        }


        private static Propietario Map(SqlDataReader rd) => new Propietario
        {
            IdPropietario = rd.GetInt32(0),
            Nombre = rd.GetString(1),
            Apellido = rd.GetString(2),
            DUI = rd.GetString(3),
            Telefono = rd.IsDBNull(4) ? null : rd.GetString(4),
            Direccion = rd.IsDBNull(5) ? null : rd.GetString(5)

        }; 


        public Propietario GetById(int idPropietario)
        {
            throw new NotImplementedException();
        }

        public int Insert(Propietario paPropietario)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"INSERT INTO Propietarios (Nombre, Apellido, DUI, Telefono, Direccion) 
                                           OUTPUT INSERTED.IdPropietario 
                                           VALUES (@Nombre, @Apellido, @DUI, @Telefono, @Direccion);", Con);
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = paPropietario.Nombre;
                command.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = paPropietario.Apellido;
                command.Parameters.Add("@DUI", SqlDbType.VarChar, 10).Value = paPropietario.DUI;
                command.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value = (object?)paPropietario.Telefono ?? DBNull.Value;
                command.Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = (object?)paPropietario.Direccion ?? DBNull.Value;

                var id = (int)command.ExecuteScalar();
                return id;
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new ApplicationException("El DUI ya esta ingrezado en el sistema, Verifique la informacion");
            }
            finally
            {
                command?.Dispose();
                CloseDB();
            }
        }

        public bool Update(Propietario paPropietario)
        {
            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"UPDATE Propietarios 
                                           SET Nombre = @Nombre
                                               Apellido = @Apellido
                                               DUI = @DUI
                                               Telefono = @Telefono
                                               Direccion = @Direccion
                                            WHERE IdPropietario = @id;", Con);

                command.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = paPropietario.Nombre;
                command.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = paPropietario.Apellido;
                command.Parameters.Add("@DUI", SqlDbType.VarChar, 10).Value = paPropietario.DUI;
                command.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value = (object)paPropietario.Telefono ?? DBNull.Value;
                command.Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = (object)paPropietario.Direccion ?? DBNull.Value;

                return command.ExecuteNonQuery() > 0;

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error inseperado: ", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDB();
            }
        }
    }
}
