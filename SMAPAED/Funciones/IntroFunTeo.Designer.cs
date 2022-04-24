namespace SMAPAED
{
    partial class IntroFunTeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroFunTeo));
            this.label1 = new System.Windows.Forms.Label();
            this.ControlAgTED = new AxDoubleAgentCtl.AxDaControl();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // ControlAgTED
            // 
            this.ControlAgTED.Enabled = true;
            this.ControlAgTED.Location = new System.Drawing.Point(958, 12);
            this.ControlAgTED.Name = "ControlAgTED";
            this.ControlAgTED.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ControlAgTED.OcxState")));
            this.ControlAgTED.Size = new System.Drawing.Size(32, 32);
            this.ControlAgTED.TabIndex = 1;
            // 
            // IntroFunTeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.ControlAgTED);
            this.Controls.Add(this.label1);
            this.Name = "IntroFunTeo";
            this.Text = "IntroFunTeo";
            this.Load += new System.EventHandler(this.IntroFunTeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AxDoubleAgentCtl.AxDaControl ControlAgTED;
    }
}