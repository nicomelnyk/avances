namespace FrbaCrucero
{
    partial class GeneracionViaje
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tramos = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listadoCruceros = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABINAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tramos);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.calendario);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listadoCruceros);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 615);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generación Viaje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(592, 547);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(286, 52);
            this.button5.TabIndex = 33;
            this.button5.Text = "GENERAR VIAJE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(286, 576);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "FECHAS AGREGADAS CORRECTAMENTE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Seleccione el código del recorrido";
            // 
            // tramos
            // 
            this.tramos.FormattingEnabled = true;
            this.tramos.Location = new System.Drawing.Point(625, 491);
            this.tramos.Name = "tramos";
            this.tramos.Size = new System.Drawing.Size(186, 24);
            this.tramos.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 549);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 26;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(286, 348);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 25;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 42);
            this.button3.TabIndex = 23;
            this.button3.Text = "ESCOGER FECHA DE LLEGADA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 42);
            this.button2.TabIndex = 22;
            this.button2.Text = "ESCOGER FECHA DE SALIDA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seleccione el crucero destinado para el viaje:";
            // 
            // listadoCruceros
            // 
            this.listadoCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoCruceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MARCA_DESC,
            this.MODELO,
            this.MARCA_ID,
            this.ESTADO,
            this.CABINAS});
            this.listadoCruceros.Location = new System.Drawing.Point(6, 66);
            this.listadoCruceros.Name = "listadoCruceros";
            this.listadoCruceros.RowTemplate.Height = 24;
            this.listadoCruceros.Size = new System.Drawing.Size(904, 254);
            this.listadoCruceros.TabIndex = 19;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // MARCA_DESC
            // 
            this.MARCA_DESC.HeaderText = "MARCA_DESC";
            this.MARCA_DESC.Name = "MARCA_DESC";
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            // 
            // MARCA_ID
            // 
            this.MARCA_ID.HeaderText = "MARCA_ID";
            this.MARCA_ID.Name = "MARCA_ID";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // CABINAS
            // 
            this.CABINAS.HeaderText = "CABINAS";
            this.CABINAS.Name = "CABINAS";
            // 
            // GeneracionViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 639);
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneracionViaje";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.QuitarFuncionalidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCruceros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listadoCruceros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINAS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox tramos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}