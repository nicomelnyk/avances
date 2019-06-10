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
    public partial class CruceroListado : Form
    {
        private bool unListado;
        List<string> fabricantes = new List<string>();

        string cruID;
        string cruModeloDesc;
        string cruModelo;
        string cruMarcaID;
        string estadoCrucero;
        string cantCabinas;

        string id;

        public CruceroListado(bool tipoListado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            unListado = tipoListado;
           
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CruceroListado_Load(object sender, EventArgs e)
        {

        }

        private void limpiarListado_Click(object sender, EventArgs e)
        {
            seleccionarID.ResetText();
            seleccionarFabricante.ResetText();
            seleccionarModelo.ResetText();
        }

        private void buscarListado_Click(object sender, EventArgs e)
        {
            listadoCruceros.Rows.Clear();

            string query = "SELECT * FROM ZAFFA_TEAM.Crucero WHERE crucero_id LIKE '%" + seleccionarID.Text + "%'" + "and crucero_modelo LIKE '%" + seleccionarModelo.Text + "%'";
            
            

            if (string.Compare(seleccionarFabricante.Text,"")!=0)
            {
                string query2 = "SELECT CRUCERO_MARCA_ID FROM ZAFFA_TEAM.Marca WHERE crucero_fabricante LIKE '%" + seleccionarFabricante.Text + "%'";
                obtenerIdFab(ClaseConexion.ResolverConsulta(query2));
                query += " and crucero_marca_id LIKE '%" + id + "%'";  //para evitar un NullPointerExc
            }

            cargarCruceros(ClaseConexion.ResolverConsulta(query));
        }

        private void cargarCruceros(SqlDataReader reader)
        {
            while (reader.Read())
            {
                listadoCruceros.Rows.Add(reader.GetString(0).Trim(), fabricantes[reader.GetInt32(2) - 1], reader.GetString(1).Trim(), reader.GetInt32(2).ToString(), reader.GetString(3).Trim(), reader.GetInt32(4).ToString());
            }
            reader.Close();
        }

        private void atrasListado_Click(object sender, EventArgs e)
        {
            Crucero modificar = new Crucero();
            modificar.Visible = true;
            this.Dispose(false);
        }

        private void obtenerIdFab(SqlDataReader reader)
        {
            while (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
            }
            reader.Close();
        }

        private void modificarListado_Click(object sender, EventArgs e)
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

                    if (unListado)
                    {
                        ModificarCrucero modificar = new ModificarCrucero(cruID, cruModeloDesc, cruMarcaID);
                        modificar.Visible = true;
                        this.Dispose(false);
                    }
                    else
                    {
                        BajaCrucero baja = new BajaCrucero();
                        baja.Visible = true;
                        this.Dispose(false);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione alguna fila válida", "Ok");
            }
        }

        private void listadoCruceros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
