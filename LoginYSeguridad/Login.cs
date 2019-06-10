using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void seleccionRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            LoginAdministrativo login = new LoginAdministrativo();
            login.Visible = true;
            this.Dispose(false);
        }

        private void loginYSeguridad_Enter(object sender, EventArgs e)
        {

        }
    }
}
