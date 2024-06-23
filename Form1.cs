using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoIng_Economica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            this.MaximumSize = new Size(1920, 1080);
        }
           
        private void customizeDesing()
        {
            pnlSubMenuInteres.Visible = false;
            pnlSubMenus.Visible = false;
            pnlSubMenuIndicadores.Visible = false;
            pnlGradientes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubMenuInteres.Visible == true)
                pnlSubMenuInteres.Visible = false;
            if (pnlSubMenus.Visible == true)
                pnlSubMenus.Visible = false;
            if (pnlSubMenuIndicadores.Visible == true)
                pnlSubMenuIndicadores.Visible = false;
            if (pnlGradientes.Visible == true)
                pnlGradientes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnInteres_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuInteres);
        }

        private void btnInteres2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmInteresAcumulado());
            hideSubMenu();
        }

        private void btnInteresSimple_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmIntSimple());
            hideSubMenu();
        }

        private void btnInteresCompuesto_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmIntCompuesto());
            hideSubMenu();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmPresentacion());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPresentacion_Click(null, e);
        }

        private void btnAnualidades_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmPresentacionAnualidades());
            showSubMenu(pnlSubMenus);
        }

        private void btnAnualidadesVencidas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAnualidadesVencidas());
            hideSubMenu();
        }

        private void btnAnualidadesAnticipadas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmaAnualidadAnticipada());
            hideSubMenu();
        }

        private void btnAnualidadesDiferidas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAnualidadDiferidas());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Indicadores
            AbrirFormHija(new FrmPresentacionIndicadores());
            showSubMenu(pnlSubMenuIndicadores);
        }

        private void btnAnualidadesPerpetuas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmPerpetua());
            hideSubMenu();
        }

        private void btnTmar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmTMAR());
            hideSubMenu();
        }

        private void btnVpn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmVPN());
            hideSubMenu();
        }

        private void btnTir_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmTIR());
            hideSubMenu();
        }

        private void btnCaue_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmCAUE());
            hideSubMenu();
        }

        private void btnCalendarioPago_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmCalendarioPago());
        }

        private void btnGradientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmPresentacionGradientes());
            showSubMenu(pnlGradientes);
            
        }

        private void pnlSideMenu_Paint(object sender, PaintEventArgs e)
        {
            //Ignorar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAritmetico());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmGeometrico());
            hideSubMenu();
        }
    }
}
