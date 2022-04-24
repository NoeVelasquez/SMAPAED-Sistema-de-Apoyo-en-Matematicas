﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click()
        {

        }

        private void BtnDominio_Click(object sender, EventArgs e)
        {
            SubmenuDominio.Visible=true;
        }

        private void BtnViDom_Click(object sender, EventArgs e)
        {
            SubmenuDominio.Visible = false;
        }

        private void BtnEjDom_Click(object sender, EventArgs e)
        {
            SubmenuDominio.Visible = false;
        }

        private void BtnExaDom_Click(object sender, EventArgs e)
        {
            SubmenuDominio.Visible = false;
        }
        private void AbrirIntroFuncion(object FormHijo)
        {
            if(this.PanelContenedor.Controls.Count>0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel=false;
            fh.Dock=DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag=fh;
            fh.Show();

        }

        private void BtnFunciones_Click(object sender, EventArgs e)
        {
            AbrirIntroFuncion(new IntroFuncion());
        }
    }
}
