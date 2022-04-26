using SMAPAED.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMAPAED
{
    public partial class MenuFunciones : Form
    {
        public MenuFunciones()
        {
            InitializeComponent();
        }
    
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Menu de Dominio*/
        private void BtnDominio_Click(object sender, EventArgs e)
        {
            SubmenuDominio.Visible=true;
        }

        private void BtnViDom_Click(object sender, EventArgs e)
        {
            SubmenuDominio.Visible = false;
            AbrirDominioVideo(new DominioVideo());
        }

        public void BtnEjDom_Click(object sender, EventArgs e)
        {
            //SubmenuDominio.Visible = false;
            SubSubmenuEj34.Visible = true;
            AbrirEjercicioDom(new EjercicioDom());
        }

        private void BtnExaDom_Click(object sender, EventArgs e)
        {
            SubmenuDominio.Visible = true;
            AbrirEjercicioDom(new ExamenDominio());
        }
        /*AREA PARA INTRO A FUNCIONES*/
        private void AbrirIntroFuncion(object FormHijo)
        {
            if(this.PanelContenedor.Controls.Count>0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                
            }
           
            Form fh = FormHijo as Form;
            fh.TopLevel=false;
            fh.Dock=DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag=fh;
            fh.Show();

        }
        private void AbrirTipoFun(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        private void AbrirExamFun(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        /* AREA PARA DOMINIOS*/
        private void AbrirDominioVideo(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        private void AbrirEjercicioDom(object FormHijo1)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo1 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        private void AbrirExamenDom(object FormHijo2)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo2 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        private void BtnFunciones_Click(object sender, EventArgs e)
        {
            SubmenuFunc.Visible = true;
        }

        public void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {   
            string Text = ("C:/Users/noemi/Source/Repos/NoeVelasquez/SMAPAED-Sistema-de-Apoyo-en-Matematicas/SMAPAED/Videos/Funciones_ La MEJOR EXPLICACIÓN INFORMAL - Por Lic. María Inés Baragatti - UNLP.mp4");
            
            Video1.URL = Text;
            Video1.Ctlcontrols.play();
            Video1.Ctlcontrols.stop();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        public void llamarPadre(object FormPadre)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form PA = FormPadre as Form;
            PA.TopLevel = false;
            PA.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(PA);
            this.PanelContenedor.Tag = PA;
            PA.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void AbrirEjercicio2Dom(object FormHijo1)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo1 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        private void BtnEj3Dom_Click(object sender, EventArgs e)
        {
            AbrirEjercicio2Dom(new Ejercicio2Dom());
        }
        /*MENU DE INTRODUCCION A FUNCIONES*/
        private void button9_Click(object sender, EventArgs e)
        {
            AbrirIntroFuncion(new IntroFuncion());
        }

        private void BtnTipFun_Click(object sender, EventArgs e)
        {
            AbrirTipoFun(new TiposFun());
        }

        private void BtnExamFun_Click(object sender, EventArgs e)
        {
            AbrirExamFun(new ExamenTipFun());
        }
        /*MENU DE EXPONENCIAL*/
        private void button5_Click(object sender, EventArgs e)
        {
            SubmenuExpo.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubmenuExpo.Visible = false;
            AbrirMenuExponencial(new VideoExpo());
        }

        private void BtnEjExpo_Click(object sender, EventArgs e)
        {
            SubSubmenuEj3Expo.Visible = true;
            AbrirMenuExponencial(new EjerExpo());
        }

        private void BtnEje3Expo_Click(object sender, EventArgs e)
        {
            
            AbrirMenuExponencial(new Ejer2Expo());
        }

        private void BtnExaExpo_Click(object sender, EventArgs e)
        {
            SubmenuExpo.Visible = true;
            AbrirMenuExponencial(new ExamenExponencial());
        }
        private void AbrirMenuExponencial(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        /*MENU DE Trigonometrica*/
        private void BtnTrigonometrica_Click(object sender, EventArgs e)
        {
            SubMenuTrigo.Visible = true;
        }

        private void BtnVidTrigo_Click(object sender, EventArgs e)
        {
            SubMenuTrigo.Visible = false;
            AbrirMenuTrigonometrico(new VideoTrigo());
        }

        private void BtnEjTrigo_Click(object sender, EventArgs e)
        {
            SubSubmenuEj3Trigo.Visible = true;
            AbrirMenuTrigonometrico(new EjercicioTrigo());
        }

        private void BtnEj3Trigo_Click(object sender, EventArgs e)
        {
            AbrirMenuTrigonometrico(new Ejericcio2Trigo());
        }

        private void BtnExaTrigo_Click(object sender, EventArgs e)
        {
            SubMenuTrigo.Visible = true;
            AbrirMenuTrigonometrico(new ExamenTrigonometricas());
        }
        private void AbrirMenuTrigonometrico(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

        private void BarraLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubSubmenuEj3Expo_Paint(object sender, PaintEventArgs e)
        {

        }
        /*MENU DE Logaritmicas*/
        private void BtnLogaritmico_Click(object sender, EventArgs e)
        {
            SubMenuLog.Visible = true;
        }

        private void BtnVidLoga_Click(object sender, EventArgs e)
        {
            SubMenuLog.Visible = false;
            AbrirMenuLogaritmico(new VideoLogar());
        }

        private void BtnEjLoga_Click(object sender, EventArgs e)
        {
            SubMenuEj3Log.Visible = true;
            AbrirMenuLogaritmico(new EjercicioLogar());
        }

        private void BtnEj3Loga_Click(object sender, EventArgs e)
        {
            SubMenuLog.Visible = true;
            AbrirMenuLogaritmico(new Ejercicio2Logar());
        }

        private void SubMenuTrigo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExaLoga_Click(object sender, EventArgs e)
        {
            SubMenuTrigo.Visible = true;
            AbrirMenuLogaritmico(new ExamenLogaritmicos());
        }
        private void AbrirMenuLogaritmico(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
    }
}
