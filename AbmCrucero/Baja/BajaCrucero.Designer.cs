namespace FrbaCrucero
{
    partial class BajaCrucero
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
            this.BajaCru = new System.Windows.Forms.GroupBox();
            this.fuera_servicio = new System.Windows.Forms.Button();
            this.baja_definitiva = new System.Windows.Forms.Button();
            this.atrasBaja = new System.Windows.Forms.Button();
            this.BajaCru.SuspendLayout();
            this.SuspendLayout();
            // 
            // BajaCru
            // 
            this.BajaCru.Controls.Add(this.atrasBaja);
            this.BajaCru.Controls.Add(this.fuera_servicio);
            this.BajaCru.Controls.Add(this.baja_definitiva);
            this.BajaCru.Location = new System.Drawing.Point(12, 12);
            this.BajaCru.Name = "BajaCru";
            this.BajaCru.Size = new System.Drawing.Size(358, 229);
            this.BajaCru.TabIndex = 2;
            this.BajaCru.TabStop = false;
            this.BajaCru.Text = "Baja Crucero";
            // 
            // fuera_servicio
            // 
            this.fuera_servicio.Location = new System.Drawing.Point(66, 99);
            this.fuera_servicio.Name = "fuera_servicio";
            this.fuera_servicio.Size = new System.Drawing.Size(224, 49);
            this.fuera_servicio.TabIndex = 1;
            this.fuera_servicio.Text = "FUERA DE SERVICIO";
            this.fuera_servicio.UseVisualStyleBackColor = true;
            this.fuera_servicio.Click += new System.EventHandler(this.fuera_servicio_Click);
            // 
            // baja_definitiva
            // 
            this.baja_definitiva.Location = new System.Drawing.Point(66, 34);
            this.baja_definitiva.Name = "baja_definitiva";
            this.baja_definitiva.Size = new System.Drawing.Size(224, 50);
            this.baja_definitiva.TabIndex = 0;
            this.baja_definitiva.Text = "COMPLETÓ VIDA ÚTIL";
            this.baja_definitiva.UseVisualStyleBackColor = true;
            this.baja_definitiva.Click += new System.EventHandler(this.baja_definitiva_Click);
            // 
            // atrasBaja
            // 
            this.atrasBaja.Location = new System.Drawing.Point(66, 165);
            this.atrasBaja.Name = "atrasBaja";
            this.atrasBaja.Size = new System.Drawing.Size(224, 49);
            this.atrasBaja.TabIndex = 9;
            this.atrasBaja.Text = "Atrás";
            this.atrasBaja.UseVisualStyleBackColor = true;
            this.atrasBaja.Click += new System.EventHandler(this.Atras_Click);
            // 
            // BajaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.BajaCru);
            this.Name = "BajaCrucero";
            this.Text = "UTN FRBA";
            this.BajaCru.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BajaCru;
        private System.Windows.Forms.Button fuera_servicio;
        private System.Windows.Forms.Button baja_definitiva;
        private System.Windows.Forms.Button atrasBaja;

    }
}