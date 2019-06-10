namespace FrbaCrucero
{
    partial class Rol
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
            this.RolBase = new System.Windows.Forms.GroupBox();
            this.eliminar_rol = new System.Windows.Forms.Button();
            this.modificar_rol = new System.Windows.Forms.Button();
            this.crear_rol = new System.Windows.Forms.Button();
            this.RolBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // RolBase
            // 
            this.RolBase.Controls.Add(this.eliminar_rol);
            this.RolBase.Controls.Add(this.modificar_rol);
            this.RolBase.Controls.Add(this.crear_rol);
            this.RolBase.Location = new System.Drawing.Point(13, 13);
            this.RolBase.Name = "RolBase";
            this.RolBase.Size = new System.Drawing.Size(357, 228);
            this.RolBase.TabIndex = 0;
            this.RolBase.TabStop = false;
            this.RolBase.Text = "Rol";
            // 
            // eliminar_rol
            // 
            this.eliminar_rol.Location = new System.Drawing.Point(60, 162);
            this.eliminar_rol.Name = "eliminar_rol";
            this.eliminar_rol.Size = new System.Drawing.Size(250, 51);
            this.eliminar_rol.TabIndex = 2;
            this.eliminar_rol.Text = "ELIMINAR ROL";
            this.eliminar_rol.UseVisualStyleBackColor = true;
            this.eliminar_rol.Click += new System.EventHandler(this.eliminar_rol_Click);
            // 
            // modificar_rol
            // 
            this.modificar_rol.Location = new System.Drawing.Point(60, 93);
            this.modificar_rol.Name = "modificar_rol";
            this.modificar_rol.Size = new System.Drawing.Size(250, 54);
            this.modificar_rol.TabIndex = 1;
            this.modificar_rol.Text = "MODIFICAR ROL";
            this.modificar_rol.UseVisualStyleBackColor = true;
            this.modificar_rol.Click += new System.EventHandler(this.modificar_rol_Click);
            // 
            // crear_rol
            // 
            this.crear_rol.Location = new System.Drawing.Point(60, 21);
            this.crear_rol.Name = "crear_rol";
            this.crear_rol.Size = new System.Drawing.Size(250, 56);
            this.crear_rol.TabIndex = 0;
            this.crear_rol.Text = "CREAR ROL";
            this.crear_rol.UseVisualStyleBackColor = true;
            this.crear_rol.Click += new System.EventHandler(this.crear_rol_Click);
            // 
            // Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.RolBase);
            this.Name = "Rol";
            this.Text = "UTN FRBA";
            this.RolBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RolBase;
        private System.Windows.Forms.Button eliminar_rol;
        private System.Windows.Forms.Button modificar_rol;
        private System.Windows.Forms.Button crear_rol;
    }
}