namespace SMAPAED
{
    partial class Ejercicio2Logar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio2Logar));
            this.SolucionEj1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SolucionEj2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SolucionEj1.SuspendLayout();
            this.SolucionEj2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolucionEj1
            // 
            this.SolucionEj1.BackColor = System.Drawing.Color.DarkGray;
            this.SolucionEj1.Controls.Add(this.label1);
            this.SolucionEj1.Location = new System.Drawing.Point(101, 42);
            this.SolucionEj1.Name = "SolucionEj1";
            this.SolucionEj1.Size = new System.Drawing.Size(790, 174);
            this.SolucionEj1.TabIndex = 42;
            this.SolucionEj1.TabStop = false;
            this.SolucionEj1.Text = "Respuesta";
            this.SolucionEj1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 144);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aquí, tenemos que usar la regla del producto para combinar los logaritmos de la p" +
    "arte \r\nderecha de la expresión:\r\n \\log(x)=\\log(2)+\\log(5)\r\n \\log(x)=\\log(2\\times" +
    " 5)\r\n \\log(x)=\\log(10)\r\nx=10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Location = new System.Drawing.Point(20, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "SOLUCION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Resuelve la función logarítmica  \\log(x)=\\log(2)+\\log(5).";
            // 
            // SolucionEj2
            // 
            this.SolucionEj2.BackColor = System.Drawing.Color.LightGray;
            this.SolucionEj2.Controls.Add(this.label7);
            this.SolucionEj2.Location = new System.Drawing.Point(101, 252);
            this.SolucionEj2.Name = "SolucionEj2";
            this.SolucionEj2.Size = new System.Drawing.Size(790, 288);
            this.SolucionEj2.TabIndex = 45;
            this.SolucionEj2.TabStop = false;
            this.SolucionEj2.Text = "Respuesta";
            this.SolucionEj2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(704, 264);
            this.label7.TabIndex = 0;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.Location = new System.Drawing.Point(20, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "SOLUCION";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(16, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(348, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Resuelve la función logarítmica  \\log_{x}(4x-3)=2.\r\n";
            // 
            // Ejercicio2Logar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 591);
            this.Controls.Add(this.SolucionEj2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SolucionEj1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejercicio2Logar";
            this.Text = "Ejercicio2Logar";
            this.SolucionEj1.ResumeLayout(false);
            this.SolucionEj1.PerformLayout();
            this.SolucionEj2.ResumeLayout(false);
            this.SolucionEj2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox SolucionEj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox SolucionEj2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
    }
}