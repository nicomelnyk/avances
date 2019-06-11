namespace FrbaCrucero
{
    partial class IncorporarCrucero
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
            this.crear_rol = new System.Windows.Forms.GroupBox();
            this.fabricanteCru = new System.Windows.Forms.ComboBox();
            this.modeloCru = new System.Windows.Forms.TextBox();
            this.modelo = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            this.cargar_cabinas = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nombreID = new System.Windows.Forms.TextBox();
            this.fabricante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crear_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // crear_rol
            // 
            this.crear_rol.Controls.Add(this.label1);
            this.crear_rol.Controls.Add(this.fabricanteCru);
            this.crear_rol.Controls.Add(this.modeloCru);
            this.crear_rol.Controls.Add(this.modelo);
            this.crear_rol.Controls.Add(this.Atras);
            this.crear_rol.Controls.Add(this.cargar_cabinas);
            this.crear_rol.Controls.Add(this.limpiar);
            this.crear_rol.Controls.Add(this.nombreID);
            this.crear_rol.Controls.Add(this.fabricante);
            this.crear_rol.Location = new System.Drawing.Point(12, 12);
            this.crear_rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crear_rol.Name = "crear_rol";
            this.crear_rol.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crear_rol.Size = new System.Drawing.Size(357, 229);
            this.crear_rol.TabIndex = 0;
            this.crear_rol.TabStop = false;
            this.crear_rol.Text = "Incorporar Cru";
            // 
            // fabricanteCru
            // 
            this.fabricanteCru.FormattingEnabled = true;
            this.fabricanteCru.Items.AddRange(new object[] {
            "P&O Cruises",
            "Costa Cruises",
            "fathom Cruise Line",
            "Holland America Line",
            "P&O Cruises Australia",
            "Princess Cruises",
            "AIDA Cruises",
            "Seaboum Cruise Line",
            "Cunard Line",
            "Carnival Cruise Lines"});
            this.fabricanteCru.Location = new System.Drawing.Point(120, 58);
            this.fabricanteCru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fabricanteCru.Name = "fabricanteCru";
            this.fabricanteCru.Size = new System.Drawing.Size(196, 24);
            this.fabricanteCru.TabIndex = 12;
            this.fabricanteCru.SelectedIndexChanged += new System.EventHandler(this.fabricanteCru_SelectedIndexChanged);
            // 
            // modeloCru
            // 
            this.modeloCru.Location = new System.Drawing.Point(120, 89);
            this.modeloCru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeloCru.Name = "modeloCru";
            this.modeloCru.Size = new System.Drawing.Size(196, 22);
            this.modeloCru.TabIndex = 11;
            // 
            // modelo
            // 
            this.modelo.AutoSize = true;
            this.modelo.Location = new System.Drawing.Point(56, 89);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(58, 17);
            this.modelo.TabIndex = 10;
            this.modelo.Text = "Modelo:";
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(45, 143);
            this.Atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 66);
            this.Atras.TabIndex = 8;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // cargar_cabinas
            // 
            this.cargar_cabinas.Location = new System.Drawing.Point(147, 178);
            this.cargar_cabinas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cargar_cabinas.Name = "cargar_cabinas";
            this.cargar_cabinas.Size = new System.Drawing.Size(157, 30);
            this.cargar_cabinas.TabIndex = 5;
            this.cargar_cabinas.Text = "CARGAR CABINAS";
            this.cargar_cabinas.UseVisualStyleBackColor = true;
            this.cargar_cabinas.Click += new System.EventHandler(this.guardar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(147, 143);
            this.limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(157, 30);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // nombreID
            // 
            this.nombreID.Location = new System.Drawing.Point(120, 30);
            this.nombreID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreID.Name = "nombreID";
            this.nombreID.Size = new System.Drawing.Size(196, 22);
            this.nombreID.TabIndex = 3;
            this.nombreID.TextChanged += new System.EventHandler(this.nombreID_TextChanged);
            // 
            // fabricante
            // 
            this.fabricante.AutoSize = true;
            this.fabricante.Location = new System.Drawing.Point(35, 58);
            this.fabricante.Name = "fabricante";
            this.fabricante.Size = new System.Drawing.Size(79, 17);
            this.fabricante.TabIndex = 1;
            this.fabricante.Text = "Fabricante:";
            this.fabricante.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Crucero:";
            // 
            // IncorporarCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 254);
            this.Controls.Add(this.crear_rol);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IncorporarCrucero";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.crear_rol.ResumeLayout(false);
            this.crear_rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox crear_rol;
        //private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label fabricante;
        private System.Windows.Forms.Button cargar_cabinas;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox nombreID;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.TextBox modeloCru;
        private System.Windows.Forms.Label modelo;
        private System.Windows.Forms.ComboBox fabricanteCru;
        private System.Windows.Forms.Label label1;
    }
}