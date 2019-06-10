namespace FrbaCrucero
{
    partial class BajaError
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
            this.bajError = new System.Windows.Forms.GroupBox();
            this.volver_baja = new System.Windows.Forms.Button();
            this.errorBja = new System.Windows.Forms.Label();
            this.bajError.SuspendLayout();
            this.SuspendLayout();
            // 
            // bajError
            // 
            this.bajError.Controls.Add(this.volver_baja);
            this.bajError.Controls.Add(this.errorBja);
            this.bajError.Location = new System.Drawing.Point(13, 12);
            this.bajError.Name = "bajError";
            this.bajError.Size = new System.Drawing.Size(357, 228);
            this.bajError.TabIndex = 3;
            this.bajError.TabStop = false;
            this.bajError.Text = "Error fecha";
            // 
            // volver_baja
            // 
            this.volver_baja.Location = new System.Drawing.Point(110, 120);
            this.volver_baja.Name = "volver_baja";
            this.volver_baja.Size = new System.Drawing.Size(149, 53);
            this.volver_baja.TabIndex = 2;
            this.volver_baja.Text = "Volver a seleccionar\r\n la fecha";
            this.volver_baja.UseVisualStyleBackColor = true;
            this.volver_baja.Click += new System.EventHandler(this.volver_baja_Click);
            // 
            // errorBja
            // 
            this.errorBja.AutoSize = true;
            this.errorBja.Location = new System.Drawing.Point(84, 56);
            this.errorBja.Name = "errorBja";
            this.errorBja.Size = new System.Drawing.Size(200, 51);
            this.errorBja.TabIndex = 0;
            this.errorBja.Text = "Los datos de la fecha cargada\r\n     no son compatibles con\r\n       nuestra base d" +
    "e datos";
            // 
            // BajaError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.bajError);
            this.Name = "BajaError";
            this.Text = "UTN FRBA";
            this.bajError.ResumeLayout(false);
            this.bajError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bajError;
        private System.Windows.Forms.Button volver_baja;
        private System.Windows.Forms.Label errorBja;
    }
}