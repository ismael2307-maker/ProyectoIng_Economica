namespace ProyectoIng_Economica
{
    partial class FrmVPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVPN));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgDefinicion = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbgCalculo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.ANIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flujoNeE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtAnios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvFlujosNetos = new System.Windows.Forms.DataGridView();
            this.AÑO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flujoNE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTasaDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInversionInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbgDefinicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbgCalculo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlujosNetos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgDefinicion);
            this.tabControl1.Controls.Add(this.tbgCalculo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgDefinicion
            // 
            this.tbgDefinicion.Controls.Add(this.pictureBox1);
            this.tbgDefinicion.Location = new System.Drawing.Point(4, 33);
            this.tbgDefinicion.Name = "tbgDefinicion";
            this.tbgDefinicion.Padding = new System.Windows.Forms.Padding(3);
            this.tbgDefinicion.Size = new System.Drawing.Size(1150, 631);
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
            this.pictureBox1.Size = new System.Drawing.Size(1144, 625);
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
            this.tbgCalculo.Location = new System.Drawing.Point(4, 33);
            this.tbgCalculo.Name = "tbgCalculo";
            this.tbgCalculo.Padding = new System.Windows.Forms.Padding(3);
            this.tbgCalculo.Size = new System.Drawing.Size(1150, 631);
            this.tbgCalculo.TabIndex = 1;
            this.tbgCalculo.Text = "Calculo VPN";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dgvResultados);
            this.panel1.Location = new System.Drawing.Point(537, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 381);
            this.panel1.TabIndex = 16;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ANIO,
            this.flujoNeE,
            this.ValPN});
            this.dgvResultados.Location = new System.Drawing.Point(12, 86);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(450, 177);
            this.dgvResultados.TabIndex = 5;
            // 
            // ANIO
            // 
            this.ANIO.HeaderText = "AÑO";
            this.ANIO.Name = "ANIO";
            // 
            // flujoNeE
            // 
            this.flujoNeE.HeaderText = "FNE";
            this.flujoNeE.Name = "flujoNeE";
            // 
            // ValPN
            // 
            this.ValPN.HeaderText = "VPN";
            this.ValPN.Name = "ValPN";
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel11.Controls.Add(this.label26);
            this.panel11.Controls.Add(this.txtAnios);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.btnLimpiar);
            this.panel11.Controls.Add(this.btnCalcular);
            this.panel11.Controls.Add(this.dgvFlujosNetos);
            this.panel11.Controls.Add(this.txtTasaDescuento);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.txtInversionInicial);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Location = new System.Drawing.Point(8, 244);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(523, 381);
            this.panel11.TabIndex = 15;
            // 
            // txtAnios
            // 
            this.txtAnios.Location = new System.Drawing.Point(199, 68);
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(112, 29);
            this.txtAnios.TabIndex = 8;
            this.txtAnios.TextChanged += new System.EventHandler(this.txtAnios_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(129, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Años";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(412, 305);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 31);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(308, 305);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 31);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvFlujosNetos
            // 
            this.dgvFlujosNetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlujosNetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AÑO,
            this.flujoNE});
            this.dgvFlujosNetos.Location = new System.Drawing.Point(24, 132);
            this.dgvFlujosNetos.Name = "dgvFlujosNetos";
            this.dgvFlujosNetos.Size = new System.Drawing.Size(474, 150);
            this.dgvFlujosNetos.TabIndex = 4;
            // 
            // AÑO
            // 
            this.AÑO.HeaderText = "AÑO";
            this.AÑO.Name = "AÑO";
            // 
            // flujoNE
            // 
            this.flujoNE.HeaderText = "FNE";
            this.flujoNE.Name = "flujoNE";
            // 
            // txtTasaDescuento
            // 
            this.txtTasaDescuento.Location = new System.Drawing.Point(383, 12);
            this.txtTasaDescuento.Name = "txtTasaDescuento";
            this.txtTasaDescuento.Size = new System.Drawing.Size(100, 29);
            this.txtTasaDescuento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(313, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "TMAR\r\n";
            // 
            // txtInversionInicial
            // 
            this.txtInversionInicial.Location = new System.Drawing.Point(180, 12);
            this.txtInversionInicial.Name = "txtInversionInicial";
            this.txtInversionInicial.Size = new System.Drawing.Size(100, 29);
            this.txtInversionInicial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversion Inicial C$:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(316, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 232);
            this.panel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(168, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
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
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(489, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 25);
            this.label26.TabIndex = 16;
            this.label26.Text = "%";
            // 
            // FrmVPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 668);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVPN";
            this.Text = "FrmVPN";
            this.tabControl1.ResumeLayout(false);
            this.tbgDefinicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbgCalculo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlujosNetos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgDefinicion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tbgCalculo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTasaDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInversionInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvFlujosNetos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AÑO;
        private System.Windows.Forms.DataGridViewTextBoxColumn flujoNE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn flujoNeE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValPN;
        private System.Windows.Forms.TextBox txtAnios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
    }
}