﻿using System;
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
    public partial class CargarCabinas : Form
    {
        int cab = 1;
        int piso_cab = 1;
        string id;

        public CargarCabinas(string id_cabina)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            id = id_cabina;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            tipoCab.ResetText();
        }

        private void cargar_cabinas_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tipoCab.Text))
            {
                MessageBox.Show("Debe completar el tipo de cabina", "Error");
            }
            else
            {
                try
                {

                    this.guardarCabina();
                    MessageBox.Show("Cabina guardada correctamente", "Ok");
                    cab++;
                    if (cab % 10 == 0)
                    {
                        piso_cab++;
                    }
                    nroCabina.Text = cab.ToString();
                    pisoCabina.Text = piso_cab.ToString();
                    tipoCab.ResetText();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error al cargar la cabina", "Error");
                }
            }
        }

        private void guardarCabina()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarCabina", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", id);
            cmd.Parameters.AddWithValue("@cabina_nro", cab);
            cmd.Parameters.AddWithValue("@cabina_piso", piso_cab);
            cmd.Parameters.AddWithValue("@cabina_tipo_id", 2);

            cmd.ExecuteReader().Close();
        }

        private void guardarCabinaContador()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_updateCantCabinas", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cant_cabinas", cab - 1);
            cmd.Parameters.AddWithValue("@crucero_id", id);

            cmd.ExecuteReader().Close();
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.guardarCabinaContador();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al asociar las cabinas al crucero", "Error");
            }
            IncorporacionAceptada aceptar = new IncorporacionAceptada();
            aceptar.Visible = true;
            this.Dispose(false);
        }

        private void tipoCab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
