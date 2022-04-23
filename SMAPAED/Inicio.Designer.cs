namespace SMAPAED
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.ControlAg = new AxDoubleAgentCtl.AxDaControl();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAgregarUsuario = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAg)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlAg
            // 
            this.ControlAg.Enabled = true;
            this.ControlAg.Location = new System.Drawing.Point(408, 120);
            this.ControlAg.Name = "ControlAg";
            this.ControlAg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ControlAg.OcxState")));
            this.ControlAg.Size = new System.Drawing.Size(32, 32);
            this.ControlAg.TabIndex = 15;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(399, 251);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "button3";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(249, 251);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarUsuario.TabIndex = 13;
            this.BtnAgregarUsuario.Text = "button2";
            this.BtnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(78, 251);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 12;
            this.BtnIngresar.Text = "button1";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtContraseña.Location = new System.Drawing.Point(163, 154);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(100, 20);
            this.TxtContraseña.TabIndex = 11;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtUsuario.Location = new System.Drawing.Point(163, 109);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(111, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(108, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 302);
            this.Controls.Add(this.ControlAg);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregarUsuario);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlAg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxDoubleAgentCtl.AxDaControl ControlAg;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAgregarUsuario;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}