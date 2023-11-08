using DataAccess.DAO;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrdenesBLL
    {

        public int SalvaOrden(OrdenesDTO _oDTO, List<OrdenesDetDTO> _listodet) 
        {
            OrdenesDAO objOrdenDAO = new OrdenesDAO();
            OrdenesDetDAO objOrdenDetDAO  = new OrdenesDetDAO();
            try
            {
                objOrdenDAO.SalvarOrden(_oDTO);
                objOrdenDetDAO.SalvarOrdenDetalle(_listodet);
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //objOrdenDAO.CloseConnection();
                //objOrdenDetDAO.CloseConnection();
            }
        }

    }
}
