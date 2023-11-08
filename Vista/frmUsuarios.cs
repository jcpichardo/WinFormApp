using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using log4net;
using log4net.Config;
using Microsoft.VisualBasic.Logging;

namespace Vista
{
    public partial class Usuarios : Form
    {

        private static readonly ILog _Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Usuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            BusinessObject.UsuariosBLL objUsuarios = new BusinessObject.UsuariosBLL();
            try
            {
                dgvUser.DataSource = objUsuarios.GetUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los usuarios. Contacte al administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Log.Error(ex.Message);
            }
        }
    }
}
