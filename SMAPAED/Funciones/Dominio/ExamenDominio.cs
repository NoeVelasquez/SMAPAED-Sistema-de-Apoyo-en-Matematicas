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
    public partial class ExamenDominio : Form
    {
        public ExamenDominio()
        {
            InitializeComponent();
        }

        private void RbVerdadero2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }
        /*N1:funciones y tipos de funciones
         * N2: dominio y rango
         * N3:Funcion exponencial
         * N4 Funcion Trigonometrica
         * N5:Funcion Logaritmica*/
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
            MessageBox.Show("Su puntaje  en la parte teorica es:" + correcto + "/50 y Su puntaje  en la parte practica es " + correctoEj + "/50 y sera nota"+NotaFinal);
            if (NotaFinal >=51 && NotaFinal<61 )
            {               
                MessageBox.Show("Felicidades tiene "+NotaFinal+"puede ingresar a Funcion Exponencial");  
            }
            else if (NotaFinal > 61 && NotaFinal < 71)
            {
                MessageBox.Show("Felicidades tiene " + NotaFinal + "puede ingresar a Funcion Trigonometrica");
            }
            else if(NotaFinal > 71)
            {
                MessageBox.Show("Felicidades tiene " + NotaFinal + "puede ingresar a Funcion Logaritmica");
            }
            else
            {
                MessageBox.Show("Oh por poco te convierte en un Dios super saiyayin pero tu ki llego hasta " + NotaFinal + "debe volver a entrenar");
            }
        }

        private void ExamenDominio_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
