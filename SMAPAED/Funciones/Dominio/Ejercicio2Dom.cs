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
    public partial class Ejercicio2Dom : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public Ejercicio2Dom()
        {
            InitializeComponent();
        }

        private void Ejercicio2Dom_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el Tercer  ejercicio de dominios");
        }

        private void BtnSolucion_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = true;
        }

        private void BtnSolucionEj2_Click(object sender, EventArgs e)
        {
            SolucionEj2.Visible = true;
        }

        private void Ejemplo1_Click(object sender, EventArgs e)
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
    }
}
