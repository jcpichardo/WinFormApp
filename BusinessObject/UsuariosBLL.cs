using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.DAO;
using DataAccess.DTO;

namespace BusinessObject
{
    public class UsuariosBLL
    {
        public List<UsuariosDTO> GetUsuarios()
        {
            UsuariosDAO objUserDAO = new UsuariosDAO();
            try
			{
				List<UsuariosDTO> listU = new List<UsuariosDTO>();
                listU = objUserDAO.getUsuarios();
                return listU;
			}
			catch (Exception)
			{

				throw;
			}
            finally
            {
                objUserDAO.CloseConnection();
            }
        }
    }
}
