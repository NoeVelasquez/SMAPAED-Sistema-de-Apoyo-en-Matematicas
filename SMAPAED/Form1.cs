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
//using static SMAPAED.ConexionMySQLyForm;

namespace SMAPAED
{
    public partial class Form1 : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        ConexionMySQLyForm cn = new ConexionMySQLyForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlAg.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAg.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(565, 284, 1);
            Avatar.Speak("hola Bienvenido al sistema de apoyo para Matematicas");
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (cn.conMySQL(TxtUsuario.Text, TxtContraseña.Text) == 1)
            {
                MessageBox.Show("Bienvenido Usuario");
                this.Hide();
                Form2 IrEva = new Form2();
                IrEva.Show();
            }
            else
            {
                MessageBox.Show("Usuario No Existe :( ");
            }
        }
    }
}
