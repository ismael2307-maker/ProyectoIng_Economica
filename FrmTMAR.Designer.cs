namespace ProyectoIng_Economica
{
    partial class FrmTMAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTMAR));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgDefinicion = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbgCalculo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtInversionTotal = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlComceptoInteres = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCostoDeuda = new System.Windows.Forms.TextBox();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.txtCostoPatrimonio = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbgDefinicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbgCalculo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlComceptoInteres.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1158, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgDefinicion
            // 
            this.tbgDefinicion.Controls.Add(this.pictureBox1);
            this.tbgDefinicion.Location = new System.Drawing.Point(4, 31);
            this.tbgDefinicion.Name = "tbgDefinicion";
            this.tbgDefinicion.Padding = new System.Windows.Forms.Padding(3);
            this.tbgDefinicion.Size = new System.Drawing.Size(1150, 633);
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
            this.pictureBox1.Size = new System.Drawing.Size(1144, 627);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbgCalculo
            // 
            this.tbgCalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgCalculo.Controls.Add(this.panel2);
            this.tbgCalculo.Controls.Add(this.panel1);
            this.tbgCalculo.Controls.Add(this.pnlComceptoInteres);
            this.tbgCalculo.Controls.Add(this.panel4);
            this.tbgCalculo.Location = new System.Drawing.Point(4, 31);
            this.tbgCalculo.Name = "tbgCalculo";
            this.tbgCalculo.Padding = new System.Windows.Forms.Padding(3);
            this.tbgCalculo.Size = new System.Drawing.Size(1150, 633);
            this.tbgCalculo.TabIndex = 1;
            this.tbgCalculo.Text = "Tmar Mixto";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.dgvResultado);
            this.panel2.Location = new System.Drawing.Point(574, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 384);
            this.panel2.TabIndex = 14;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(52, 105);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(466, 150);
            this.dgvResultado.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtCostoPatrimonio);
            this.panel1.Controls.Add(this.txtPatrimonio);
            this.panel1.Controls.Add(this.txtCostoDeuda);
            this.panel1.Controls.Add(this.txtDeuda);
            this.panel1.Controls.Add(this.txtInversionTotal);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 384);
            this.panel1.TabIndex = 13;
            // 
            // txtDeuda
            // 
            this.txtDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtDeuda.ForeColor = System.Drawing.Color.White;
            this.txtDeuda.Location = new System.Drawing.Point(393, 102);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 31);
            this.txtDeuda.TabIndex = 11;
            // 
            // txtInversionTotal
            // 
            this.txtInversionTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtInversionTotal.ForeColor = System.Drawing.Color.White;
            this.txtInversionTotal.Location = new System.Drawing.Point(393, 53);
            this.txtInversionTotal.Name = "txtInversionTotal";
            this.txtInversionTotal.Size = new System.Drawing.Size(100, 31);
            this.txtInversionTotal.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(57, 254);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(274, 22);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Costo del capital Propio (Ke):";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(86, 326);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 33);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Patrimonio aportado (P):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Costo de la Deuda (Kd):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Monto de la Deuda (D):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inversión total del Proyecto (A):";
            // 
            // pnlComceptoInteres
            // 
            this.pnlComceptoInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlComceptoInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlComceptoInteres.Controls.Add(this.richTextBox1);
            this.pnlComceptoInteres.Controls.Add(this.label1);
            this.pnlComceptoInteres.Location = new System.Drawing.Point(574, 3);
            this.pnlComceptoInteres.Name = "pnlComceptoInteres";
            this.pnlComceptoInteres.Size = new System.Drawing.Size(570, 232);
            this.pnlComceptoInteres.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(52, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 156);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Indica que la TMAR considera diferentes tipos de financiamiento. \nEn la práctica," +
    " esto significa que la TMAR se calcula teniendo\n en cuenta el costo del capital " +
    "propio y el costo de la deuda.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Qué es el tmar Mixto";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(8, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 232);
            this.panel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(205, 24);
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
            this.pictureBox2.Location = new System.Drawing.Point(86, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // txtCostoDeuda
            // 
            this.txtCostoDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtCostoDeuda.ForeColor = System.Drawing.Color.White;
            this.txtCostoDeuda.Location = new System.Drawing.Point(393, 148);
            this.txtCostoDeuda.Name = "txtCostoDeuda";
            this.txtCostoDeuda.Size = new System.Drawing.Size(100, 31);
            this.txtCostoDeuda.TabIndex = 12;
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPatrimonio.ForeColor = System.Drawing.Color.White;
            this.txtPatrimonio.Location = new System.Drawing.Point(393, 199);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(100, 31);
            this.txtPatrimonio.TabIndex = 13;
            // 
            // txtCostoPatrimonio
            // 
            this.txtCostoPatrimonio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtCostoPatrimonio.ForeColor = System.Drawing.Color.White;
            this.txtCostoPatrimonio.Location = new System.Drawing.Point(393, 251);
            this.txtCostoPatrimonio.Name = "txtCostoPatrimonio";
            this.txtCostoPatrimonio.Size = new System.Drawing.Size(100, 31);
            this.txtCostoPatrimonio.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(226, 326);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 33);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmTMAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 668);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTMAR";
            this.Text = "FrmTMAR";
            this.Load += new System.EventHandler(this.FrmTMAR_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbgDefinicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbgCalculo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlComceptoInteres.ResumeLayout(false);
            this.pnlComceptoInteres.PerformLayout();
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
        private System.Windows.Forms.Panel pnlComceptoInteres;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtInversiones;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.TextBox txtCostos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtInversionTotal;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.TextBox txtCostoDeuda;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCostoPatrimonio;
    }
}