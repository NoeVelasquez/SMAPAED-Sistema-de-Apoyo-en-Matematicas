﻿namespace SMAPAED
{
    partial class DefinicionVideoDer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinicionVideoDer));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ControlAgTED = new AxDoubleAgentCtl.AxDaControl();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 21);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(948, 585);
            this.webBrowser1.TabIndex = 4;
            // 
            // ControlAgTED
            // 
            this.ControlAgTED.Enabled = true;
            this.ControlAgTED.Location = new System.Drawing.Point(960, 12);
            this.ControlAgTED.Name = "ControlAgTED";
            this.ControlAgTED.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ControlAgTED.OcxState")));
            this.ControlAgTED.Size = new System.Drawing.Size(32, 32);
            this.ControlAgTED.TabIndex = 3;
            // 
            // DefinicionVideoDer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1004, 630);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ControlAgTED);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DefinicionVideoDer";
            this.Text = "DefinicionVideoDer";
            this.Load += new System.EventHandler(this.DefinicionVideoDer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private AxDoubleAgentCtl.AxDaControl ControlAgTED;
    }
}