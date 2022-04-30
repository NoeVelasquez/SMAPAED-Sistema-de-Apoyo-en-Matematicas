using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgentObjects;
using DoubleAgentCtl;

namespace SMAPAED
{
    public partial class Form3Derivadas : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public Form3Derivadas(Form2.Datos inf)
        {
            InitializeComponent();
            LblNotaFun.Text =Convert.ToString(inf.datoFuncion);
            
        }

        private void Form3Derivadas_Load(object sender, EventArgs e)
        {
            ControlAgEvaD.Characters.Load("Athena", "Athena.acs");
            Avatar = (IAgentCtlCharacter)ControlAgEvaD.Characters["Athena"];
            Avatar.Show(0);
            Avatar.MoveTo(756, 34, 1);
            Avatar.Speak("y ahora de Derivadas");
            Avatar.Hide(50);
        }

        private void BtnVerificarDev_Click(object sender, EventArgs e)
        {
            int correctod = 0;
            //int incorrecto = 0;
            if (RbVerdaderoD1.Checked)
            {
                correctod = correctod + 5;

            }
            if (RbVerdaderoD2.Checked)
            {
                correctod = correctod + 5;

            }
            if (RbVerdaderoD3.Checked)
            {
                correctod = correctod + 5;

            }
            if (RbVerdaderoD4.Checked)
            {
                correctod = correctod + 5;

            }
            if (RbVerdaderoD5.Checked)
            {
                correctod = correctod + 5;

            }
            if (RbVerdaderoD6.Checked)
            {
                correctod = correctod + 5;

            }
            MessageBox.Show("Su puntaje es:" + correctod + "/30");
            if (correctod <= 15)
            {
                MessageBox.Show("Pasas a Derivadas");
                this.Hide();
                MenuDerivadas MenDev = new MenuDerivadas();
                MenDev.Show();
            }
            else
            {
                MessageBox.Show("MUCHAS FELICIDADES ESTAS MUY BIEN EN FUNCIONES Y DERIVADAS");
                
            }
        }
       
      /* public void mostrarnotificacion()
        {
            notifyIcon1.Text = "MUCHAS FELICIDADES ESTAS MUY BIEN EN FUNCIONES Y DERIVADAS";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Hola felicidades";
            notifyIcon1.BalloonTipText = "Bienvenido";
            notifyIcon1.ShowBalloonTip(100);
        }*/
    }
}
