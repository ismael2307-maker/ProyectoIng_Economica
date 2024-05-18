namespace ProyectoIng_Economica
{
    partial class FrmIntSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntSimple));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgDefinicion = new System.Windows.Forms.TabPage();
            this.tbgFuturoAcumulado = new System.Windows.Forms.TabPage();
            this.tbgPresenteAcumulado = new System.Windows.Forms.TabPage();
            this.tbgInteresAcumulado = new System.Windows.Forms.TabPage();
            this.tbgPeriodoAcumulado = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbPeriodoF = new System.Windows.Forms.ComboBox();
            this.cmbInteresF = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPeriodoF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTasaInteresF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorPresenteF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgvResultadosF = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbgDefinicion.SuspendLayout();
            this.tbgFuturoAcumulado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultadosF)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgDefinicion);
            this.tabControl1.Controls.Add(this.tbgFuturoAcumulado);
            this.tabControl1.Controls.Add(this.tbgPresenteAcumulado);
            this.tabControl1.Controls.Add(this.tbgInteresAcumulado);
            this.tabControl1.Controls.Add(this.tbgPeriodoAcumulado);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgDefinicion
            // 
            this.tbgDefinicion.BackColor = System.Drawing.Color.White;
            this.tbgDefinicion.Controls.Add(this.pictureBox1);
            this.tbgDefinicion.Location = new System.Drawing.Point(4, 31);
            this.tbgDefinicion.Name = "tbgDefinicion";
            this.tbgDefinicion.Padding = new System.Windows.Forms.Padding(3);
            this.tbgDefinicion.Size = new System.Drawing.Size(1092, 577);
            this.tbgDefinicion.TabIndex = 0;
            this.tbgDefinicion.Text = "Definición";
            // 
            // tbgFuturoAcumulado
            // 
            this.tbgFuturoAcumulado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgFuturoAcumulado.Controls.Add(this.panel6);
            this.tbgFuturoAcumulado.Controls.Add(this.panel5);
            this.tbgFuturoAcumulado.Controls.Add(this.panel4);
            this.tbgFuturoAcumulado.Location = new System.Drawing.Point(4, 31);
            this.tbgFuturoAcumulado.Name = "tbgFuturoAcumulado";
            this.tbgFuturoAcumulado.Padding = new System.Windows.Forms.Padding(3);
            this.tbgFuturoAcumulado.Size = new System.Drawing.Size(1092, 577);
            this.tbgFuturoAcumulado.TabIndex = 1;
            this.tbgFuturoAcumulado.Text = "Futuro";
            // 
            // tbgPresenteAcumulado
            // 
            this.tbgPresenteAcumulado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgPresenteAcumulado.Location = new System.Drawing.Point(4, 31);
            this.tbgPresenteAcumulado.Name = "tbgPresenteAcumulado";
            this.tbgPresenteAcumulado.Size = new System.Drawing.Size(1092, 577);
            this.tbgPresenteAcumulado.TabIndex = 2;
            this.tbgPresenteAcumulado.Text = "Presente";
            // 
            // tbgInteresAcumulado
            // 
            this.tbgInteresAcumulado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgInteresAcumulado.Location = new System.Drawing.Point(4, 31);
            this.tbgInteresAcumulado.Name = "tbgInteresAcumulado";
            this.tbgInteresAcumulado.Size = new System.Drawing.Size(1092, 577);
            this.tbgInteresAcumulado.TabIndex = 3;
            this.tbgInteresAcumulado.Text = "Interés";
            // 
            // tbgPeriodoAcumulado
            // 
            this.tbgPeriodoAcumulado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgPeriodoAcumulado.Location = new System.Drawing.Point(4, 31);
            this.tbgPeriodoAcumulado.Name = "tbgPeriodoAcumulado";
            this.tbgPeriodoAcumulado.Size = new System.Drawing.Size(1092, 577);
            this.tbgPeriodoAcumulado.TabIndex = 4;
            this.tbgPeriodoAcumulado.Text = "Periodo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 571);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(340, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 200);
            this.panel4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(163, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ecuación ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(79, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.cmbPeriodoF);
            this.panel5.Controls.Add(this.cmbInteresF);
            this.panel5.Controls.Add(this.btnLimpiar);
            this.panel5.Controls.Add(this.btnCalcular);
            this.panel5.Controls.Add(this.txtPeriodoF);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtTasaInteresF);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtValorPresenteF);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(8, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(523, 327);
            this.panel5.TabIndex = 9;
            // 
            // cmbPeriodoF
            // 
            this.cmbPeriodoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodoF.FormattingEnabled = true;
            this.cmbPeriodoF.Items.AddRange(new object[] {
            "Años",
            "Meses"});
            this.cmbPeriodoF.Location = new System.Drawing.Point(359, 197);
            this.cmbPeriodoF.Name = "cmbPeriodoF";
            this.cmbPeriodoF.Size = new System.Drawing.Size(121, 30);
            this.cmbPeriodoF.TabIndex = 13;
            // 
            // cmbInteresF
            // 
            this.cmbInteresF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteresF.FormattingEnabled = true;
            this.cmbInteresF.Items.AddRange(new object[] {
            "Anual",
            "Mensual"});
            this.cmbInteresF.Location = new System.Drawing.Point(359, 133);
            this.cmbInteresF.Name = "cmbInteresF";
            this.cmbInteresF.Size = new System.Drawing.Size(121, 30);
            this.cmbInteresF.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(264, 275);
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
            this.btnCalcular.Location = new System.Drawing.Point(103, 275);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 33);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPeriodoF
            // 
            this.txtPeriodoF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriodoF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPeriodoF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriodoF.ForeColor = System.Drawing.Color.White;
            this.txtPeriodoF.Location = new System.Drawing.Point(190, 203);
            this.txtPeriodoF.Name = "txtPeriodoF";
            this.txtPeriodoF.Size = new System.Drawing.Size(123, 24);
            this.txtPeriodoF.TabIndex = 9;
            this.txtPeriodoF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodoF_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Periodo";
            // 
            // txtTasaInteresF
            // 
            this.txtTasaInteresF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTasaInteresF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtTasaInteresF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaInteresF.ForeColor = System.Drawing.Color.White;
            this.txtTasaInteresF.Location = new System.Drawing.Point(189, 136);
            this.txtTasaInteresF.Name = "txtTasaInteresF";
            this.txtTasaInteresF.Size = new System.Drawing.Size(123, 24);
            this.txtTasaInteresF.TabIndex = 7;
            this.txtTasaInteresF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteresF_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tasa interés";
            // 
            // txtValorPresenteF
            // 
            this.txtValorPresenteF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorPresenteF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtValorPresenteF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorPresenteF.ForeColor = System.Drawing.Color.White;
            this.txtValorPresenteF.Location = new System.Drawing.Point(190, 70);
            this.txtValorPresenteF.Name = "txtValorPresenteF";
            this.txtValorPresenteF.Size = new System.Drawing.Size(123, 24);
            this.txtValorPresenteF.TabIndex = 5;
            this.txtValorPresenteF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPresenteF_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor Presente";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label8.Location = new System.Drawing.Point(103, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ingresa los datos";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.dtgvResultadosF);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(561, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(523, 327);
            this.panel6.TabIndex = 10;
            // 
            // dtgvResultadosF
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            this.dtgvResultadosF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvResultadosF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgvResultadosF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResultadosF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvResultadosF.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvResultadosF.GridColor = System.Drawing.Color.White;
            this.dtgvResultadosF.Location = new System.Drawing.Point(45, 77);
            this.dtgvResultadosF.Name = "dtgvResultadosF";
            this.dtgvResultadosF.Size = new System.Drawing.Size(445, 185);
            this.dtgvResultadosF.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Valor Presente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Interes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Futuro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label9.Location = new System.Drawing.Point(174, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 39);
            this.label9.TabIndex = 12;
            this.label9.Text = "Resultados";
            // 
            // FrmIntSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIntSimple";
            this.Text = "FrmIntSimple";
            this.tabControl1.ResumeLayout(false);
            this.tbgDefinicion.ResumeLayout(false);
            this.tbgFuturoAcumulado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultadosF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgDefinicion;
        private System.Windows.Forms.TabPage tbgFuturoAcumulado;
        private System.Windows.Forms.TabPage tbgPresenteAcumulado;
        private System.Windows.Forms.TabPage tbgInteresAcumulado;
        private System.Windows.Forms.TabPage tbgPeriodoAcumulado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dtgvResultadosF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbPeriodoF;
        private System.Windows.Forms.ComboBox cmbInteresF;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPeriodoF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTasaInteresF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPresenteF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}