namespace FrbaCrucero
{
    partial class BajaSeleccionarFecha
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
            this.FechaBaja = new System.Windows.Forms.GroupBox();
            this.seleccionarFecha = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // FechaBaja
            // 
            this.FechaBaja.Controls.Add(this.button1);
            this.FechaBaja.Controls.Add(this.seleccionarFecha);
            this.FechaBaja.Controls.Add(this.monthCalendar1);
            this.FechaBaja.Location = new System.Drawing.Point(12, 12);
            this.FechaBaja.Name = "FechaBaja";
            this.FechaBaja.Size = new System.Drawing.Size(364, 238);
            this.FechaBaja.TabIndex = 3;
            this.FechaBaja.TabStop = false;
            this.FechaBaja.Text = "SeleccionarFecha";
            // 
            // seleccionarFecha
            // 
            this.seleccionarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionarFecha.Location = new System.Drawing.Point(314, 22);
            this.seleccionarFecha.Name = "seleccionarFecha";
            this.seleccionarFecha.Size = new System.Drawing.Size(37, 156);
            this.seleccionarFecha.TabIndex = 1;
            this.seleccionarFecha.Text = "S\r\nE\r\nL\r\nE\r\nC\r\nC\r\nI\r\nO\r\nN\r\nA\r\nR";
            this.seleccionarFecha.UseVisualStyleBackColor = true;
            this.seleccionarFecha.Click += new System.EventHandler(this.seleccionarFecha_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 22);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "ATRAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BajaSeleccionarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.FechaBaja);
            this.Name = "BajaSeleccionarFecha";
            this.Text = "UTN FRBA";
            this.FechaBaja.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FechaBaja;
        private System.Windows.Forms.Button seleccionarFecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
    }
}