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
    public partial class MenuDerivadas : Form
    {
        public MenuDerivadas()
        {
            InitializeComponent();
        }
       
        private void BtnDefinicionDer_Click(object sender, EventArgs e)
        {
            SubmenuDer.Visible = true;
        }

        private void BtnIntFun_Click(object sender, EventArgs e)
        {
            AbrirMenuDefinicionDer(new DefinicionVideoDer());

        }

        private void BtnTipFun_Click(object sender, EventArgs e)
        {
            AbrirMenuDefinicionDer(new TeoriaDefDerivadas());
        }

        private void BtnExamFun_Click(object sender, EventArgs e)
        {
            AbrirMenuDefinicionDer(new ExamenDefDerivadas());
        }
        private void AbrirMenuDefinicionDer(object FormHijo)
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

        private void BtnReglaCadena_Click(object sender, EventArgs e)
        {
            SubmenuRegCad.Visible = true;
        }

        private void BtnViDom_Click(object sender, EventArgs e)
        {
            AbrirMenuRegCadena(new VidReglaCadDerivadas());
        }

        private void BtnEjDom_Click(object sender, EventArgs e)
        {
            SubSubmenuEj34.Visible = true;
            AbrirMenuRegCadena(new EjercicioRegCadDer());
        }

        private void BtnExaDom_Click(object sender, EventArgs e)
        {
            AbrirMenuRegCadena(new ExamenRegCadDer());
        }
        private void AbrirMenuRegCadena(object FormHijo)
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

        private void BtnEj3Dom_Click(object sender, EventArgs e)
        {
            AbrirMenuRegCadena(new Ejericicio3RegCadDer());
        }

        private void BtnDerivImplicita_Click(object sender, EventArgs e)
        {
            SubmenuDerImp.Visible = true;
        }

        private void BtnVideoExpo_Click(object sender, EventArgs e)
        {
            AbrirMenuDerImplicita(new VidDerImplicita());
        }

        private void BtnEjExpo_Click(object sender, EventArgs e)
        {
            SubSubmenuEj3DerImp.Visible = true;
            AbrirMenuDerImplicita(new EjercicioDerImplicita());
        }

        private void BtnExaExpo_Click(object sender, EventArgs e)
        {
            AbrirMenuDerImplicita(new ExamenDerImplicita());
        }

        private void BtnEje3Expo_Click(object sender, EventArgs e)
        {
            AbrirMenuDerImplicita(new Ejercicio3DerImplicita());
        }
        private void AbrirMenuDerImplicita(object FormHijo)
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

        private void BtnTrigonometrica_Click(object sender, EventArgs e)
        {
            SubMenuOrdSup.Visible = true;
        }

        private void BtnVidTrigo_Click(object sender, EventArgs e)
        {
            AbrirMenuOrdenSup(new VideOrdenSuperior());
        }

        private void BtnEjTrigo_Click(object sender, EventArgs e)
        {
            SubSubmenuEj3OrdSup.Visible = true;
            AbrirMenuOrdenSup(new EjerciciOrdenSup());
        }

        private void BtnExaTrigo_Click(object sender, EventArgs e)
        {
            AbrirMenuOrdenSup(new ExamenOrdenSup());
        }

        private void BtnEj3Trigo_Click(object sender, EventArgs e)
        {
            AbrirMenuOrdenSup(new Ejercicio3DerImplicita());
        }
        private void AbrirMenuOrdenSup(object FormHijo)
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

        private void BtnTayloryHopital_Click(object sender, EventArgs e)
        {
            SubMenuTayHop.Visible = true;
        }

        private void BtnVidLoga_Click(object sender, EventArgs e)
        {
            AbrirMenuTayHop(new VideoTayyHop());
        }

        private void BtnEjLoga_Click(object sender, EventArgs e)
        {
            SubMenuEj3TayHop.Visible = true;
            AbrirMenuTayHop(new EjercicioTayyHop());
        }

        private void BtnExaLoga_Click(object sender, EventArgs e)
        {
            AbrirMenuTayHop(new ExamenTayyHop());
        }

        private void BtnEj3Loga_Click(object sender, EventArgs e)
        {
            AbrirMenuTayHop(new Ejercicio3TayyHop());
        }
        private void AbrirMenuTayHop(object FormHijo)
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
