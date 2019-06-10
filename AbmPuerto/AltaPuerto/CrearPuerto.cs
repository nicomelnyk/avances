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
    public partial class CrearPuerto : Form
    {
        public CrearPuerto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CrearPuerto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nombrePuerto.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else
            {
                try
                {    
                    this.guardarPuerto();
                    MessageBox.Show("Puerto guardado correctamente", "Ok");                   
                }
                catch (SqlException)
                {
                    MessageBox.Show("Ya existe un puerto con el mismo nombre", "Error");
                }
            }
        }

        private void guardarPuerto()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarPuerto", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@puerto_ID", 50); //modificar
            cmd.Parameters.AddWithValue("@nombre_puerto", nombrePuerto.Text);
            cmd.Parameters.AddWithValue("@estado_puerto", "A");

            cmd.ExecuteReader().Close();
            MessageBox.Show("guardando puerto", "loading");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmPuerto abmPuerto = new AbmPuerto();
            abmPuerto.Visible = true;
            this.Dispose(false);
        }
        
    }
}
