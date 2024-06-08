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
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIngTIR = new System.Windows.Forms.TextBox();
            this.txtVpn1TIR = new System.Windows.Forms.TextBox();
            this.txtVpn2TIR = new System.Windows.Forms.TextBox();
            this.txtInt1Tir = new System.Windows.Forms.TextBox();
            this.txtInt2TIR = new System.Windows.Forms.TextBox();
            this.btnCalCularTIR = new System.Windows.Forms.Button();
            this.btnLimpiarTIR = new System.Windows.Forms.Button();
            this.dgvDatosTIR = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbgDefinicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbgCalculo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTIR)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgDefinicion);
            this.tabControl1.Controls.Add(this.tbgCalculo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1544, 822);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgDefinicion
            // 
            this.tbgDefinicion.Controls.Add(this.pictureBox1);
            this.tbgDefinicion.Location = new System.Drawing.Point(4, 39);
            this.tbgDefinicion.Margin = new System.Windows.Forms.Padding(4);
            this.tbgDefinicion.Name = "tbgDefinicion";
            this.tbgDefinicion.Padding = new System.Windows.Forms.Padding(4);
            this.tbgDefinicion.Size = new System.Drawing.Size(1536, 779);
            this.tbgDefinicion.TabIndex = 0;
            this.tbgDefinicion.Text = "Definición";
            this.tbgDefinicion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1528, 771);
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
            this.tbgCalculo.Location = new System.Drawing.Point(4, 39);
            this.tbgCalculo.Margin = new System.Windows.Forms.Padding(4);
            this.tbgCalculo.Name = "tbgCalculo";
            this.tbgCalculo.Padding = new System.Windows.Forms.Padding(4);
            this.tbgCalculo.Size = new System.Drawing.Size(1536, 779);
            this.tbgCalculo.TabIndex = 1;
            this.tbgCalculo.Text = "Calculo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dgvDatosTIR);
            this.panel1.Location = new System.Drawing.Point(775, 300);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 469);
            this.panel1.TabIndex = 17;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel11.Controls.Add(this.btnLimpiarTIR);
            this.panel11.Controls.Add(this.btnCalCularTIR);
            this.panel11.Controls.Add(this.txtInt2TIR);
            this.panel11.Controls.Add(this.txtInt1Tir);
            this.panel11.Controls.Add(this.txtVpn2TIR);
            this.panel11.Controls.Add(this.txtVpn1TIR);
            this.panel11.Controls.Add(this.txtIngTIR);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Location = new System.Drawing.Point(4, 300);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(763, 469);
            this.panel11.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label10.Location = new System.Drawing.Point(204, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(323, 46);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ingresa los datos";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(391, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(648, 286);
            this.panel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(224, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ecuación ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 81);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(517, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Presente Neto 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(25, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Presente Neto 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interés 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(25, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Interés 2";
            // 
            // txtIngTIR
            // 
            this.txtIngTIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIngTIR.Location = new System.Drawing.Point(146, 72);
            this.txtIngTIR.Name = "txtIngTIR";
            this.txtIngTIR.Size = new System.Drawing.Size(165, 37);
            this.txtIngTIR.TabIndex = 10;
            this.txtIngTIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngTIR_KeyPress);
            // 
            // txtVpn1TIR
            // 
            this.txtVpn1TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVpn1TIR.Location = new System.Drawing.Point(312, 137);
            this.txtVpn1TIR.Name = "txtVpn1TIR";
            this.txtVpn1TIR.Size = new System.Drawing.Size(165, 37);
            this.txtVpn1TIR.TabIndex = 11;
            this.txtVpn1TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVpn1TIR_KeyPress);
            // 
            // txtVpn2TIR
            // 
            this.txtVpn2TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVpn2TIR.Location = new System.Drawing.Point(312, 194);
            this.txtVpn2TIR.Name = "txtVpn2TIR";
            this.txtVpn2TIR.Size = new System.Drawing.Size(165, 37);
            this.txtVpn2TIR.TabIndex = 12;
            this.txtVpn2TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVpn2TIR_KeyPress);
            // 
            // txtInt1Tir
            // 
            this.txtInt1Tir.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInt1Tir.Location = new System.Drawing.Point(162, 250);
            this.txtInt1Tir.Name = "txtInt1Tir";
            this.txtInt1Tir.Size = new System.Drawing.Size(165, 37);
            this.txtInt1Tir.TabIndex = 13;
            this.txtInt1Tir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInt1Tir_KeyPress);
            // 
            // txtInt2TIR
            // 
            this.txtInt2TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInt2TIR.Location = new System.Drawing.Point(162, 325);
            this.txtInt2TIR.Name = "txtInt2TIR";
            this.txtInt2TIR.Size = new System.Drawing.Size(165, 37);
            this.txtInt2TIR.TabIndex = 14;
            this.txtInt2TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInt2TIR_KeyPress);
            // 
            // btnCalCularTIR
            // 
            this.btnCalCularTIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCalCularTIR.Location = new System.Drawing.Point(361, 380);
            this.btnCalCularTIR.Name = "btnCalCularTIR";
            this.btnCalCularTIR.Size = new System.Drawing.Size(166, 66);
            this.btnCalCularTIR.TabIndex = 15;
            this.btnCalCularTIR.Text = "Calcular";
            this.btnCalCularTIR.UseVisualStyleBackColor = false;
            this.btnCalCularTIR.Click += new System.EventHandler(this.btnCalCularTIR_Click);
            // 
            // btnLimpiarTIR
            // 
            this.btnLimpiarTIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLimpiarTIR.Location = new System.Drawing.Point(568, 380);
            this.btnLimpiarTIR.Name = "btnLimpiarTIR";
            this.btnLimpiarTIR.Size = new System.Drawing.Size(165, 66);
            this.btnLimpiarTIR.TabIndex = 16;
            this.btnLimpiarTIR.Text = "Limpiar";
            this.btnLimpiarTIR.UseVisualStyleBackColor = false;
            this.btnLimpiarTIR.Click += new System.EventHandler(this.btnLimpiarTIR_Click);
            // 
            // dgvDatosTIR
            // 
            this.dgvDatosTIR.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDatosTIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosTIR.Location = new System.Drawing.Point(37, 44);
            this.dgvDatosTIR.Name = "dgvDatosTIR";
            this.dgvDatosTIR.RowHeadersWidth = 51;
            this.dgvDatosTIR.RowTemplate.Height = 24;
            this.dgvDatosTIR.Size = new System.Drawing.Size(684, 366);
            this.dgvDatosTIR.TabIndex = 0;
            // 
            // FrmTIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 822);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTIR";
            this.Text = "FrmTIR";
            this.tabControl1.ResumeLayout(false);
            this.tbgDefinicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbgCalculo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTIR)).EndInit();
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
        private System.Windows.Forms.TextBox txtIngTIR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarTIR;
        private System.Windows.Forms.DataGridView dgvDatosTIR;
    }
}