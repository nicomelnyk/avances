namespace FrbaCrucero
{
    partial class Crucero
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
            this.CruceroBase = new System.Windows.Forms.GroupBox();
            this.baja_crucero = new System.Windows.Forms.Button();
            this.modificar_crucero = new System.Windows.Forms.Button();
            this.incorporar_crucero = new System.Windows.Forms.Button();
            this.CruceroBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // CruceroBase
            // 
            this.CruceroBase.Controls.Add(this.baja_crucero);
            this.CruceroBase.Controls.Add(this.modificar_crucero);
            this.CruceroBase.Controls.Add(this.incorporar_crucero);
            this.CruceroBase.Location = new System.Drawing.Point(13, 12);
            this.CruceroBase.Name = "CruceroBase";
            this.CruceroBase.Size = new System.Drawing.Size(357, 228);
            this.CruceroBase.TabIndex = 1;
            this.CruceroBase.TabStop = false;
            this.CruceroBase.Text = "Crucero";
            // 
            // baja_crucero
            // 
            this.baja_crucero.Location = new System.Drawing.Point(60, 162);
            this.baja_crucero.Name = "baja_crucero";
            this.baja_crucero.Size = new System.Drawing.Size(250, 51);
            this.baja_crucero.TabIndex = 2;
            this.baja_crucero.Text = "DAR DE BAJA CRUCERO";
            this.baja_crucero.UseVisualStyleBackColor = true;
            this.baja_crucero.Click += new System.EventHandler(this.baja_crucero_Click);
            // 
            // modificar_crucero
            // 
            this.modificar_crucero.Location = new System.Drawing.Point(60, 93);
            this.modificar_crucero.Name = "modificar_crucero";
            this.modificar_crucero.Size = new System.Drawing.Size(250, 54);
            this.modificar_crucero.TabIndex = 1;
            this.modificar_crucero.Text = "MODIFICAR CRUCERO";
            this.modificar_crucero.UseVisualStyleBackColor = true;
            this.modificar_crucero.Click += new System.EventHandler(this.modificar_crucero_Click);
            // 
            // incorporar_crucero
            // 
            this.incorporar_crucero.Location = new System.Drawing.Point(60, 21);
            this.incorporar_crucero.Name = "incorporar_crucero";
            this.incorporar_crucero.Size = new System.Drawing.Size(250, 56);
            this.incorporar_crucero.TabIndex = 0;
            this.incorporar_crucero.Text = "INCORPORAR CRUCERO";
            this.incorporar_crucero.UseVisualStyleBackColor = true;
            this.incorporar_crucero.Click += new System.EventHandler(this.incorporar_crucero_Click);
            // 
            // FinModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.CruceroBase);
            this.Name = "FinModificar";
            this.Text = "UTN FRBA";
            this.CruceroBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CruceroBase;
        private System.Windows.Forms.Button baja_crucero;
        private System.Windows.Forms.Button modificar_crucero;
        private System.Windows.Forms.Button incorporar_crucero;
    }
}