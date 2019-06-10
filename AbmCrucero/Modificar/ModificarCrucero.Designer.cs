namespace FrbaCrucero
{
    partial class ModificarCrucero
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
            this.modificarCru = new System.Windows.Forms.GroupBox();
            this.fabricanteModif = new System.Windows.Forms.ComboBox();
            this.fabricanteMod = new System.Windows.Forms.Label();
            this.atrasMod = new System.Windows.Forms.Button();
            this.modificarCruc = new System.Windows.Forms.Button();
            this.limpiarMod = new System.Windows.Forms.Button();
            this.modificarCru.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificarCru
            // 
            this.modificarCru.Controls.Add(this.fabricanteModif);
            this.modificarCru.Controls.Add(this.fabricanteMod);
            this.modificarCru.Controls.Add(this.atrasMod);
            this.modificarCru.Controls.Add(this.modificarCruc);
            this.modificarCru.Controls.Add(this.limpiarMod);
            this.modificarCru.Location = new System.Drawing.Point(12, 12);
            this.modificarCru.Name = "modificarCru";
            this.modificarCru.Size = new System.Drawing.Size(358, 229);
            this.modificarCru.TabIndex = 2;
            this.modificarCru.TabStop = false;
            this.modificarCru.Text = "Modificar Crucero";
            // 
            // fabricanteModif
            // 
            this.fabricanteModif.FormattingEnabled = true;
            this.fabricanteModif.Items.AddRange(new object[] {
            "P&O Cruises",
            "Costa Cruises",
            "fathom Cruise Line",
            "Holland America Line",
            "P&O Cruises Australia",
            "Princess Cruises",
            "AIDA Cruises",
            "Seaboum Cruise Line",
            "Cunard Line",
            "Carnival Cruise Lines"});
            this.fabricanteModif.Location = new System.Drawing.Point(79, 71);
            this.fabricanteModif.Name = "fabricanteModif";
            this.fabricanteModif.Size = new System.Drawing.Size(196, 24);
            this.fabricanteModif.TabIndex = 14;
            this.fabricanteModif.SelectedIndexChanged += new System.EventHandler(this.fabricanteModif_SelectedIndexChanged);
            // 
            // fabricanteMod
            // 
            this.fabricanteMod.AutoSize = true;
            this.fabricanteMod.Location = new System.Drawing.Point(77, 51);
            this.fabricanteMod.Name = "fabricanteMod";
            this.fabricanteMod.Size = new System.Drawing.Size(198, 17);
            this.fabricanteMod.TabIndex = 13;
            this.fabricanteMod.Text = "Seleccione la nueva empresa:";
            // 
            // atrasMod
            // 
            this.atrasMod.Location = new System.Drawing.Point(49, 134);
            this.atrasMod.Name = "atrasMod";
            this.atrasMod.Size = new System.Drawing.Size(76, 66);
            this.atrasMod.TabIndex = 8;
            this.atrasMod.Text = "Atrás";
            this.atrasMod.UseVisualStyleBackColor = true;
            this.atrasMod.Click += new System.EventHandler(this.atrasMod_Click);
            // 
            // modificarCruc
            // 
            this.modificarCruc.Location = new System.Drawing.Point(150, 170);
            this.modificarCruc.Name = "modificarCruc";
            this.modificarCruc.Size = new System.Drawing.Size(157, 30);
            this.modificarCruc.TabIndex = 5;
            this.modificarCruc.Text = "MODIFICAR";
            this.modificarCruc.UseVisualStyleBackColor = true;
            this.modificarCruc.Click += new System.EventHandler(this.modificarCruc_Click);
            // 
            // limpiarMod
            // 
            this.limpiarMod.Location = new System.Drawing.Point(150, 134);
            this.limpiarMod.Name = "limpiarMod";
            this.limpiarMod.Size = new System.Drawing.Size(157, 30);
            this.limpiarMod.TabIndex = 4;
            this.limpiarMod.Text = "LIMPIAR";
            this.limpiarMod.UseVisualStyleBackColor = true;
            this.limpiarMod.Click += new System.EventHandler(this.limpiarMod_Click);
            // 
            // ModificarCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.modificarCru);
            this.Name = "ModificarCrucero";
            this.Text = "UTN FRBA";
            this.modificarCru.ResumeLayout(false);
            this.modificarCru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modificarCru;
        private System.Windows.Forms.Button atrasMod;
        private System.Windows.Forms.Button modificarCruc;
        private System.Windows.Forms.Button limpiarMod;
        private System.Windows.Forms.ComboBox fabricanteModif;
        private System.Windows.Forms.Label fabricanteMod;
    }
}