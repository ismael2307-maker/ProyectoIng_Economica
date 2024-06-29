namespace ProyectoIng_Economica
{
    partial class FrmPerpetua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerpetua));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgDefincion = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbgCalculo = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvResultadoresPerpetuos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLimpiarPerpetuo = new System.Windows.Forms.Button();
            this.btnCalcularPerpetuo = new System.Windows.Forms.Button();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorAnualidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbgDefincion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbgCalculo.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoresPerpetuos)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgDefincion);
            this.tabControl1.Controls.Add(this.tbgCalculo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgDefincion
            // 
            this.tbgDefincion.Controls.Add(this.pictureBox1);
            this.tbgDefincion.Location = new System.Drawing.Point(4, 31);
            this.tbgDefincion.Name = "tbgDefincion";
            this.tbgDefincion.Padding = new System.Windows.Forms.Padding(3);
            this.tbgDefincion.Size = new System.Drawing.Size(1150, 633);
            this.tbgDefincion.TabIndex = 0;
            this.tbgDefincion.Text = "Definicion";
            this.tbgDefincion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1144, 627);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbgCalculo
            // 
            this.tbgCalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgCalculo.Controls.Add(this.panel6);
            this.tbgCalculo.Controls.Add(this.panel5);
            this.tbgCalculo.Controls.Add(this.panel4);
            this.tbgCalculo.Location = new System.Drawing.Point(4, 31);
            this.tbgCalculo.Name = "tbgCalculo";
            this.tbgCalculo.Padding = new System.Windows.Forms.Padding(3);
            this.tbgCalculo.Size = new System.Drawing.Size(1150, 633);
            this.tbgCalculo.TabIndex = 1;
            this.tbgCalculo.Text = "Calculo";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.dgvResultadoresPerpetuos);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(537, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(621, 350);
            this.panel6.TabIndex = 12;
            // 
            // dgvResultadoresPerpetuos
            // 
            this.dgvResultadoresPerpetuos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvResultadoresPerpetuos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadoresPerpetuos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoresPerpetuos.Location = new System.Drawing.Point(66, 105);
            this.dgvResultadoresPerpetuos.Name = "dgvResultadoresPerpetuos";
            this.dgvResultadoresPerpetuos.Size = new System.Drawing.Size(506, 150);
            this.dgvResultadoresPerpetuos.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label9.Location = new System.Drawing.Point(239, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 39);
            this.label9.TabIndex = 12;
            this.label9.Text = "Resultados";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.txtPeriodo);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnLimpiarPerpetuo);
            this.panel5.Controls.Add(this.btnCalcularPerpetuo);
            this.panel5.Controls.Add(this.txtTasaInteres);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtValorAnualidad);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(8, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(523, 350);
            this.panel5.TabIndex = 11;
            // 
            // btnLimpiarPerpetuo
            // 
            this.btnLimpiarPerpetuo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarPerpetuo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiarPerpetuo.FlatAppearance.BorderSize = 0;
            this.btnLimpiarPerpetuo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPerpetuo.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarPerpetuo.Location = new System.Drawing.Point(277, 262);
            this.btnLimpiarPerpetuo.Name = "btnLimpiarPerpetuo";
            this.btnLimpiarPerpetuo.Size = new System.Drawing.Size(102, 33);
            this.btnLimpiarPerpetuo.TabIndex = 11;
            this.btnLimpiarPerpetuo.Text = "Limpiar";
            this.btnLimpiarPerpetuo.UseVisualStyleBackColor = false;
            this.btnLimpiarPerpetuo.Click += new System.EventHandler(this.btnLimpiarPerpetuo_Click);
            // 
            // btnCalcularPerpetuo
            // 
            this.btnCalcularPerpetuo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcularPerpetuo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalcularPerpetuo.FlatAppearance.BorderSize = 0;
            this.btnCalcularPerpetuo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPerpetuo.ForeColor = System.Drawing.Color.White;
            this.btnCalcularPerpetuo.Location = new System.Drawing.Point(110, 262);
            this.btnCalcularPerpetuo.Name = "btnCalcularPerpetuo";
            this.btnCalcularPerpetuo.Size = new System.Drawing.Size(102, 33);
            this.btnCalcularPerpetuo.TabIndex = 10;
            this.btnCalcularPerpetuo.Text = "Calcular";
            this.btnCalcularPerpetuo.UseVisualStyleBackColor = false;
            this.btnCalcularPerpetuo.Click += new System.EventHandler(this.btnCalcularPerpetuo_Click);
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTasaInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaInteres.ForeColor = System.Drawing.Color.White;
            this.txtTasaInteres.Location = new System.Drawing.Point(189, 136);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(123, 24);
            this.txtTasaInteres.TabIndex = 7;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteres_KeyPress);
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
            // txtValorAnualidad
            // 
            this.txtValorAnualidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorAnualidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtValorAnualidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorAnualidad.ForeColor = System.Drawing.Color.White;
            this.txtValorAnualidad.Location = new System.Drawing.Point(190, 70);
            this.txtValorAnualidad.Name = "txtValorAnualidad";
            this.txtValorAnualidad.Size = new System.Drawing.Size(123, 24);
            this.txtValorAnualidad.TabIndex = 5;
            this.txtValorAnualidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPresente_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor Anualidad";
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
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(333, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 200);
            this.panel4.TabIndex = 9;
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
            this.pictureBox2.Location = new System.Drawing.Point(66, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriodo.ForeColor = System.Drawing.Color.White;
            this.txtPeriodo.Location = new System.Drawing.Point(189, 207);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(123, 24);
            this.txtPeriodo.TabIndex = 13;
            // 
            // FrmPerpetua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 668);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPerpetua";
            this.Text = "FrmPerpetua";
            this.tabControl1.ResumeLayout(false);
            this.tbgDefincion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbgCalculo.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoresPerpetuos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgDefincion;
        private System.Windows.Forms.TabPage tbgCalculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLimpiarPerpetuo;
        private System.Windows.Forms.Button btnCalcularPerpetuo;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorAnualidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvResultadoresPerpetuos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label1;
    }
}