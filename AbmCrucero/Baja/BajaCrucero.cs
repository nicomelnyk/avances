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
    public partial class BajaCrucero : Form
    {
        public BajaCrucero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void baja_definitiva_Click(object sender, EventArgs e)
        {
            BajaFin fin = new BajaFin();
            fin.Visible = true;
            this.Dispose(false);
            // BORRO DEFINITIVAMENTE CRUCERO
        }

        private void fuera_servicio_Click(object sender, EventArgs e)
        {
            BajaSeleccionarFecha fecha = new BajaSeleccionarFecha();
            fecha.Visible = true;
            this.Dispose(false);
            // SELECCIONO FECHA
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            CruceroListado listado = new CruceroListado(false);
            listado.Visible = true;
            this.Dispose(false);
        }
    }
}
