namespace FrbaCrucero
{
    partial class CrearRol
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
            this.Atras = new System.Windows.Forms.Button();
            this.funcionalidadesC = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nombreC = new System.Windows.Forms.TextBox();
            this.tipo_funcionalidad = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.crear_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // crear_rol
            // 
            this.crear_rol.Controls.Add(this.Atras);
            this.crear_rol.Controls.Add(this.funcionalidadesC);
            this.crear_rol.Controls.Add(this.buscar);
            this.crear_rol.Controls.Add(this.limpiar);
            this.crear_rol.Controls.Add(this.nombreC);
            this.crear_rol.Controls.Add(this.tipo_funcionalidad);
            this.crear_rol.Controls.Add(this.nombre);
            this.crear_rol.Location = new System.Drawing.Point(12, 12);
            this.crear_rol.Name = "crear_rol";
            this.crear_rol.Size = new System.Drawing.Size(358, 229);
            this.crear_rol.TabIndex = 1;
            this.crear_rol.TabStop = false;
            this.crear_rol.Text = "Crear Rol";
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(50, 140);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 66);
            this.Atras.TabIndex = 15;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // funcionalidadesC
            // 
            this.funcionalidadesC.FormattingEnabled = true;
            this.funcionalidadesC.Items.AddRange(new object[] {
            "AbmRol",
            "AbmCrucero",
            "AbmPuerto",
            "AbmRecorrido",
            "ComprarReservaPasaje",
            "GeneracionViaje",
            "ListadoEstadistico",
            "PagoReserva"});
            this.funcionalidadesC.Location = new System.Drawing.Point(87, 97);
            this.funcionalidadesC.Name = "funcionalidadesC";
            this.funcionalidadesC.Size = new System.Drawing.Size(181, 24);
            this.funcionalidadesC.TabIndex = 14;
            this.funcionalidadesC.SelectedIndexChanged += new System.EventHandler(this.funcionalidadesE_SelectedIndexChanged);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(151, 176);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(157, 30);
            this.buscar.TabIndex = 13;
            this.buscar.Text = "CARGAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(151, 140);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(157, 30);
            this.limpiar.TabIndex = 12;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // nombreC
            // 
            this.nombreC.Location = new System.Drawing.Point(87, 42);
            this.nombreC.Name = "nombreC";
            this.nombreC.Size = new System.Drawing.Size(181, 22);
            this.nombreC.TabIndex = 11;
            // 
            // tipo_funcionalidad
            // 
            this.tipo_funcionalidad.AutoSize = true;
            this.tipo_funcionalidad.Location = new System.Drawing.Point(110, 77);
            this.tipo_funcionalidad.Name = "tipo_funcionalidad";
            this.tipo_funcionalidad.Size = new System.Drawing.Size(143, 17);
            this.tipo_funcionalidad.TabIndex = 10;
            this.tipo_funcionalidad.Text = "Funcionalidad del rol:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(110, 22);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(148, 17);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "Nombre del nuevo rol:";
            // 
            // CrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.crear_rol);
            this.Name = "CrearRol";
            this.Text = "UTN FRBA";
            this.crear_rol.ResumeLayout(false);
            this.crear_rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox crear_rol;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox nombreC;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.ComboBox funcionalidadesC;
        private System.Windows.Forms.Label tipo_funcionalidad;

    }
}