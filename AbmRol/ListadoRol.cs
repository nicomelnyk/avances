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
    public partial class ListadoRol : Form
    {
        private bool unListado;
        string nombr;
        string estado;

        public ListadoRol(bool tipoListado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            unListado = tipoListado;
        }

        private void listadoCruceros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarListadoRol_Click(object sender, EventArgs e)
        {
            listadoRoles.Rows.Clear();

            string query = "SELECT * FROM ZAFFA_TEAM.Rol WHERE nombre_rol LIKE '%" + rolTipo.Text + "%'";
            cargarRoles(ClaseConexion.ResolverConsulta(query));
        }

        private void cargarRoles(SqlDataReader reader)
        {
            while (reader.Read())
            {
                listadoRoles.Rows.Add(reader.GetString(0).Trim(), reader.GetString(1));
            }
            reader.Close();
        }

        private void limpiarListadoRol_Click(object sender, EventArgs e)
        {
            rolTipo.ResetText();
        }

        private void guardarInhab(String nombr)
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_udteFuncionalidad", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombr);
            cmd.Parameters.AddWithValue("@estado_rol", 'I');

            cmd.ExecuteReader().Close();
        }

        private void modificarListadoRol_Click(object sender, EventArgs e)
        {
            try {
                foreach (DataGridViewRow row in listadoRoles.SelectedRows) 
                {
                    nombr = row.Cells[0].Value.ToString();
                    estado = row.Cells[1].Value.ToString();
                    if (unListado)
                    {
                        ModificarRol modificar = new ModificarRol(nombr,estado);
                        modificar.Visible = true;
                        this.Dispose(false);
                    }
                    else
                    {
                        if (string.Compare(estado, "A") == 0) {
                            //doy de baja logica
                            try
                            {
                                this.guardarInhab(nombr);
                                listadoRoles.Rows.Clear();
                                string query = "SELECT * FROM ZAFFA_TEAM.Rol WHERE nombre_rol LIKE '%" + rolTipo.Text + "%'";
                                cargarRoles(ClaseConexion.ResolverConsulta(query));
                                MessageBox.Show("Rol dado de baja", "Ok");
                            }
                            catch (SqlException)
                            {
                                MessageBox.Show("Error al tratar de inhabilitar el rol", "Ok");
                            }         
                        }
                        else {
                            MessageBox.Show("Dicho rol ya se encuentra inhabilitado", "Ok");
                        }
                    }
                }

                try
                {
                    listadoRoles.CurrentCell.RowIndex.ToString();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Por favor seleccione alguna fila", "Ok");
                }    
     
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione alguna fila válida", "Ok");
            }
        }

        private void atrasListadoRol_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Visible = true;
            this.Dispose(false);
        }
    }
}
