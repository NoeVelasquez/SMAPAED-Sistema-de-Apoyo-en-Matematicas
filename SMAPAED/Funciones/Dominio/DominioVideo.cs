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
    public partial class DominioVideo : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public DominioVideo()
        {
            InitializeComponent();
        }

        private void IntroFunTeo_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el video de dominios");
            

            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='560' height='315' src='https://www.youtube.com/embed/jBJ2ZgIcmJI' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/jBJ2ZgIcmJI";
            //txtLink.Text.Split('=')[1]
            this.webBrowser1.DocumentText = string.Format(html, text);
            //webBrowser1.Navigate($https://youtu.be/Ll7xfe3HoZE);,
            Avatar.Speak("Pensad por ejemplo en la función 1 sobre x " +
                "donde la x puede tomar cualquier valor. " +
                "¿Se puede calcular la función cuando tomamos el valor x = 0? " +
                " Si tienes dudas, coge la calculadora e intenta calcularlo. " +
                "Esta regla es muy importante en matemáticas: no se puede " +
                "dividir por cero.Se aplicarán otras, como por ejemplo, " +
                "que no se puede calcular la raíz cuadrada de un número " +
                "negativo(siempre que no vayamos a trabajar con números " +
                "complejos, pero es alejarnos de nuestro objetivo). ");
            Avatar.Hide(50);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void ControlAgTED_ActivateInput(object sender, AxDoubleAgentCtl._DaCtlEvents2_ActivateInputEvent e)
        {

        }
    }
}
