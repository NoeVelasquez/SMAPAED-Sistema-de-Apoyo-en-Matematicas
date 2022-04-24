using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgentObjects;
using DoubleAgentCtl;

namespace SMAPAED
{
    public partial class IntroFuncion : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public IntroFuncion()
        {
            InitializeComponent();
        }

        string _ytUrl;
        public string LinkVideo
        {
            get
            {
                var ytMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(_ytUrl);
                return ytMatch.Success?ytMatch.Groups[1].Value:String.Empty;

            }
        }
        
        
        private void IntroFuncion_Load(object sender, EventArgs e)
        {

            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(800, 234, 1);
            Avatar.Speak("El concepto de función es uno de los más importantes tanto en Matemáticas," +
            "como en Física, Química, Medicina, Estadística, Economía, Ingeniería, Psicología," +
            "entre otras.Y probablemente te has preguntado cuales serían ejemplos de funciones en la vida" +
            "cotidiana podemos pensar en una máquina expendedora, ya que uno ingresa un código y la maquina te regresa un producto," +
            "el llamar por teléfono también es un ejemplo de una función, tu ingresas un número y" +
            "se te conecta con el otro teléfono.");
            
            Avatar.MoveTo(800, 234, 1);
            Avatar.Speak("Para entender mejor puede ver el video sobre funciones");
            Avatar.Hide();
            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='560' height='315' src='https://www.youtube.com/embed/Ll7xfe3HoZE' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/Ll7xfe3HoZE";
            //txtLink.Text.Split('=')[1]
           this.webBrowser1.DocumentText = string.Format(html,text);
           //webBrowser1.Navigate($https://youtu.be/Ll7xfe3HoZE);
        }

        private void ControlAgTED_ActivateInput()
        {

        }
    }
}
