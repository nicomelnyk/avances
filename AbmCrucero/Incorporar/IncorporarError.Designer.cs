namespace FrbaCrucero
{
    partial class IncorporarError
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
            this.cruceroError = new System.Windows.Forms.GroupBox();
            this.volver_cru = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cruceroError.SuspendLayout();
            this.SuspendLayout();
            // 
            // cruceroError
            // 
            this.cruceroError.Controls.Add(this.volver_cru);
            this.cruceroError.Controls.Add(this.label1);
            this.cruceroError.Location = new System.Drawing.Point(13, 12);
            this.cruceroError.Name = "cruceroError";
            this.cruceroError.Size = new System.Drawing.Size(357, 228);
            this.cruceroError.TabIndex = 2;
            this.cruceroError.TabStop = false;
            this.cruceroError.Text = "Error crucero";
            // 
            // volver_cru
            // 
            this.volver_cru.Location = new System.Drawing.Point(110, 120);
            this.volver_cru.Name = "volver_cru";
            this.volver_cru.Size = new System.Drawing.Size(149, 53);
            this.volver_cru.TabIndex = 2;
            this.volver_cru.Text = "Volver a incorporar crucero";
            this.volver_cru.UseVisualStyleBackColor = true;
            this.volver_cru.Click += new System.EventHandler(this.volver_cru_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Los datos del crucero cargados \r\n     no son compatibles con\r\n       nuestra base" +
    " de datos";
            // 
            // IncorporarError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.cruceroError);
            this.Name = "IncorporarError";
            this.Text = "UTN FRBA";
            this.cruceroError.ResumeLayout(false);
            this.cruceroError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cruceroError;
        private System.Windows.Forms.Button volver_cru;
        private System.Windows.Forms.Label label1;
    }
}