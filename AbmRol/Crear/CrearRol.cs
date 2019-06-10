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
    public partial class CrearRol : Form
    {
        int id;

        public CrearRol()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void funcionalidadesE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Rol crear = new Rol();
            crear.Visible = true;
            this.Dispose(false);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nombreC.Text) || String.IsNullOrWhiteSpace(funcionalidadesC.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else
            {
                try {
                    this.guardarRol();
                    string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + funcionalidadesC.Text + "%'";
                    obtenerIdFunc(ClaseConexion.ResolverConsulta(query));

                    try
                    {
                        this.guardarFuncxRol();
                        MessageBox.Show("Rol guardado correctamente", "Ok");
                        FinRol fin = new FinRol();
                        fin.Visible = true;
                        this.Dispose(false);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al guardar la funcionalidad del rol", "Ok");
                    }         
                }
                catch (SqlException) {
                    MessageBox.Show("Error al guardar el rol", "Error");
                }
            }
        }

        private void guardarRol()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombreC.Text);
            cmd.Parameters.AddWithValue("@estado_rol", 'A');

            cmd.ExecuteReader().Close();
        }

        private void guardarFuncxRol()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarFuncionalidadxRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombreC.Text);
            cmd.Parameters.AddWithValue("@funcionalidad", id);

            cmd.ExecuteReader().Close();
        }

        private void obtenerIdFunc(SqlDataReader reader)
        {
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombreC.ResetText();
            funcionalidadesC.ResetText();
        }
    }
}
