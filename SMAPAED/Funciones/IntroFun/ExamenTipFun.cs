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
    public partial class ExamenTipFun : Form
    {
        public ExamenTipFun()
        {
            InitializeComponent();
        }

        private void BtnEntregarEx1_Click(object sender, EventArgs e)
        {
            float correcto = 0;
            
            if (RbVerdadero.Checked)
            {
                correcto = (float)(correcto +6.6);
            }
            if (RbVerdadero2.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero3.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero4.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero5.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero6.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero7.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero8.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero9.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero10.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero11.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero12.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero13.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero14.Checked)
            {
                correcto = (float)(correcto + 6.6);
            }
            if (RbVerdadero15.Checked)
            {
                correcto = (float)(correcto + 7.6);
            }
            //int NotaFinal;
            //NotaFinal = Correcto;
            MessageBox.Show("Su puntaje  en la parte teorica es:" + correcto + "/100");
            if (correcto >= 51 && correcto < 61)
            {
                MessageBox.Show("Felicidades tiene " + correcto + "puede ingresar a Dominios");
            }
            else if (correcto > 61 && correcto < 71)
            {
                MessageBox.Show("Felicidades tiene " + correcto + "puede ingresar a Funcion Exponencial");
            }
            else if (correcto > 71)
            {
                MessageBox.Show("Felicidades tiene " + correcto + "puede ingresar a Funcion Trigonometrica");
            }
            else
            {
                MessageBox.Show("Lamentablemente tiene " + correcto + "debe volver a revisar Introduccion a Funciones");
            }
        }
    }
}
