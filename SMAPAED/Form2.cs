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
            ControlAgEVA.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(565, 284, 1);
            Avatar.Speak("hola Bienvenido al sistema de apoyo para Matematicas");
        }
    }
}
