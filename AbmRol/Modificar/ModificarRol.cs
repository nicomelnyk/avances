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
    public partial class ModificarRol : Form
    {
        string nom;
        string funcionalidad;
        int id;
        List<string> funcionalidades = new List<string>();
        string nombr;
        string func;

        public ModificarRol(string v1, string v2)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            nom = v1;
            funcionalidad = v2;


            funcionalidades.Add("AbmRol");
            funcionalidades.Add("AbmCrucero");
            funcionalidades.Add("AbmPuerto");
            funcionalidades.Add("AbmRecorrido");
            funcionalidades.Add("CompraReservaPasaje");
            funcionalidades.Add("GeneracionViaje");
            funcionalidades.Add("ListadoEstadistico");
            funcionalidades.Add("PagoReserva");
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ListadoRol crear = new ListadoRol(true);
            crear.Visible = true;
            this.Dispose(false);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            //ErrorEliminar errorE = new ErrorEliminar();
            //errorE.Visible = true;
            //this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void modificarNombre()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_updateNombreRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nuevoNombre.Text);
            cmd.Parameters.AddWithValue("@nombre_viejo", nom);

            cmd.ExecuteReader().Close();

            cmd = new SqlCommand("ZAFFA_TEAM.sp_updateNombreFuncionalidadxRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nuevoNombre.Text);
            cmd.Parameters.AddWithValue("@nombre_viejo", nom);

            cmd.ExecuteReader().Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nuevoNombre.Text)) {
                MessageBox.Show("Debe completar el nuevo nombre", "Error");
            }
            else {
                try
                {
                    this.modificarNombre();
                    MessageBox.Show("Se ha modificado el nombre del rol", "Ok");
                    nom = nuevoNombre.Text;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error al tratar de cambiar el nombre", "Ok");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nuevoNombre.ResetText();
        }

        private void obtenerIdFunc(SqlDataReader reader)
        {
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
        }

        private void guardarFuncxRol()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarFuncionalidadxRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nom);
            cmd.Parameters.AddWithValue("@funcionalidad", id);

            cmd.ExecuteReader().Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nuevaFunc.Text))
            {
                MessageBox.Show("Debe elegir alguna opción", "Error");
            }
            else
            {
                string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + nuevaFunc.Text + "%'";
                obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                try
                {
                    this.guardarFuncxRol();
                    MessageBox.Show("Funcionalidad guardada", "Ok");
                }
                catch (SqlException)
                {
                   MessageBox.Show("Ya se posee dicha funcionalidad", "Ok");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Listadoxfunc.Rows.Clear();

            string query = "SELECT * FROM ZAFFA_TEAM.[Funcionalidad x Rol] WHERE nombre_rol LIKE '%" + nom + "%'";
            cargarFuncionalidad(ClaseConexion.ResolverConsulta(query));
        }

        private void cargarFuncionalidad(SqlDataReader reader)
        {
            while (reader.Read())
            {
                Listadoxfunc.Rows.Add(reader.GetString(0).Trim(), reader.GetInt32(1).ToString() , funcionalidades[reader.GetInt32(1) - 1]);
            }
            reader.Close();
        }
        
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Listadoxfunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void borrarRolxFunc(string nombr, string func)
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_deleteFuncionalidadxRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombr);
            cmd.Parameters.AddWithValue("@funcionalidad", func);

            cmd.ExecuteReader().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in Listadoxfunc.SelectedRows)
                {
                    nombr = row.Cells[0].Value.ToString();
                    func = row.Cells[1].Value.ToString();

                    try
                    {
                        this.borrarRolxFunc(nombr, func);
                        Listadoxfunc.Rows.Clear();
                        string query = "SELECT * FROM ZAFFA_TEAM.[Funcionalidad x Rol] WHERE nombre_rol LIKE '%" + nom + "%'";
                        cargarFuncionalidad(ClaseConexion.ResolverConsulta(query));
                        MessageBox.Show("Rol dado de baja", "Ok");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al tratar de quitar el rol", "Ok");
                    }
                }
                try
                {
                    Listadoxfunc.CurrentCell.RowIndex.ToString();
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

        private void guardarHab(String nombr)
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_habilitarFuncionalidad", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombr);
            cmd.Parameters.AddWithValue("@estado_rol", 'A');

            cmd.ExecuteReader().Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.Compare(funcionalidad, "I") == 0) {
                try
                {
                    this.guardarHab(nom);
                    MessageBox.Show("Rol activado", "Ok");
                    funcionalidad = "A";
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error al tratar de volver a habilitar el rol", "Ok");
                }       
                                
            }
            else {
                MessageBox.Show("Este rol ya se encontraba activo", "Error");
            }
        }
    }
}
