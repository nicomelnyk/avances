using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCrucero
{
    public partial class PuertoListado : Form
    {

        private bool unListado;

        public PuertoListado(bool tipoListado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            unListado = tipoListado;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            seleccionarID.ResetText();
            seleccionarNombre.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmPuerto abmPuerto = new AbmPuerto();
            abmPuerto.Visible = true;
            this.Dispose(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (unListado)
            {
                ModificarPuerto modPuerto = new ModificarPuerto();
                modPuerto.Visible = true;
                this.Dispose(false);
            }
            else
            {
                BajaPuerto bajaPuerto = new BajaPuerto();
                bajaPuerto.Visible = true;
                this.Dispose(false);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listadoPuertos.Rows.Clear();

            string query = "SELECT * FROM ZAFFA_TEAM.Puerto WHERE PUERTO_ID LIKE '%" + seleccionarID.Text + "%'" + "and NOMBRE_PUERTO LIKE '%" + seleccionarNombre.Text + "%'";

            cargarPuertos(ClaseConexion.ResolverConsulta(query));
        
        }

        private void cargarPuertos(SqlDataReader reader)
        {
            while (reader.Read())
            {
                                
                listadoPuertos.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1).Trim(), reader.GetString(2).Trim());

            }

            reader.Close();
        }

        

        private void listadoPuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
