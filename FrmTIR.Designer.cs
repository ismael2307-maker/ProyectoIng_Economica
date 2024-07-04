namespace ProyectoIng_Economica
{
    partial class FrmTIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTIR));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgDefinicion = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbgCalculo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatosTIR = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarTIR = new System.Windows.Forms.Button();
            this.btnCalCularTIR = new System.Windows.Forms.Button();
            this.txtInt2TIR = new System.Windows.Forms.TextBox();
            this.txtInt1Tir = new System.Windows.Forms.TextBox();
            this.txtVpn2TIR = new System.Windows.Forms.TextBox();
            this.txtVpn1TIR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbgDefinicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbgCalculo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTIR)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgDefinicion);
            this.tabControl1.Controls.Add(this.tbgCalculo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 640);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgDefinicion
            // 
            this.tbgDefinicion.Controls.Add(this.pictureBox1);
            this.tbgDefinicion.Location = new System.Drawing.Point(4, 31);
            this.tbgDefinicion.Name = "tbgDefinicion";
            this.tbgDefinicion.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbgDefinicion.Size = new System.Drawing.Size(1032, 605);
            this.tbgDefinicion.TabIndex = 0;
            this.tbgDefinicion.Text = "Definición";
            this.tbgDefinicion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbgCalculo
            // 
            this.tbgCalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgCalculo.Controls.Add(this.panel1);
            this.tbgCalculo.Controls.Add(this.panel11);
            this.tbgCalculo.Controls.Add(this.panel4);
            this.tbgCalculo.Location = new System.Drawing.Point(4, 31);
            this.tbgCalculo.Name = "tbgCalculo";
            this.tbgCalculo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbgCalculo.Size = new System.Drawing.Size(1032, 605);
            this.tbgCalculo.TabIndex = 1;
            this.tbgCalculo.Text = "Calculo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dgvDatosTIR);
            this.panel1.Location = new System.Drawing.Point(522, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 353);
            this.panel1.TabIndex = 17;
            // 
            // dgvDatosTIR
            // 
            this.dgvDatosTIR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosTIR.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDatosTIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosTIR.Location = new System.Drawing.Point(28, 36);
            this.dgvDatosTIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatosTIR.Name = "dgvDatosTIR";
            this.dgvDatosTIR.RowHeadersWidth = 51;
            this.dgvDatosTIR.RowTemplate.Height = 24;
            this.dgvDatosTIR.Size = new System.Drawing.Size(513, 297);
            this.dgvDatosTIR.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.btnLimpiarTIR);
            this.panel11.Controls.Add(this.btnCalCularTIR);
            this.panel11.Controls.Add(this.txtInt2TIR);
            this.panel11.Controls.Add(this.txtInt1Tir);
            this.panel11.Controls.Add(this.txtVpn2TIR);
            this.panel11.Controls.Add(this.txtVpn1TIR);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Location = new System.Drawing.Point(-56, 244);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(572, 353);
            this.panel11.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(250, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(250, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(241, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(241, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "$";
            // 
            // btnLimpiarTIR
            // 
            this.btnLimpiarTIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLimpiarTIR.Location = new System.Drawing.Point(426, 309);
            this.btnLimpiarTIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarTIR.Name = "btnLimpiarTIR";
            this.btnLimpiarTIR.Size = new System.Drawing.Size(124, 54);
            this.btnLimpiarTIR.TabIndex = 16;
            this.btnLimpiarTIR.Text = "Limpiar";
            this.btnLimpiarTIR.UseVisualStyleBackColor = false;
            this.btnLimpiarTIR.Click += new System.EventHandler(this.btnLimpiarTIR_Click);
            // 
            // btnCalCularTIR
            // 
            this.btnCalCularTIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCalCularTIR.Location = new System.Drawing.Point(271, 309);
            this.btnCalCularTIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalCularTIR.Name = "btnCalCularTIR";
            this.btnCalCularTIR.Size = new System.Drawing.Size(124, 54);
            this.btnCalCularTIR.TabIndex = 15;
            this.btnCalCularTIR.Text = "Calcular";
            this.btnCalCularTIR.UseVisualStyleBackColor = false;
            this.btnCalCularTIR.Click += new System.EventHandler(this.btnCalCularTIR_Click);
            // 
            // txtInt2TIR
            // 
            this.txtInt2TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInt2TIR.Location = new System.Drawing.Point(122, 264);
            this.txtInt2TIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInt2TIR.Name = "txtInt2TIR";
            this.txtInt2TIR.Size = new System.Drawing.Size(125, 31);
            this.txtInt2TIR.TabIndex = 14;
            this.txtInt2TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInt2TIR_KeyPress);
            // 
            // txtInt1Tir
            // 
            this.txtInt1Tir.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInt1Tir.Location = new System.Drawing.Point(122, 203);
            this.txtInt1Tir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInt1Tir.Name = "txtInt1Tir";
            this.txtInt1Tir.Size = new System.Drawing.Size(125, 31);
            this.txtInt1Tir.TabIndex = 13;
            this.txtInt1Tir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInt1Tir_KeyPress);
            // 
            // txtVpn2TIR
            // 
            this.txtVpn2TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVpn2TIR.Location = new System.Drawing.Point(271, 155);
            this.txtVpn2TIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVpn2TIR.Name = "txtVpn2TIR";
            this.txtVpn2TIR.Size = new System.Drawing.Size(125, 31);
            this.txtVpn2TIR.TabIndex = 12;
            this.txtVpn2TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVpn2TIR_KeyPress);
            // 
            // txtVpn1TIR
            // 
            this.txtVpn1TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVpn1TIR.Location = new System.Drawing.Point(271, 109);
            this.txtVpn1TIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVpn1TIR.Name = "txtVpn1TIR";
            this.txtVpn1TIR.Size = new System.Drawing.Size(125, 31);
            this.txtVpn1TIR.TabIndex = 11;
            this.txtVpn1TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVpn1TIR_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Interés 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interés 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Presente Neto 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Presente Neto 1";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label10.Location = new System.Drawing.Point(153, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 37);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ingresa los datos";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(234, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 232);
            this.panel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(168, 24);
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
            this.pictureBox2.Location = new System.Drawing.Point(49, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmTIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTIR";
            this.Text = "FrmTIR";
            this.tabControl1.ResumeLayout(false);
            this.tbgDefinicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbgCalculo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTIR)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgDefinicion;
        private System.Windows.Forms.TabPage tbgCalculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalCularTIR;
        private System.Windows.Forms.TextBox txtInt2TIR;
        private System.Windows.Forms.TextBox txtInt1Tir;
        private System.Windows.Forms.TextBox txtVpn2TIR;
        private System.Windows.Forms.TextBox txtVpn1TIR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarTIR;
        private System.Windows.Forms.DataGridView dgvDatosTIR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}