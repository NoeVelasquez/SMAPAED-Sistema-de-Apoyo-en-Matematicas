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
    public partial class Ejercicio2Logar : Form
    {
        public Ejercicio2Logar()
        {
            InitializeComponent();
        }

        private void BtnSolucion_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = true;
        }

        private void BtnSolucionEj2_Click(object sender, EventArgs e)
        {
            SolucionEj2.Visible = true;
        }
    }
}
