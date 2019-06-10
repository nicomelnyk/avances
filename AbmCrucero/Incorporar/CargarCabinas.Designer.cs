namespace FrbaCrucero
{
    partial class CargarCabinas
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
            this.cargarCab = new System.Windows.Forms.GroupBox();
            this.pisoCabina = new System.Windows.Forms.Label();
            this.nroCabina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoCab = new System.Windows.Forms.ComboBox();
            this.modelo = new System.Windows.Forms.Label();
            this.Finalizar = new System.Windows.Forms.Button();
            this.cargar_cabinas = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.piso = new System.Windows.Forms.Label();
            this.nro = new System.Windows.Forms.Label();
            this.cabPiso = new System.Windows.Forms.Label();
            this.cargarCab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cargarCab
            // 
            this.cargarCab.Controls.Add(this.cabPiso);
            this.cargarCab.Controls.Add(this.pisoCabina);
            this.cargarCab.Controls.Add(this.nroCabina);
            this.cargarCab.Controls.Add(this.label1);
            this.cargarCab.Controls.Add(this.tipoCab);
            this.cargarCab.Controls.Add(this.modelo);
            this.cargarCab.Controls.Add(this.Finalizar);
            this.cargarCab.Controls.Add(this.cargar_cabinas);
            this.cargarCab.Controls.Add(this.limpiar);
            this.cargarCab.Controls.Add(this.piso);
            this.cargarCab.Controls.Add(this.nro);
            this.cargarCab.Location = new System.Drawing.Point(12, 12);
            this.cargarCab.Name = "cargarCab";
            this.cargarCab.Size = new System.Drawing.Size(358, 229);
            this.cargarCab.TabIndex = 1;
            this.cargarCab.TabStop = false;
            this.cargarCab.Text = "Cargar Cabinas";
            // 
            // pisoCabina
            // 
            this.pisoCabina.AutoSize = true;
            this.pisoCabina.Location = new System.Drawing.Point(299, 72);
            this.pisoCabina.Name = "pisoCabina";
            this.pisoCabina.Size = new System.Drawing.Size(16, 17);
            this.pisoCabina.TabIndex = 14;
            this.pisoCabina.Text = "1";
            // 
            // nroCabina
            // 
            this.nroCabina.AutoSize = true;
            this.nroCabina.Location = new System.Drawing.Point(159, 72);
            this.nroCabina.Name = "nroCabina";
            this.nroCabina.Size = new System.Drawing.Size(16, 17);
            this.nroCabina.TabIndex = 13;
            this.nroCabina.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "   Dado nuestro diseño, se cargaran \r\nautomaticamente 10 cabinas por piso";
            // 
            // tipoCab
            // 
            this.tipoCab.FormattingEnabled = true;
            this.tipoCab.Items.AddRange(new object[] {
            "Cabina Exterior",
            "Ejecutivo",
            "Cabina estandar",
            "Suite",
            "Cabina Balcón"});
            this.tipoCab.Location = new System.Drawing.Point(104, 105);
            this.tipoCab.Name = "tipoCab";
            this.tipoCab.Size = new System.Drawing.Size(196, 24);
            this.tipoCab.TabIndex = 11;
            this.tipoCab.SelectedIndexChanged += new System.EventHandler(this.tipoCab_SelectedIndexChanged);
            // 
            // modelo
            // 
            this.modelo.AutoSize = true;
            this.modelo.Location = new System.Drawing.Point(58, 108);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(40, 17);
            this.modelo.TabIndex = 10;
            this.modelo.Text = "Tipo:";
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(250, 142);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(76, 66);
            this.Finalizar.TabIndex = 8;
            this.Finalizar.Text = "Finalizar Carga";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // cargar_cabinas
            // 
            this.cargar_cabinas.Location = new System.Drawing.Point(38, 178);
            this.cargar_cabinas.Name = "cargar_cabinas";
            this.cargar_cabinas.Size = new System.Drawing.Size(184, 30);
            this.cargar_cabinas.TabIndex = 5;
            this.cargar_cabinas.Text = "CARGAR OTRA CABINA";
            this.cargar_cabinas.UseVisualStyleBackColor = true;
            this.cargar_cabinas.Click += new System.EventHandler(this.cargar_cabinas_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(38, 142);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(184, 30);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(0, 0);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(100, 23);
            this.piso.TabIndex = 15;
            // 
            // nro
            // 
            this.nro.AutoSize = true;
            this.nro.Location = new System.Drawing.Point(33, 72);
            this.nro.Name = "nro";
            this.nro.Size = new System.Drawing.Size(128, 17);
            this.nro.TabIndex = 0;
            this.nro.Text = "Número de cabina:";
            // 
            // cabPiso
            // 
            this.cabPiso.AutoSize = true;
            this.cabPiso.Location = new System.Drawing.Point(217, 72);
            this.cabPiso.Name = "cabPiso";
            this.cabPiso.Size = new System.Drawing.Size(85, 17);
            this.cabPiso.TabIndex = 16;
            this.cabPiso.Text = "Piso cabina:";
            // 
            // CargarCabinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.cargarCab);
            this.Name = "CargarCabinas";
            this.Text = "UTN FRBA";
            this.cargarCab.ResumeLayout(false);
            this.cargarCab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cargarCab;
        private System.Windows.Forms.Label modelo;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.Button cargar_cabinas;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label piso;
        private System.Windows.Forms.Label nro;
        private System.Windows.Forms.ComboBox tipoCab;
        private System.Windows.Forms.Label pisoCabina;
        private System.Windows.Forms.Label nroCabina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cabPiso;
    }
}