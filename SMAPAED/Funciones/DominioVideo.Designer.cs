﻿namespace SMAPAED
{
    partial class DominioVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DominioVideo));
            this.ControlAgTED = new AxDoubleAgentCtl.AxDaControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.DomVid2 = new System.Windows.Forms.PictureBox();
            this.DomVid1 = new System.Windows.Forms.PictureBox();
            this.Funcion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DomVid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DomVid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Funcion)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlAgTED
            // 
            this.ControlAgTED.Enabled = true;
            this.ControlAgTED.Location = new System.Drawing.Point(773, 35);
            this.ControlAgTED.Name = "ControlAgTED";
            this.ControlAgTED.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ControlAgTED.OcxState")));
            this.ControlAgTED.Size = new System.Drawing.Size(32, 32);
            this.ControlAgTED.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(590, 340);
            this.webBrowser1.TabIndex = 2;
            // 
            // DomVid2
            // 
            this.DomVid2.Image = ((System.Drawing.Image)(resources.GetObject("DomVid2.Image")));
            this.DomVid2.Location = new System.Drawing.Point(642, 158);
            this.DomVid2.Name = "DomVid2";
            this.DomVid2.Size = new System.Drawing.Size(332, 35);
            this.DomVid2.TabIndex = 7;
            this.DomVid2.TabStop = false;
            // 
            // DomVid1
            // 
            this.DomVid1.Image = ((System.Drawing.Image)(resources.GetObject("DomVid1.Image")));
            this.DomVid1.Location = new System.Drawing.Point(733, 109);
            this.DomVid1.Name = "DomVid1";
            this.DomVid1.Size = new System.Drawing.Size(135, 33);
            this.DomVid1.TabIndex = 6;
            this.DomVid1.TabStop = false;
            // 
            // Funcion
            // 
            this.Funcion.BackColor = System.Drawing.Color.Transparent;
            this.Funcion.Image = global::SMAPAED.Properties.Resources.funcion_exponencial;
            this.Funcion.Location = new System.Drawing.Point(608, 199);
            this.Funcion.Name = "Funcion";
            this.Funcion.Size = new System.Drawing.Size(366, 266);
            this.Funcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Funcion.TabIndex = 5;
            this.Funcion.TabStop = false;
            // 
            // DominioVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(986, 477);
            this.Controls.Add(this.DomVid2);
            this.Controls.Add(this.DomVid1);
            this.Controls.Add(this.Funcion);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ControlAgTED);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DominioVideo";
            this.Text = "IntroFunTeo";
            this.Load += new System.EventHandler(this.IntroFunTeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DomVid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DomVid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Funcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxDoubleAgentCtl.AxDaControl ControlAgTED;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox Funcion;
        private System.Windows.Forms.PictureBox DomVid1;
        private System.Windows.Forms.PictureBox DomVid2;
    }
}