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
using static SMAPAED.Menu;


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

            Avatar.MoveTo(680, 7, 1);
            Avatar.Speak("Dominio: La función f de X igual a x elevado al cuadrado mas uno está definida para todos " + "" +
                "los valores reales de x ya que no hay restricciones en el valor de x." +
                "Entonces, el dominio de x es: Todos los valores reales de x");
            Avatar.Speak("Rango: Dado que x elevado al cuadrado nunca es negativo, x elevado al cuadrado mas uno nunca es menor que 1. " +
                "Entonces, el rango de f(x) es:");
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
    }
}
