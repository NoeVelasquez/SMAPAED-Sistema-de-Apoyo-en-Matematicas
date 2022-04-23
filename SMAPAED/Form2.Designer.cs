namespace SMAPAED
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ControlAgEVA = new AxDoubleAgentCtl.AxDaControl();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgEVA)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlAgEVA
            // 
            this.ControlAgEVA.Enabled = true;
            this.ControlAgEVA.Location = new System.Drawing.Point(539, 186);
            this.ControlAgEVA.Name = "ControlAgEVA";
            this.ControlAgEVA.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ControlAgEVA.OcxState")));
            this.ControlAgEVA.Size = new System.Drawing.Size(32, 32);
            this.ControlAgEVA.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlAgEVA);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgEVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxDoubleAgentCtl.AxDaControl ControlAgEVA;
    }
}