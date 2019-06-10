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
    public partial class ModificarCrucero : Form
    {
        string id;
        string desc;
        string id_desc;
        string id_nuevo;

        public ModificarCrucero(string idCru, string descCru, string id_descCru)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            id = idCru;
            desc = descCru;
            id_desc = id_descCru;
        }

        private void updateFabricante()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_updateFabCrucero", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", id);
            cmd.Parameters.AddWithValue("@crucero_marca_id", id_nuevo);
            cmd.Parameters.AddWithValue("@marca_vieja", id_desc);

            cmd.ExecuteReader().Close();
        }

        private void obtenerIdFab(SqlDataReader reader)
        {
            while (reader.Read())
            {
                id_nuevo = reader.GetInt32(0).ToString();  
            }
            reader.Close();
        }

        private void modificarCruc_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(fabricanteModif.Text))
            {
                MessageBox.Show("Debe elegir el nuevo fabricante", "Error");
            }
            else
            {
                try
                {
                    string query = "SELECT CRUCERO_MARCA_ID FROM ZAFFA_TEAM.Marca WHERE crucero_fabricante LIKE '%" + fabricanteModif.Text + "%'";
                    obtenerIdFab(ClaseConexion.ResolverConsulta(query));

                    this.updateFabricante();
                    MessageBox.Show("Fabricante actualizado", "Volver al inicio");
                    Crucero cru = new Crucero();
                    cru.Visible = true;
                    this.Dispose(false);
                }
                catch (SqlException)
                {
                    MessageBox.Show("El fabricante elegido es el actual", "Ok");
                }
            }
        }

        private void atrasMod_Click(object sender, EventArgs e)
        {
            CruceroListado listado = new CruceroListado(true);
            listado.Visible = true;
            this.Dispose(false);
        }

        private void limpiarMod_Click(object sender, EventArgs e)
        {
            fabricanteModif.ResetText();
        }

        private void modC_TextChanged(object sender, EventArgs e)
        {

        }

        private void fabricanteModif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
