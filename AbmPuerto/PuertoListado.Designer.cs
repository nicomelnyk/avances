namespace FrbaCrucero
{
    partial class PuertoListado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listadoPuertos = new System.Windows.Forms.DataGridView();
            this.seleccionarID = new System.Windows.Forms.TextBox();
            this.seleccionarNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PUERTO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_PUERTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_PUERTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtrar por nombre: ";
            // 
            // listadoPuertos
            // 
            this.listadoPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoPuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PUERTO_ID,
            this.NOMBRE_PUERTO,
            this.ESTADO_PUERTO});
            this.listadoPuertos.Location = new System.Drawing.Point(12, 136);
            this.listadoPuertos.Name = "listadoPuertos";
            this.listadoPuertos.Size = new System.Drawing.Size(457, 150);
            this.listadoPuertos.TabIndex = 2;
            this.listadoPuertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoPuertos_CellContentClick);
            // 
            // seleccionarID
            // 
            this.seleccionarID.Location = new System.Drawing.Point(144, 37);
            this.seleccionarID.Name = "seleccionarID";
            this.seleccionarID.Size = new System.Drawing.Size(133, 20);
            this.seleccionarID.TabIndex = 3;
            // 
            // seleccionarNombre
            // 
            this.seleccionarNombre.Location = new System.Drawing.Point(144, 83);
            this.seleccionarNombre.Name = "seleccionarNombre";
            this.seleccionarNombre.Size = new System.Drawing.Size(133, 20);
            this.seleccionarNombre.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cargar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Atras";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Continuar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PUERTO_ID
            // 
            this.PUERTO_ID.HeaderText = "PUERTO_ID";
            this.PUERTO_ID.Name = "PUERTO_ID";
            // 
            // NOMBRE_PUERTO
            // 
            this.NOMBRE_PUERTO.HeaderText = "NOMBRE_PUERTO";
            this.NOMBRE_PUERTO.Name = "NOMBRE_PUERTO";
            // 
            // ESTADO_PUERTO
            // 
            this.ESTADO_PUERTO.HeaderText = "ESTADO_PUERTO";
            this.ESTADO_PUERTO.Name = "ESTADO_PUERTO";
            // 
            // PuertoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 332);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seleccionarNombre);
            this.Controls.Add(this.seleccionarID);
            this.Controls.Add(this.listadoPuertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PuertoListado";
            this.Text = "PuertoListado";
            ((System.ComponentModel.ISupportInitialize)(this.listadoPuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listadoPuertos;
        private System.Windows.Forms.TextBox seleccionarID;
        private System.Windows.Forms.TextBox seleccionarNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUERTO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PUERTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_PUERTO;
    }
}