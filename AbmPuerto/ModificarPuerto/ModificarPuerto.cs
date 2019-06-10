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
    public partial class ModificarPuerto : Form
    {
        public ModificarPuerto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ModificarPuerto_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            PuertoListado puertoListado = new PuertoListado(true);
            puertoListado.Visible = true;
            this.Dispose(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
