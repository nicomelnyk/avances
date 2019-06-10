namespace FrbaCrucero
{
    partial class CruceroListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atrasListado = new System.Windows.Forms.Button();
            this.modificarListado = new System.Windows.Forms.Button();
            this.limpiarListado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.seleccionarID = new System.Windows.Forms.TextBox();
            this.seleccionarFabricante = new System.Windows.Forms.ComboBox();
            this.seleccionarModelo = new System.Windows.Forms.TextBox();
            this.buscarListado = new System.Windows.Forms.Button();
            this.listadoCruceros = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABINAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar por fabricante:";
            // 
            // atrasListado
            // 
            this.atrasListado.Location = new System.Drawing.Point(12, 413);
            this.atrasListado.Name = "atrasListado";
            this.atrasListado.Size = new System.Drawing.Size(58, 28);
            this.atrasListado.TabIndex = 11;
            this.atrasListado.Text = "Atrás";
            this.atrasListado.UseVisualStyleBackColor = true;
            this.atrasListado.Click += new System.EventHandler(this.atrasListado_Click);
            // 
            // modificarListado
            // 
            this.modificarListado.Location = new System.Drawing.Point(789, 411);
            this.modificarListado.Name = "modificarListado";
            this.modificarListado.Size = new System.Drawing.Size(127, 30);
            this.modificarListado.TabIndex = 10;
            this.modificarListado.Text = "SELECCIONAR";
            this.modificarListado.UseVisualStyleBackColor = true;
            this.modificarListado.Click += new System.EventHandler(this.modificarListado_Click);
            // 
            // limpiarListado
            // 
            this.limpiarListado.Location = new System.Drawing.Point(549, 31);
            this.limpiarListado.Name = "limpiarListado";
            this.limpiarListado.Size = new System.Drawing.Size(157, 54);
            this.limpiarListado.TabIndex = 9;
            this.limpiarListado.Text = "LIMPIAR";
            this.limpiarListado.UseVisualStyleBackColor = true;
            this.limpiarListado.Click += new System.EventHandler(this.limpiarListado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filtrar por modelo:";
            // 
            // seleccionarID
            // 
            this.seleccionarID.Location = new System.Drawing.Point(192, 12);
            this.seleccionarID.Name = "seleccionarID";
            this.seleccionarID.Size = new System.Drawing.Size(316, 22);
            this.seleccionarID.TabIndex = 13;
            // 
            // seleccionarFabricante
            // 
            this.seleccionarFabricante.FormattingEnabled = true;
            this.seleccionarFabricante.Items.AddRange(new object[] {
            "P&O Cruises",
            "fathom Cruise Line",
            "Costa Cruises",
            "Holland America Line",
            "P&O Cruises Australia",
            "Princess Cruises",
            "AIDA Cruises",
            "Seaboum Cruise Line",
            "Cunard Line",
            "Carnival Cruise Lines"});
            this.seleccionarFabricante.Location = new System.Drawing.Point(192, 41);
            this.seleccionarFabricante.Name = "seleccionarFabricante";
            this.seleccionarFabricante.Size = new System.Drawing.Size(316, 24);
            this.seleccionarFabricante.TabIndex = 15;
            // 
            // seleccionarModelo
            // 
            this.seleccionarModelo.Location = new System.Drawing.Point(192, 73);
            this.seleccionarModelo.Name = "seleccionarModelo";
            this.seleccionarModelo.Size = new System.Drawing.Size(316, 22);
            this.seleccionarModelo.TabIndex = 16;
            // 
            // buscarListado
            // 
            this.buscarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarListado.Location = new System.Drawing.Point(741, 31);
            this.buscarListado.Name = "buscarListado";
            this.buscarListado.Size = new System.Drawing.Size(157, 54);
            this.buscarListado.TabIndex = 17;
            this.buscarListado.Text = "CARGAR\r\n";
            this.buscarListado.UseVisualStyleBackColor = true;
            this.buscarListado.Click += new System.EventHandler(this.buscarListado_Click);
            // 
            // listadoCruceros
            // 
            this.listadoCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoCruceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MARCA_DESC,
            this.MODELO,
            this.MARCA_ID,
            this.ESTADO,
            this.CABINAS});
            this.listadoCruceros.Location = new System.Drawing.Point(12, 117);
            this.listadoCruceros.Name = "listadoCruceros";
            this.listadoCruceros.RowTemplate.Height = 24;
            this.listadoCruceros.Size = new System.Drawing.Size(904, 288);
            this.listadoCruceros.TabIndex = 18;
            this.listadoCruceros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoCruceros_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // MARCA_DESC
            // 
            this.MARCA_DESC.HeaderText = "MARCA_DESC";
            this.MARCA_DESC.Name = "MARCA_DESC";
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            // 
            // MARCA_ID
            // 
            this.MARCA_ID.HeaderText = "MARCA_ID";
            this.MARCA_ID.Name = "MARCA_ID";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // CABINAS
            // 
            this.CABINAS.HeaderText = "CABINAS";
            this.CABINAS.Name = "CABINAS";
            // 
            // CruceroListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 453);
            this.Controls.Add(this.listadoCruceros);
            this.Controls.Add(this.limpiarListado);
            this.Controls.Add(this.buscarListado);
            this.Controls.Add(this.seleccionarModelo);
            this.Controls.Add(this.seleccionarFabricante);
            this.Controls.Add(this.seleccionarID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modificarListado);
            this.Controls.Add(this.atrasListado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CruceroListado";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.CruceroListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoCruceros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button atrasListado;
        private System.Windows.Forms.Button modificarListado;
        private System.Windows.Forms.Button limpiarListado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seleccionarID;
        private System.Windows.Forms.ComboBox seleccionarFabricante;
        private System.Windows.Forms.TextBox seleccionarModelo;
        private System.Windows.Forms.Button buscarListado;
        private System.Windows.Forms.DataGridView listadoCruceros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINAS;

    }
}