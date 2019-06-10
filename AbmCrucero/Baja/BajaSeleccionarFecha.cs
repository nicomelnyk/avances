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
    public partial class BajaSeleccionarFecha : Form
    {
        public BajaSeleccionarFecha()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void seleccionarFecha_Click(object sender, EventArgs e)
        {
            BajaFin fin = new BajaFin();
            fin.Visible = true;
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BajaCrucero baja = new BajaCrucero();
            baja.Visible = true;
            this.Dispose(false);
        }
    }
}
