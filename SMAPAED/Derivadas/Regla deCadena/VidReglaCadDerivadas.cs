using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMAPAED
{
    public partial class VidReglaCadDerivadas : Form
    {
        public VidReglaCadDerivadas()
        {
            InitializeComponent();
        }

        private void VidReglaCadDerivadas_Load(object sender, EventArgs e)
        {
            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='920' height='565' src='https://www.youtube.com/embed/m_5-WS9Nd68' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/m_5-WS9Nd68";
            //txtLink.Text.Split('=')[1]
            this.webBrowser1.DocumentText = string.Format(html, text);
        }
    }
}
