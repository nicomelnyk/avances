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
    public partial class GeneracionViaje : Form
    {
        List<string> fabricantes = new List<string>();
        bool tipo = true;

        string cruID;
        string cruModeloDesc;
        string cruModelo;
        string cruMarcaID;
        string estadoCrucero;
        string cantCabinas;

        int superposicion;

        public GeneracionViaje()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            calendario.Show();
            calendario.Visible = false;
            calendario.MaxSelectionCount = 1;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            this.Llenar_ComboBox_Tramos();


            fabricantes.Add("P&O Cruises");
            fabricantes.Add("fathom Cruise Line");
            fabricantes.Add("Costa Cruises");
            fabricantes.Add("Holland America Line");
            fabricantes.Add("P&O Cruises Australia");
            fabricantes.Add("Princess Cruises");
            fabricantes.Add("AIDA Cruises");
            fabricantes.Add("Seaboum Cruise Line");
            fabricantes.Add("Cunard Line");
            fabricantes.Add("Carnival Cruise Lines");
        }

        private void QuitarFuncionalidad_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calendario.Visible = true;
            tipo = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calendario.Visible = true;
            tipo = false;
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (tipo) {
                var monthCalendar = sender as MonthCalendar;
                textBox1.Text = monthCalendar.SelectionStart.ToString();
            }
            else {
                var monthCalendar = sender as MonthCalendar;
                textBox2.Text = monthCalendar.SelectionStart.ToString();
            }
        }

        private void calendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Llenar_ComboBox_Tramos()
        {
            string query = "select * from ZAFFA_TEAM.Recorrido_Unico";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                decimal tramo = reader.GetDecimal(0);
                tramos.Items.Add(tramo);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listadoCruceros.Rows.Clear();

            string query = "SELECT * FROM ZAFFA_TEAM.Crucero ";

            cargarCruceros(ClaseConexion.ResolverConsulta(query));
        }

        private void cargarCruceros(SqlDataReader reader)
        {
            while (reader.Read())
            {
                superposicion = listadoCruceros.Rows.Add(reader.GetString(0).Trim(), fabricantes[reader.GetInt32(2) - 1], reader.GetString(1).Trim(), reader.GetInt32(2).ToString(), reader.GetString(3).Trim(), reader.GetInt32(4).ToString());
            }
            reader.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            calendario.Visible = false;
        }

        private void guardarViaje()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarViaj", ClaseConexion.conexion);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@recorrido_codigo", tramos.Text);
            cmd.Parameters.AddWithValue("@fecha_salida", Convert.ToDateTime(textBox1.Text));
            cmd.Parameters.AddWithValue("@fecha_llegada", Convert.ToDateTime(textBox2.Text));
            cmd.Parameters.AddWithValue("@fecha_llegada_estimada", Convert.ToDateTime(textBox2.Text));
            cmd.Parameters.AddWithValue("@crucero_id", cruID);
            
            cmd.ExecuteReader().Close();
        }

        private void VerificarSuperposicion(SqlDataReader reader)
        {
            while (reader.Read())
            {
                superposicion = reader.GetInt32(0); //listadoRoles.Rows.Add(reader.GetString(0).Trim(), reader.GetString(1));
            }
            reader.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(tramos.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else
            {
                if (Convert.ToDateTime(textBox1.Text) > DateTime.Now)
                {
                    if (Convert.ToDateTime(textBox2.Text) > Convert.ToDateTime(textBox1.Text))
                    {
                        try
                        {
                            foreach (DataGridViewRow row in listadoCruceros.SelectedRows)
                            {
                                cruID = row.Cells[0].Value.ToString();
                                cruModeloDesc = row.Cells[1].Value.ToString();
                                cruModelo = row.Cells[2].Value.ToString();
                                cruMarcaID = row.Cells[3].Value.ToString();
                                estadoCrucero = row.Cells[4].Value.ToString();
                                cantCabinas = row.Cells[5].Value.ToString();

                                string query = "SELECT count(*) FROM ZAFFA_TEAM.Viaje WHERE CRUCERO_ID = '" + cruID + "' AND ( '" + String.Format("{0:u}", Convert.ToDateTime(textBox1.Text)) + "' BETWEEN FECHA_SALIDA AND FECHA_LLEGADA OR '" + String.Format("{0:u}", Convert.ToDateTime(textBox2.Text)) + "' BETWEEN FECHA_SALIDA AND FECHA_LLEGADA )";

                                try
                                {
                                    VerificarSuperposicion(ClaseConexion.ResolverConsulta(query));
                                }
                                catch (SqlException) 
                                {
                                    MessageBox.Show("Fallo al convalidar si el crucero tiene otro viaje entre esas fechas", "Error");
                                }
                                if (superposicion == 0)
                                {
                                    this.guardarViaje();
                                    MessageBox.Show("Viaje guardado correctamente", "Ok");
                                }
                                else
                                {
                                     MessageBox.Show("El crucero tiene otro viaje entre las fechas seleccionadas", "Error");
                                }
                            }

                            try
                            {
                               listadoCruceros.CurrentCell.RowIndex.ToString();
                            }
                            catch (NullReferenceException)
                            {
                                MessageBox.Show("Por favor seleccione alguna fila", "Ok");
                            }

                        }
                        catch (NullReferenceException)
                        {
                           MessageBox.Show("Por favor seleccione alguna fila válida de la tabla", "Ok");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha de salida ya pasó. Seleccione una fecha posterior al día de hoy", "Error");
                    }
                }
                else {
                    MessageBox.Show("En las fechas seleccionadas el crucero ya tiene otro viaje programado", "Error");
                }
            }
        }
    }
}
