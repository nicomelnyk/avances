namespace FrbaCrucero
{
    partial class BajaFin
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
            this.bajaf = new System.Windows.Forms.GroupBox();
            this.otro_baj = new System.Windows.Forms.Button();
            this.iniciobaj = new System.Windows.Forms.Button();
            this.bj = new System.Windows.Forms.Label();
            this.bajaf.SuspendLayout();
            this.SuspendLayout();
            // 
            // bajaf
            // 
            this.bajaf.Controls.Add(this.otro_baj);
            this.bajaf.Controls.Add(this.iniciobaj);
            this.bajaf.Controls.Add(this.bj);
            this.bajaf.Location = new System.Drawing.Point(13, 12);
            this.bajaf.Name = "bajaf";
            this.bajaf.Size = new System.Drawing.Size(357, 228);
            this.bajaf.TabIndex = 2;
            this.bajaf.TabStop = false;
            this.bajaf.Text = "Crucero dado de baja";
            // 
            // otro_baj
            // 
            this.otro_baj.Location = new System.Drawing.Point(196, 114);
            this.otro_baj.Name = "otro_baj";
            this.otro_baj.Size = new System.Drawing.Size(134, 50);
            this.otro_baj.TabIndex = 2;
            this.otro_baj.Text = "Dar de baja otro crucero";
            this.otro_baj.UseVisualStyleBackColor = true;
            this.otro_baj.Click += new System.EventHandler(this.otro_baj_Click);
            // 
            // iniciobaj
            // 
            this.iniciobaj.Location = new System.Drawing.Point(37, 114);
            this.iniciobaj.Name = "iniciobaj";
            this.iniciobaj.Size = new System.Drawing.Size(129, 50);
            this.iniciobaj.TabIndex = 1;
            this.iniciobaj.Text = "Volver al inicio";
            this.iniciobaj.UseVisualStyleBackColor = true;
            this.iniciobaj.Click += new System.EventHandler(this.iniciobaj_Click);
            // 
            // bj
            // 
            this.bj.AutoSize = true;
            this.bj.Location = new System.Drawing.Point(79, 68);
            this.bj.Name = "bj";
            this.bj.Size = new System.Drawing.Size(186, 34);
            this.bj.TabIndex = 0;
            this.bj.Text = "         El crucero se ha \r\ndado de baja correctamente";
            // 
            // BajaFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.bajaf);
            this.Name = "BajaFin";
            this.Text = "UTN FRBA";
            this.bajaf.ResumeLayout(false);
            this.bajaf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bajaf;
        private System.Windows.Forms.Button otro_baj;
        private System.Windows.Forms.Button iniciobaj;
        private System.Windows.Forms.Label bj;
    }
}