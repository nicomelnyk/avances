namespace FrbaCrucero
{
    partial class ModificarRol
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
            this.modificar_rol = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.Listadoxfunc = new System.Windows.Forms.DataGridView();
            this.NOMBRE_ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONALIDAD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONALIDAD_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nuevaFunc = new System.Windows.Forms.ComboBox();
            this.tipo_funcionalidad = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.nuevoNombre = new System.Windows.Forms.TextBox();
            this.modificar_rol.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listadoxfunc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificar_rol
            // 
            this.modificar_rol.Controls.Add(this.groupBox4);
            this.modificar_rol.Controls.Add(this.groupBox3);
            this.modificar_rol.Controls.Add(this.groupBox2);
            this.modificar_rol.Controls.Add(this.groupBox1);
            this.modificar_rol.Controls.Add(this.label1);
            this.modificar_rol.Controls.Add(this.Atras);
            this.modificar_rol.Controls.Add(this.nombre);
            this.modificar_rol.Location = new System.Drawing.Point(13, 13);
            this.modificar_rol.Name = "modificar_rol";
            this.modificar_rol.Size = new System.Drawing.Size(763, 636);
            this.modificar_rol.TabIndex = 0;
            this.modificar_rol.TabStop = false;
            this.modificar_rol.Text = "Modificar Rol";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(26, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(713, 81);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Volver a habilitar Rol";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "VOLVER A HABILITAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.Listadoxfunc);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(26, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 266);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quitar funcionalidad";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(562, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 83);
            this.button6.TabIndex = 2;
            this.button6.Text = "BUSCAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Listadoxfunc
            // 
            this.Listadoxfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listadoxfunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE_ROL,
            this.FUNCIONALIDAD_ID,
            this.FUNCIONALIDAD_DESC});
            this.Listadoxfunc.Location = new System.Drawing.Point(18, 30);
            this.Listadoxfunc.Name = "Listadoxfunc";
            this.Listadoxfunc.RowTemplate.Height = 24;
            this.Listadoxfunc.Size = new System.Drawing.Size(524, 184);
            this.Listadoxfunc.TabIndex = 1;
            this.Listadoxfunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listadoxfunc_CellContentClick);
            // 
            // NOMBRE_ROL
            // 
            this.NOMBRE_ROL.HeaderText = "NOMBRE_ROL";
            this.NOMBRE_ROL.Name = "NOMBRE_ROL";
            // 
            // FUNCIONALIDAD_ID
            // 
            this.FUNCIONALIDAD_ID.HeaderText = "FUNCIONALIDAD_ID";
            this.FUNCIONALIDAD_ID.Name = "FUNCIONALIDAD_ID";
            // 
            // FUNCIONALIDAD_DESC
            // 
            this.FUNCIONALIDAD_DESC.HeaderText = "FUNCIONALIDAD_DESC";
            this.FUNCIONALIDAD_DESC.Name = "FUNCIONALIDAD_DESC";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 83);
            this.button4.TabIndex = 0;
            this.button4.Text = "QUITAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nuevaFunc);
            this.groupBox2.Controls.Add(this.tipo_funcionalidad);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(26, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 80);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar funcionalidad";
            // 
            // nuevaFunc
            // 
            this.nuevaFunc.FormattingEnabled = true;
            this.nuevaFunc.Items.AddRange(new object[] {
            "AbmRol",
            "AbmCrucero",
            "AbmPuerto",
            "AbmRecorrido",
            "ComprarReservaPasaje",
            "GeneracionViaje",
            "ListadoEstadistico",
            "PagoReserva"});
            this.nuevaFunc.Location = new System.Drawing.Point(231, 28);
            this.nuevaFunc.Name = "nuevaFunc";
            this.nuevaFunc.Size = new System.Drawing.Size(249, 24);
            this.nuevaFunc.TabIndex = 16;
            // 
            // tipo_funcionalidad
            // 
            this.tipo_funcionalidad.AutoSize = true;
            this.tipo_funcionalidad.Location = new System.Drawing.Point(55, 33);
            this.tipo_funcionalidad.Name = "tipo_funcionalidad";
            this.tipo_funcionalidad.Size = new System.Drawing.Size(141, 17);
            this.tipo_funcionalidad.TabIndex = 15;
            this.tipo_funcionalidad.Text = "Nueva funcionalidad:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(530, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 41);
            this.button5.TabIndex = 2;
            this.button5.Text = "CARGAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevoNombre);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 75);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "CARGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ingrese el nuevo nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seleccione qué desea hacer con este rol:";
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(9, 599);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 31);
            this.Atras.TabIndex = 22;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(0, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 23);
            this.nombre.TabIndex = 23;
            // 
            // nuevoNombre
            // 
            this.nuevoNombre.Location = new System.Drawing.Point(231, 33);
            this.nuevoNombre.Name = "nuevoNombre";
            this.nuevoNombre.Size = new System.Drawing.Size(249, 22);
            this.nuevoNombre.TabIndex = 29;
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.modificar_rol);
            this.Name = "ModificarRol";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.ModificarRol_Load);
            this.modificar_rol.ResumeLayout(false);
            this.modificar_rol.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Listadoxfunc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modificar_rol;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Listadoxfunc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox nuevaFunc;
        private System.Windows.Forms.Label tipo_funcionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONALIDAD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONALIDAD_DESC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nuevoNombre;
    }
}