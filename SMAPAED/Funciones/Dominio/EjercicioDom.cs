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
using static SMAPAED.MenuFunciones;


namespace SMAPAED.Funciones
{
    public partial class EjercicioDom : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public EjercicioDom()
        {
            InitializeComponent();
        }

        private void BtnSolucion_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = true;
        }
        
        private void EjercicioDom_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el primer ejercicio de dominios");

            
        }

        private void pictureBox12_Click(object sende)
        {

        }

        private void BtnSolucionEj2_Click(object sender, EventArgs e)
        {
            SolucionEj2.Visible = true;
        }

        private void BtnSiguientEj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio2Dom IrTED = new Ejercicio2Dom();
            IrTED.Show();
        }

        private void Ejemplo1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SolucionEj1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SolucionEj2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
