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
    public partial class IncorporarCrucero : Form
    {
        int id; 

        public IncorporarCrucero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void obtenerIdFab(SqlDataReader reader)
        {
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nombreID.Text) || String.IsNullOrWhiteSpace(fabricanteCru.Text) || String.IsNullOrWhiteSpace(modeloCru.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else
            {
                try
                {
                    string query = "SELECT CRUCERO_MARCA_ID FROM ZAFFA_TEAM.Marca WHERE crucero_fabricante LIKE '%" + fabricanteCru.Text + "%'";
                    obtenerIdFab(ClaseConexion.ResolverConsulta(query));
                    this.guardarCrucero();
                    MessageBox.Show("Crucero guardado correctamente", "Ok");
                    CargarCabinas cabinas = new CargarCabinas(nombreID.Text);
                    cabinas.Visible = true;
                    this.Dispose(false);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Ya existe un crucero con el mismo ID", "Error");
                }
            }
        }

        private void guardarCrucero()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarCrucero", ClaseConexion.conexion);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", nombreID.Text);
            cmd.Parameters.AddWithValue("@crucero_modelo", modeloCru.Text);
            cmd.Parameters.AddWithValue("@crucero_marca_id", id);
            cmd.Parameters.AddWithValue("@estado_crucero", "Alta");
            cmd.Parameters.AddWithValue("@cantidad_cabinas", 0);
            
            cmd.ExecuteReader().Close();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Crucero crucero = new Crucero();
            crucero.Visible = true;
            this.Dispose(false);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombreID.ResetText();
            fabricanteCru.ResetText();
            modeloCru.ResetText();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void fabricanteCru_TextChanged(object sender, EventArgs e)
        {

        }

        private void fabricanteCru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombreID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
