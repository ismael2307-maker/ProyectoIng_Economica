namespace ProyectoIng_Economica
{
    partial class FrmInteresAcumulado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInteresAcumulado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlEcuacionInteres = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlComceptoInteres = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPeriodoAcumulado = new System.Windows.Forms.ComboBox();
            this.cmbInteresAcumulado = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.txtValorPresente = new System.Windows.Forms.TextBox();
            this.lblValorPresente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvResultados = new System.Windows.Forms.DataGridView();
            this.columnaValorPresente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTasaInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlEcuacionInteres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlComceptoInteres.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pnlComceptoInteres);
            this.groupBox1.Controls.Add(this.pnlEcuacionInteres);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 612);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interés";
            // 
            // pnlEcuacionInteres
            // 
            this.pnlEcuacionInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlEcuacionInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlEcuacionInteres.Controls.Add(this.label1);
            this.pnlEcuacionInteres.Controls.Add(this.pictureBox1);
            this.pnlEcuacionInteres.Location = new System.Drawing.Point(6, 30);
            this.pnlEcuacionInteres.Name = "pnlEcuacionInteres";
            this.pnlEcuacionInteres.Size = new System.Drawing.Size(537, 237);
            this.pnlEcuacionInteres.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ecuación ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlComceptoInteres
            // 
            this.pnlComceptoInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlComceptoInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlComceptoInteres.Controls.Add(this.richTextBox1);
            this.pnlComceptoInteres.Controls.Add(this.label2);
            this.pnlComceptoInteres.Location = new System.Drawing.Point(557, 30);
            this.pnlComceptoInteres.Name = "pnlComceptoInteres";
            this.pnlComceptoInteres.Size = new System.Drawing.Size(537, 237);
            this.pnlComceptoInteres.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(14, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 129);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Es el costo que se paga por el uso del dinero \nprestado o el rendimiento que se o" +
    "btiene por \ndepositar dinero en una cuenta de ahorros o \ninversión.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Qué es el Interés?";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.cmbPeriodoAcumulado);
            this.panel1.Controls.Add(this.cmbInteresAcumulado);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtPeriodo);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.txtTasaInteres);
            this.panel1.Controls.Add(this.lblInteres);
            this.panel1.Controls.Add(this.txtValorPresente);
            this.panel1.Controls.Add(this.lblValorPresente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 327);
            this.panel1.TabIndex = 7;
            // 
            // cmbPeriodoAcumulado
            // 
            this.cmbPeriodoAcumulado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodoAcumulado.FormattingEnabled = true;
            this.cmbPeriodoAcumulado.Items.AddRange(new object[] {
            "Años",
            "Meses"});
            this.cmbPeriodoAcumulado.Location = new System.Drawing.Point(359, 197);
            this.cmbPeriodoAcumulado.Name = "cmbPeriodoAcumulado";
            this.cmbPeriodoAcumulado.Size = new System.Drawing.Size(121, 30);
            this.cmbPeriodoAcumulado.TabIndex = 13;
            // 
            // cmbInteresAcumulado
            // 
            this.cmbInteresAcumulado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteresAcumulado.FormattingEnabled = true;
            this.cmbInteresAcumulado.Items.AddRange(new object[] {
            "Anual",
            "Mensual"});
            this.cmbInteresAcumulado.Location = new System.Drawing.Point(359, 133);
            this.cmbInteresAcumulado.Name = "cmbInteresAcumulado";
            this.cmbInteresAcumulado.Size = new System.Drawing.Size(121, 30);
            this.cmbInteresAcumulado.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(271, 275);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 33);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(110, 275);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 33);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriodo.ForeColor = System.Drawing.Color.White;
            this.txtPeriodo.Location = new System.Drawing.Point(197, 203);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(123, 24);
            this.txtPeriodo.TabIndex = 9;
            this.txtPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodo_KeyPress);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(16, 201);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(87, 24);
            this.lblPeriodo.TabIndex = 8;
            this.lblPeriodo.Text = "Periodo";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTasaInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaInteres.ForeColor = System.Drawing.Color.White;
            this.txtTasaInteres.Location = new System.Drawing.Point(196, 136);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(123, 24);
            this.txtTasaInteres.TabIndex = 7;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteres_KeyPress);
            // 
            // lblInteres
            // 
            this.lblInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.ForeColor = System.Drawing.Color.White;
            this.lblInteres.Location = new System.Drawing.Point(16, 136);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(125, 24);
            this.lblInteres.TabIndex = 6;
            this.lblInteres.Text = "Tasa interés";
            // 
            // txtValorPresente
            // 
            this.txtValorPresente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorPresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtValorPresente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorPresente.ForeColor = System.Drawing.Color.White;
            this.txtValorPresente.Location = new System.Drawing.Point(197, 70);
            this.txtValorPresente.Name = "txtValorPresente";
            this.txtValorPresente.Size = new System.Drawing.Size(123, 24);
            this.txtValorPresente.TabIndex = 5;
            this.txtValorPresente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPresente_KeyPress);
            // 
            // lblValorPresente
            // 
            this.lblValorPresente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorPresente.AutoSize = true;
            this.lblValorPresente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPresente.ForeColor = System.Drawing.Color.White;
            this.lblValorPresente.Location = new System.Drawing.Point(16, 68);
            this.lblValorPresente.Name = "lblValorPresente";
            this.lblValorPresente.Size = new System.Drawing.Size(158, 24);
            this.lblValorPresente.TabIndex = 4;
            this.lblValorPresente.Text = "Valor Presente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresa los datos";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.dtgvResultados);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(557, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 327);
            this.panel2.TabIndex = 8;
            // 
            // dtgvResultados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dtgvResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaValorPresente,
            this.ColumnaInteres,
            this.ColumnaPeriodo,
            this.ColumnaTasaInteres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvResultados.GridColor = System.Drawing.Color.White;
            this.dtgvResultados.Location = new System.Drawing.Point(45, 77);
            this.dtgvResultados.Name = "dtgvResultados";
            this.dtgvResultados.Size = new System.Drawing.Size(445, 185);
            this.dtgvResultados.TabIndex = 13;
            // 
            // columnaValorPresente
            // 
            this.columnaValorPresente.HeaderText = "Valor Presente";
            this.columnaValorPresente.Name = "columnaValorPresente";
            // 
            // ColumnaInteres
            // 
            this.ColumnaInteres.HeaderText = "Interes";
            this.ColumnaInteres.Name = "ColumnaInteres";
            // 
            // ColumnaPeriodo
            // 
            this.ColumnaPeriodo.HeaderText = "Periodo";
            this.ColumnaPeriodo.Name = "ColumnaPeriodo";
            // 
            // ColumnaTasaInteres
            // 
            this.ColumnaTasaInteres.HeaderText = "Tasa Interés";
            this.ColumnaTasaInteres.Name = "ColumnaTasaInteres";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Resultados";
            // 
            // FrmInteresAcumulado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInteresAcumulado";
            this.Text = "FrmInteresAcumulado";
            this.groupBox1.ResumeLayout(false);
            this.pnlEcuacionInteres.ResumeLayout(false);
            this.pnlEcuacionInteres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlComceptoInteres.ResumeLayout(false);
            this.pnlComceptoInteres.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlComceptoInteres;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEcuacionInteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPeriodoAcumulado;
        private System.Windows.Forms.ComboBox cmbInteresAcumulado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.TextBox txtValorPresente;
        private System.Windows.Forms.Label lblValorPresente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaValorPresente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTasaInteres;
        private System.Windows.Forms.Label label4;
    }
}