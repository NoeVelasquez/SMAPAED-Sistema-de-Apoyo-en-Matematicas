using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgentObjects;
using DoubleAgentCtl;

namespace SMAPAED
{
    public partial class Form2 : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ControlAgEVA.Characters.Load("Athena", "Athena.acs");
            Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["Athena"];
            Avatar.Show(0);
            Avatar.MoveTo(690,7, 1);
            Avatar.Speak("Primeramente debe de realizar el test de funciones");
            Avatar.Hide(50);
        }
        public struct Datos
        {
            public int datoFuncion;

        }
        private void BtnVerificar1_Click(object sender, EventArgs e)
        {
            int correcto = 0;
            //int incorrecto = 0;
            if (RbVerdadero.Checked)
            {
                correcto = correcto + 4;

            }
            if (RbVerdadero2.Checked)
            {
                correcto = correcto + 4;

            }
            if (RbVerdadero3.Checked)
            {
                correcto = correcto + 4;

            }
            if (RbVerdadero4.Checked)
            {
                correcto = correcto + 4;

            }
            if (RbVerdadero5.Checked)
            {
                correcto = correcto + 4;

            }
           
            MessageBox.Show("Su puntaje es:" + correcto + "/20");
            
            Datos info;
            info.datoFuncion = correcto;
            if (correcto > 10)
            {
                MessageBox.Show("Pasas al examen de derivadas");
                this.Hide();
                Form3Derivadas IrEvaD = new Form3Derivadas(info);
                IrEvaD.Show();
            }
            else
            {
                this.Hide();
                MenuFunciones MenFun = new MenuFunciones();
                MenFun.Show();
                Avatar.Show(0);
                Avatar.MoveTo(690, 7, 1);
                Avatar.Speak("Debemos de repasar sobre Funciones Vamos al Menu");
                Avatar.Hide(50);
            }
            
        }
               
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
