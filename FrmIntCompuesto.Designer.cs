namespace ProyectoIng_Economica
{
    partial class FrmIntCompuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntCompuesto));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgDefinicion = new System.Windows.Forms.TabPage();
            this.tbgFuturo = new System.Windows.Forms.TabPage();
            this.tbgPresente = new System.Windows.Forms.TabPage();
            this.tbgInteres = new System.Windows.Forms.TabPage();
            this.tbgPeriodo = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbgDefinicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgDefinicion);
            this.tabControl1.Controls.Add(this.tbgFuturo);
            this.tabControl1.Controls.Add(this.tbgPresente);
            this.tabControl1.Controls.Add(this.tbgInteres);
            this.tabControl1.Controls.Add(this.tbgPeriodo);
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
            this.tbgDefinicion.Text = "Definición ";
            // 
            // tbgFuturo
            // 
            this.tbgFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgFuturo.Location = new System.Drawing.Point(4, 31);
            this.tbgFuturo.Name = "tbgFuturo";
            this.tbgFuturo.Padding = new System.Windows.Forms.Padding(3);
            this.tbgFuturo.Size = new System.Drawing.Size(1092, 577);
            this.tbgFuturo.TabIndex = 1;
            this.tbgFuturo.Text = "Futuro";
            // 
            // tbgPresente
            // 
            this.tbgPresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgPresente.Location = new System.Drawing.Point(4, 31);
            this.tbgPresente.Name = "tbgPresente";
            this.tbgPresente.Size = new System.Drawing.Size(1092, 577);
            this.tbgPresente.TabIndex = 2;
            this.tbgPresente.Text = "Presente";
            // 
            // tbgInteres
            // 
            this.tbgInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgInteres.Location = new System.Drawing.Point(4, 31);
            this.tbgInteres.Name = "tbgInteres";
            this.tbgInteres.Size = new System.Drawing.Size(1092, 577);
            this.tbgInteres.TabIndex = 3;
            this.tbgInteres.Text = "Interés";
            // 
            // tbgPeriodo
            // 
            this.tbgPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbgPeriodo.Location = new System.Drawing.Point(4, 31);
            this.tbgPeriodo.Name = "tbgPeriodo";
            this.tbgPeriodo.Size = new System.Drawing.Size(1092, 577);
            this.tbgPeriodo.TabIndex = 4;
            this.tbgPeriodo.Text = "Periodo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIntCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIntCompuesto";
            this.Text = "FrmIntCompuesto";
            this.tabControl1.ResumeLayout(false);
            this.tbgDefinicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgDefinicion;
        private System.Windows.Forms.TabPage tbgFuturo;
        private System.Windows.Forms.TabPage tbgPresente;
        private System.Windows.Forms.TabPage tbgInteres;
        private System.Windows.Forms.TabPage tbgPeriodo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}