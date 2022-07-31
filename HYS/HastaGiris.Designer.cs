
namespace HYS
{
    partial class HastaGiris
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
            this.btnhastagiris = new System.Windows.Forms.Button();
            this.tbhastagirissifre = new System.Windows.Forms.TextBox();
            this.mtbhastagiristc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblhastagirisuyeol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnhastagiris
            // 
            this.btnhastagiris.Location = new System.Drawing.Point(242, 176);
            this.btnhastagiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhastagiris.Name = "btnhastagiris";
            this.btnhastagiris.Size = new System.Drawing.Size(167, 38);
            this.btnhastagiris.TabIndex = 9;
            this.btnhastagiris.Text = "Giriş Yap";
            this.btnhastagiris.UseVisualStyleBackColor = true;
            this.btnhastagiris.Click += new System.EventHandler(this.btnhastagiris_Click);
            // 
            // tbhastagirissifre
            // 
            this.tbhastagirissifre.Location = new System.Drawing.Point(242, 114);
            this.tbhastagirissifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbhastagirissifre.Name = "tbhastagirissifre";
            this.tbhastagirissifre.Size = new System.Drawing.Size(167, 32);
            this.tbhastagirissifre.TabIndex = 8;
            this.tbhastagirissifre.UseSystemPasswordChar = true;
            // 
            // mtbhastagiristc
            // 
            this.mtbhastagiristc.Location = new System.Drawing.Point(242, 56);
            this.mtbhastagiristc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbhastagiristc.Mask = "00000000000";
            this.mtbhastagiristc.Name = "mtbhastagiristc";
            this.mtbhastagiristc.Size = new System.Drawing.Size(167, 32);
            this.mtbhastagiristc.TabIndex = 7;
            this.mtbhastagiristc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "TCKN :";
            // 
            // lnklblhastagirisuyeol
            // 
            this.lnklblhastagirisuyeol.AutoSize = true;
            this.lnklblhastagirisuyeol.Location = new System.Drawing.Point(666, 9);
            this.lnklblhastagirisuyeol.Name = "lnklblhastagirisuyeol";
            this.lnklblhastagirisuyeol.Size = new System.Drawing.Size(87, 30);
            this.lnklblhastagirisuyeol.TabIndex = 10;
            this.lnklblhastagirisuyeol.TabStop = true;
            this.lnklblhastagirisuyeol.Text = "Üye ol";
            this.lnklblhastagirisuyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblhastagirisuyeol_LinkClicked);
            // 
            // HastaGiris
            // 
            this.AcceptButton = this.btnhastagiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnklblhastagirisuyeol);
            this.Controls.Add(this.btnhastagiris);
            this.Controls.Add(this.tbhastagirissifre);
            this.Controls.Add(this.mtbhastagiristc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("OpenSymbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HastaGiris";
            this.Text = "HastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhastagiris;
        private System.Windows.Forms.TextBox tbhastagirissifre;
        private System.Windows.Forms.MaskedTextBox mtbhastagiristc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblhastagirisuyeol;
    }
}