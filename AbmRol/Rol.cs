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
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void crear_rol_Click(object sender, EventArgs e)
        {
            CrearRol crear = new CrearRol();
            crear.Visible = true;
            this.Dispose(false);
        }

        private void modificar_rol_Click(object sender, EventArgs e)
        {
            bool tipoListado = true;
            ListadoRol listado = new ListadoRol(tipoListado);
            listado.Visible = true;
            this.Dispose(false);
        }

        private void eliminar_rol_Click(object sender, EventArgs e)
        {
            bool tipoListado = false;
            ListadoRol listado = new ListadoRol(tipoListado);
            listado.Visible = true;
            this.Dispose(false);
        }
    }
}
