namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnArttir = new System.Windows.Forms.Button();
            this.btnBildin = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAltSinir = new System.Windows.Forms.TextBox();
            this.tbUstSinir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDenemeSayisi = new System.Windows.Forms.Label();
            this.btnYenidenOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(456, 24);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(97, 78);
            this.btnAzalt.TabIndex = 0;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnArttir
            // 
            this.btnArttir.Location = new System.Drawing.Point(456, 104);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(97, 78);
            this.btnArttir.TabIndex = 1;
            this.btnArttir.Text = "Arttır";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.btnArttir_Click);
            // 
            // btnBildin
            // 
            this.btnBildin.Location = new System.Drawing.Point(26, 104);
            this.btnBildin.Name = "btnBildin";
            this.btnBildin.Size = new System.Drawing.Size(97, 78);
            this.btnBildin.TabIndex = 4;
            this.btnBildin.Text = "Bildin";
            this.btnBildin.UseVisualStyleBackColor = true;
            this.btnBildin.Click += new System.EventHandler(this.btnBildin_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(26, 24);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(97, 78);
            this.btnBasla.TabIndex = 5;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblTahmin
            // 
            this.lblTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.Location = new System.Drawing.Point(129, 24);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(321, 158);
            this.lblTahmin.TabIndex = 6;
            this.lblTahmin.Text = "0";
            this.lblTahmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alt Sınır";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Üst Sınır";
            // 
            // tbAltSinir
            // 
            this.tbAltSinir.Location = new System.Drawing.Point(80, 218);
            this.tbAltSinir.MaxLength = 3;
            this.tbAltSinir.Name = "tbAltSinir";
            this.tbAltSinir.Size = new System.Drawing.Size(100, 20);
            this.tbAltSinir.TabIndex = 9;
            // 
            // tbUstSinir
            // 
            this.tbUstSinir.Location = new System.Drawing.Point(80, 241);
            this.tbUstSinir.MaxLength = 3;
            this.tbUstSinir.Name = "tbUstSinir";
            this.tbUstSinir.Size = new System.Drawing.Size(100, 20);
            this.tbUstSinir.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(335, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Deneme Sayisi :";
            // 
            // lblDenemeSayisi
            // 
            this.lblDenemeSayisi.AutoSize = true;
            this.lblDenemeSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDenemeSayisi.Location = new System.Drawing.Point(468, 193);
            this.lblDenemeSayisi.Name = "lblDenemeSayisi";
            this.lblDenemeSayisi.Size = new System.Drawing.Size(71, 76);
            this.lblDenemeSayisi.TabIndex = 12;
            this.lblDenemeSayisi.Text = "0";
            this.lblDenemeSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYenidenOyna
            // 
            this.btnYenidenOyna.Location = new System.Drawing.Point(26, 267);
            this.btnYenidenOyna.Name = "btnYenidenOyna";
            this.btnYenidenOyna.Size = new System.Drawing.Size(527, 44);
            this.btnYenidenOyna.TabIndex = 13;
            this.btnYenidenOyna.Text = "Yeniden Oyna";
            this.btnYenidenOyna.UseVisualStyleBackColor = true;
            this.btnYenidenOyna.Click += new System.EventHandler(this.btnYenidenOyna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 319);
            this.Controls.Add(this.btnYenidenOyna);
            this.Controls.Add(this.lblDenemeSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUstSinir);
            this.Controls.Add(this.tbAltSinir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnBildin);
            this.Controls.Add(this.btnArttir);
            this.Controls.Add(this.btnAzalt);
            this.Name = "Form1";
            this.Text = "Bilgisayar Bilsin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnArttir;
        private System.Windows.Forms.Button btnBildin;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAltSinir;
        private System.Windows.Forms.TextBox tbUstSinir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDenemeSayisi;
        private System.Windows.Forms.Button btnYenidenOyna;
    }
}

