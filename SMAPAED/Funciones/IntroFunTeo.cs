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
    public partial class IntroFunTeo : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public IntroFunTeo()
        {
            InitializeComponent();
        }

        private void IntroFunTeo_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("El concepto de función es uno de los más importantes tanto en Matemáticas,"+
            "como en Física, Química, Medicina, Estadística, Economía, Ingeniería, Psicología,"+
            "entre otras.Y probablemente te has preguntado cuales serían ejemplos de funciones en la vida"+
            "cotidiana.Al pensar en ejemplos de funciones en la vida cotidiana podemos pensar en una"+
            "máquina expendedora, ya que uno ingresa un código y la maquina te regresa un producto,"+
            "el llamar por teléfono también es un ejemplo de una función, tu ingresas un número y"+
            "se te conecta con el otro teléfono.");
            Avatar.Hide(50);
        }

    }
}
