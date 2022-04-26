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
    public partial class ExamenLogaritmicos : Form
    {
        public ExamenLogaritmicos()
        {
            InitializeComponent();
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
                correctoEj = correctoEj + 30;

            }
            if (RbVerdaderoEj2.Checked)
            {
                correctoEj = correctoEj + 30;

            }
            int Nota = correcto + correctoEj;
            int NotaFinal;
            NotaFinal = Nota;
            MessageBox.Show("Su puntaje  en la parte teorica es:" + correcto + "/50 y Su puntaje  en la parte practica es " + correctoEj + "/50 y sera nota" + NotaFinal);
            if (NotaFinal >= 51 && NotaFinal < 61)
            {
                MessageBox.Show("Felicidades tiene " + NotaFinal + "puede ingresar a Funcion Trigonometrica");
            }
            else if (NotaFinal > 61 && NotaFinal < 71)
            {
                MessageBox.Show("Felicidades tiene " + NotaFinal + "puede ingresar a Funcion Logaritmica");
            }

            else
            {
                MessageBox.Show("Lamentablemente tiene " + NotaFinal + "debe volver a revisar Funciones Trigonometricas");
            }
        }
    }
}
