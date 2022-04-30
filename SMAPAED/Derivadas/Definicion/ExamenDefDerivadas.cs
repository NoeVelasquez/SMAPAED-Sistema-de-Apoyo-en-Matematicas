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
    public partial class ExamenDefDerivadas : Form
    {
        public ExamenDefDerivadas()
        {
            InitializeComponent();
        }

        private void RbVerdadero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnEntregarEx1_Click(object sender, EventArgs e)
        {
            int correcto = 0;
            int correctoEj = 0;
            //int incorrecto = 0;
            if (RbVerdadero.Checked)
            {
                correcto = correcto + 10;

            }
            if (RbVerdadero2.Checked)
            {
                correcto = correcto + 10;

            }
            if (RbVerdadero3.Checked)
            {
                correcto = correcto + 10;

            }
            if (RbVerdadero4.Checked)
            {
                correcto = correcto + 10;

            }
            if (RbVerdaderoEj1.Checked)
            {
                correctoEj = correctoEj + 20;

            }
            if (RbVerdaderoEj2.Checked)
            {
                correctoEj = correctoEj + 20;

            }
            if (RbVerdaderoEj3.Checked)
            {
                correctoEj = correctoEj + 20;

            }
            int Nota = correcto + correctoEj;
            int NotaFinal;
            NotaFinal = Nota;
            MessageBox.Show("Su puntaje  en la parte teorica es:" + correcto + "/50 y Su puntaje  en la parte practica es " + correctoEj + "/50 y sera nota" + NotaFinal);
            if (NotaFinal >= 51 && NotaFinal < 61)
            {
                MessageBox.Show("Felicidades tiene " + NotaFinal + "puede ingresar a Funcion Exponencial");
            }
            else if (NotaFinal > 61 && NotaFinal < 71)
            {
                MessageBox.Show("Felicidades tiene " + NotaFinal + "puede ingresar a Funcion Trigonometrica");
            }
            else if (NotaFinal > 71)
            {
                MessageBox.Show("Felicidades tiene " + NotaFinal + "puede ingresar a Funcion Logaritmica");
            }
            else
            {
                MessageBox.Show("Lamentablemente tiene " + NotaFinal + "debe volver a revisar Dominios");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
