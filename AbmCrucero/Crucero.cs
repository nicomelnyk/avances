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
    public partial class Crucero : Form
    {
        public Crucero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void incorporar_crucero_Click(object sender, EventArgs e)
        {
            IncorporarCrucero incorporar = new IncorporarCrucero();
            incorporar.Visible = true;
            this.Dispose(false);
        }

        private void modificar_crucero_Click(object sender, EventArgs e)
        {
            bool tipoListado = true;
            CruceroListado modificar = new CruceroListado(tipoListado);
            modificar.Visible = true;
            this.Dispose(false);
        }

        private void baja_crucero_Click(object sender, EventArgs e)
        {
            bool tipoListado = false;
            CruceroListado baja = new CruceroListado(tipoListado);
            baja.Visible = true;
            this.Dispose(false);
        }
    }
}
