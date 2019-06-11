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
    public partial class IncorporacionAceptada : Form
    {
        public IncorporacionAceptada()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Crucero cru = new Crucero();
            cru.Visible = true;
            this.Dispose(false);
        }

        private void otro_cru_Click(object sender, EventArgs e)
        {
            IncorporarCrucero incorporar = new IncorporarCrucero();
            incorporar.Visible = true;
            this.Dispose(false);
        }
    }
}
