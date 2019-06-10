namespace FrbaCrucero
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginYSeguridad = new System.Windows.Forms.GroupBox();
            this.continuar = new System.Windows.Forms.Button();
            this.seleccionarRol = new System.Windows.Forms.Label();
            this.seleccionRol = new System.Windows.Forms.ComboBox();
            this.loginYSeguridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginYSeguridad
            // 
            this.loginYSeguridad.Controls.Add(this.continuar);
            this.loginYSeguridad.Controls.Add(this.seleccionarRol);
            this.loginYSeguridad.Controls.Add(this.seleccionRol);
            this.loginYSeguridad.Location = new System.Drawing.Point(16, 15);
            this.loginYSeguridad.Margin = new System.Windows.Forms.Padding(4);
            this.loginYSeguridad.Name = "loginYSeguridad";
            this.loginYSeguridad.Padding = new System.Windows.Forms.Padding(4);
            this.loginYSeguridad.Size = new System.Drawing.Size(331, 236);
            this.loginYSeguridad.TabIndex = 1;
            this.loginYSeguridad.TabStop = false;
            this.loginYSeguridad.Text = "Login y Seguridad";
            this.loginYSeguridad.Enter += new System.EventHandler(this.loginYSeguridad_Enter);
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(192, 181);
            this.continuar.Margin = new System.Windows.Forms.Padding(4);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(100, 28);
            this.continuar.TabIndex = 2;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // seleccionarRol
            // 
            this.seleccionarRol.AutoSize = true;
            this.seleccionarRol.Location = new System.Drawing.Point(28, 46);
            this.seleccionarRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seleccionarRol.Name = "seleccionarRol";
            this.seleccionarRol.Size = new System.Drawing.Size(120, 17);
            this.seleccionarRol.TabIndex = 1;
            this.seleccionarRol.Text = "Seleccione su rol:";
            // 
            // seleccionRol
            // 
            this.seleccionRol.FormattingEnabled = true;
            this.seleccionRol.Items.AddRange(new object[] {
            "Administrativo",
            "Cliente"});
            this.seleccionRol.Location = new System.Drawing.Point(81, 105);
            this.seleccionRol.Margin = new System.Windows.Forms.Padding(4);
            this.seleccionRol.Name = "seleccionRol";
            this.seleccionRol.Size = new System.Drawing.Size(160, 24);
            this.seleccionRol.TabIndex = 0;
            this.seleccionRol.SelectedIndexChanged += new System.EventHandler(this.seleccionRol_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 266);
            this.Controls.Add(this.loginYSeguridad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginYSeguridad.ResumeLayout(false);
            this.loginYSeguridad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginYSeguridad;
        private System.Windows.Forms.Label seleccionarRol;
        private System.Windows.Forms.ComboBox seleccionRol;
        private System.Windows.Forms.Button continuar;

    }
}

