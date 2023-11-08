using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace DataAccess.DAO
{
    public class UsuariosDAO : Connection.Connection_DB
    {
        
		public List<UsuariosDTO> getUsuarios()
        {
            SqlCommand sqlCommand = new SqlCommand();
            List<UsuariosDTO> listU = new List<UsuariosDTO>();

            try
			{
               
                sqlCommand.Connection = OpenConnection();
                sqlCommand.CommandText = "SELECT * FROM [seguridad].[usuarios]";
                sqlCommand.CommandType = CommandType.Text;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    listU.Add(new UsuariosDTO
                    {
                        IdUsuario = sqlDataReader.GetInt64(0),
                        Nombre = sqlDataReader.GetString(1),
                        Usuario = sqlDataReader.GetString(2),
                        Password = sqlDataReader.GetString(3),
                        Estatus = sqlDataReader.GetInt32(4)
                    });
                }
                sqlDataReader.Close();
                return listU;
            }
			catch (Exception)
			{

				throw;
			}
            finally
            {
                CloseConnection();
            }
        }


    }
}
