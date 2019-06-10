namespace FrbaCrucero
{
    partial class LoginAdministrativo
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
            this.loginYSeguridad = new System.Windows.Forms.GroupBox();
            this.ingresar = new System.Windows.Forms.Button();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.loginYSeguridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginYSeguridad
            // 
            this.loginYSeguridad.Controls.Add(this.limpiar);
            this.loginYSeguridad.Controls.Add(this.ingresar);
            this.loginYSeguridad.Controls.Add(this.contraseña);
            this.loginYSeguridad.Controls.Add(this.usuario);
            this.loginYSeguridad.Controls.Add(this.label2);
            this.loginYSeguridad.Controls.Add(this.label1);
            this.loginYSeguridad.Location = new System.Drawing.Point(12, 12);
            this.loginYSeguridad.Name = "loginYSeguridad";
            this.loginYSeguridad.Size = new System.Drawing.Size(263, 202);
            this.loginYSeguridad.TabIndex = 0;
            this.loginYSeguridad.TabStop = false;
            this.loginYSeguridad.Text = "Login y Seguridad";
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(163, 161);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(75, 23);
            this.ingresar.TabIndex = 4;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(109, 109);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 3;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(109, 53);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 2;
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(32, 160);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 5;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // LoginAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 226);
            this.Controls.Add(this.loginYSeguridad);
            this.Name = "LoginAdministrativo";
            this.Text = "LoginAdministrativo";
            this.Load += new System.EventHandler(this.LoginAdministrativo_Load);
            this.loginYSeguridad.ResumeLayout(false);
            this.loginYSeguridad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginYSeguridad;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Button limpiar;
    }
}