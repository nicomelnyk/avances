namespace FrbaCrucero
{
    partial class ListadoRol
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
            this.listadoRoles = new System.Windows.Forms.DataGridView();
            this.NOMBRE_ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limpiarListadoRol = new System.Windows.Forms.Button();
            this.buscarListadoRol = new System.Windows.Forms.Button();
            this.rolTipo = new System.Windows.Forms.TextBox();
            this.modificarListadoRol = new System.Windows.Forms.Button();
            this.atrasListadoRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoRoles
            // 
            this.listadoRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE_ROL,
            this.ESTADO_ROL});
            this.listadoRoles.Location = new System.Drawing.Point(12, 116);
            this.listadoRoles.Name = "listadoRoles";
            this.listadoRoles.RowTemplate.Height = 24;
            this.listadoRoles.Size = new System.Drawing.Size(758, 281);
            this.listadoRoles.TabIndex = 29;
            this.listadoRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoCruceros_CellContentClick);
            // 
            // NOMBRE_ROL
            // 
            this.NOMBRE_ROL.HeaderText = "NOMBRE_ROL";
            this.NOMBRE_ROL.Name = "NOMBRE_ROL";
            // 
            // ESTADO_ROL
            // 
            this.ESTADO_ROL.HeaderText = "ESTADO_ROL";
            this.ESTADO_ROL.Name = "ESTADO_ROL";
            // 
            // limpiarListadoRol
            // 
            this.limpiarListadoRol.Location = new System.Drawing.Point(482, 40);
            this.limpiarListadoRol.Name = "limpiarListadoRol";
            this.limpiarListadoRol.Size = new System.Drawing.Size(115, 40);
            this.limpiarListadoRol.TabIndex = 21;
            this.limpiarListadoRol.Text = "LIMPIAR";
            this.limpiarListadoRol.UseVisualStyleBackColor = true;
            this.limpiarListadoRol.Click += new System.EventHandler(this.limpiarListadoRol_Click);
            // 
            // buscarListadoRol
            // 
            this.buscarListadoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarListadoRol.Location = new System.Drawing.Point(619, 42);
            this.buscarListadoRol.Name = "buscarListadoRol";
            this.buscarListadoRol.Size = new System.Drawing.Size(115, 37);
            this.buscarListadoRol.TabIndex = 28;
            this.buscarListadoRol.Text = "CARGAR\r\n";
            this.buscarListadoRol.UseVisualStyleBackColor = true;
            this.buscarListadoRol.Click += new System.EventHandler(this.buscarListadoRol_Click);
            // 
            // rolTipo
            // 
            this.rolTipo.Location = new System.Drawing.Point(109, 49);
            this.rolTipo.Name = "rolTipo";
            this.rolTipo.Size = new System.Drawing.Size(239, 22);
            this.rolTipo.TabIndex = 25;
            // 
            // modificarListadoRol
            // 
            this.modificarListadoRol.Location = new System.Drawing.Point(643, 412);
            this.modificarListadoRol.Name = "modificarListadoRol";
            this.modificarListadoRol.Size = new System.Drawing.Size(127, 30);
            this.modificarListadoRol.TabIndex = 22;
            this.modificarListadoRol.Text = "SELECCIONAR";
            this.modificarListadoRol.UseVisualStyleBackColor = true;
            this.modificarListadoRol.Click += new System.EventHandler(this.modificarListadoRol_Click);
            // 
            // atrasListadoRol
            // 
            this.atrasListadoRol.Location = new System.Drawing.Point(12, 412);
            this.atrasListadoRol.Name = "atrasListadoRol";
            this.atrasListadoRol.Size = new System.Drawing.Size(58, 28);
            this.atrasListadoRol.TabIndex = 23;
            this.atrasListadoRol.Text = "Atrás";
            this.atrasListadoRol.UseVisualStyleBackColor = true;
            this.atrasListadoRol.Click += new System.EventHandler(this.atrasListadoRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtrar por el nombre del Rol:";
            // 
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.listadoRoles);
            this.Controls.Add(this.limpiarListadoRol);
            this.Controls.Add(this.buscarListadoRol);
            this.Controls.Add(this.rolTipo);
            this.Controls.Add(this.modificarListadoRol);
            this.Controls.Add(this.atrasListadoRol);
            this.Controls.Add(this.label1);
            this.Name = "ListadoRol";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.ListadoRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoRoles;
        private System.Windows.Forms.Button limpiarListadoRol;
        private System.Windows.Forms.Button buscarListadoRol;
        private System.Windows.Forms.TextBox rolTipo;
        private System.Windows.Forms.Button modificarListadoRol;
        private System.Windows.Forms.Button atrasListadoRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_ROL;
    }
}