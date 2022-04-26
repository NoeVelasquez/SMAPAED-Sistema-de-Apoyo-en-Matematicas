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
    public partial class VideoExpo : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public VideoExpo()
        {
            InitializeComponent();
        }

        private void VideoExpo_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el video de dominios");


            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='560' height='315' src='https://www.youtube.com/embed/XdaB464Gt4M' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/XdaB464Gt4M";
            //txtLink.Text.Split('=')[1]
            this.webBrowser1.DocumentText = string.Format(html, text);
            //webBrowser1.Navigate($https://youtu.be/Ll7xfe3HoZE);,
            Avatar.Speak("La función exponencial es aquella que a cada valor real {x} le asigna la potencia a elevado a la X con a mayor cero y a distinto a 1. Esta función se expresa");
            Avatar.Hide(50);
        }
    }
}
