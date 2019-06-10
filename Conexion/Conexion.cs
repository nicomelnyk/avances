using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Configuration;

namespace FrbaCrucero
{
    class ClaseConexion
    {

        //static string server = ConfigurationManager.AppSettings["GD1C2019"].ToString();
        //static string user = ConfigurationManager.AppSettings["gdCruceros2019"].ToString();
        //static string password = ConfigurationManager.AppSettings["gd2019"].ToString();

        // declaro una variable de conexion global
        public static SqlConnection conexion = getConnection();

        public static void Conectar()
        {
            MessageBox.Show("Se intenta realizar la conexion.");
          
            try
            {
                conexion.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se pudo establecer la conexion a la base de datos." + e.Message);
            }
        }

        public static SqlDataReader ResolverConsulta(String query)
        {
            return new SqlCommand(query, conexion).ExecuteReader();
        }

        public static int ResolverNonQuery(String nonQuery)
        {
            return new SqlCommand(nonQuery, conexion).ExecuteNonQuery();
        }

        public static object ResolverFuncion(String query)
        {
            return new SqlCommand(query, conexion).ExecuteScalar();
        }

        public static void ActualizarGrid(DataGridView dg, string tabla, string consulta)
        {
            // instancio el dataset que va a llenar de datos el datagridview
            System.Data.DataSet ds = new System.Data.DataSet();
            // instancio un adaptador de datos entre el dataset y la bd
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
            // llenar el dataSet con los datos de la tabla NN a través del adapter     
            da.Fill(ds, tabla);
            dg.DataSource = ds;
            // para traer todo el contenido de la tabla NN al dataGridView
            dg.DataMember = tabla;
        }


        //Gaston = DESKTOP-Q7PPQN2
        //Nico = LAPTOP-TG43AQC2
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            //con.name = "FrbaCrucero.Properties.Settings.GD1C2019ConnectionString";
            con.ConnectionString = "Data Source=LAPTOP-TG43AQC2\\SQLSERVER2012V2;Initial Catalog=GD1C2019;Persist Security Info=True;User ID=gdCruceros2019;Password=gd2019";
            //con.providerName = "System.Data.SqlClient";
            return con;
        }
    }
}
