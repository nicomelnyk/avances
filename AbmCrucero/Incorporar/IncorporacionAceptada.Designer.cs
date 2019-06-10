namespace FrbaCrucero
{
    partial class IncorporacionAceptada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.otro_cru = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.otro_cru);
            this.groupBox1.Controls.Add(this.inicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crucero guardado";
            // 
            // otro_cru
            // 
            this.otro_cru.Location = new System.Drawing.Point(196, 114);
            this.otro_cru.Name = "otro_cru";
            this.otro_cru.Size = new System.Drawing.Size(134, 50);
            this.otro_cru.TabIndex = 2;
            this.otro_cru.Text = "Incorporar otro crucero";
            this.otro_cru.UseVisualStyleBackColor = true;
            this.otro_cru.Click += new System.EventHandler(this.otro_cru_Click);
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(37, 114);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(129, 50);
            this.inicio.TabIndex = 1;
            this.inicio.Text = "Volver al inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "    El crucero se ha \r\ncreado correctamente";
            // 
            // CargarCabinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "CargarCabinas";
            this.Text = "UTN FRBA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button otro_cru;
    }
}