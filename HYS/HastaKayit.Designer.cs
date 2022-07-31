
namespace HYS
{
    partial class HastaKayit
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbhastakayitcinsiyet = new System.Windows.Forms.ComboBox();
            this.mtbhastakayittel = new System.Windows.Forms.MaskedTextBox();
            this.mtbhastakayittc = new System.Windows.Forms.MaskedTextBox();
            this.tbhastakayitsifre = new System.Windows.Forms.TextBox();
            this.tbhastakayitsoyad = new System.Windows.Forms.TextBox();
            this.tbhastakayitad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbhastakayitcinsiyet
            // 
            this.cbhastakayitcinsiyet.FormattingEnabled = true;
            this.cbhastakayitcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Belirtmek İstemiyor"});
            this.cbhastakayitcinsiyet.Location = new System.Drawing.Point(329, 257);
            this.cbhastakayitcinsiyet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbhastakayitcinsiyet.Name = "cbhastakayitcinsiyet";
            this.cbhastakayitcinsiyet.Size = new System.Drawing.Size(266, 36);
            this.cbhastakayitcinsiyet.TabIndex = 6;
            // 
            // mtbhastakayittel
            // 
            this.mtbhastakayittel.Location = new System.Drawing.Point(329, 153);
            this.mtbhastakayittel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbhastakayittel.Mask = "(999) 000-0000";
            this.mtbhastakayittel.Name = "mtbhastakayittel";
            this.mtbhastakayittel.Size = new System.Drawing.Size(266, 32);
            this.mtbhastakayittel.TabIndex = 4;
            // 
            // mtbhastakayittc
            // 
            this.mtbhastakayittc.Location = new System.Drawing.Point(329, 111);
            this.mtbhastakayittc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbhastakayittc.Mask = "00000000000";
            this.mtbhastakayittc.Name = "mtbhastakayittc";
            this.mtbhastakayittc.Size = new System.Drawing.Size(266, 32);
            this.mtbhastakayittc.TabIndex = 3;
            this.mtbhastakayittc.ValidatingType = typeof(int);
            // 
            // tbhastakayitsifre
            // 
            this.tbhastakayitsifre.Location = new System.Drawing.Point(329, 206);
            this.tbhastakayitsifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbhastakayitsifre.Name = "tbhastakayitsifre";
            this.tbhastakayitsifre.Size = new System.Drawing.Size(266, 32);
            this.tbhastakayitsifre.TabIndex = 5;
            // 
            // tbhastakayitsoyad
            // 
            this.tbhastakayitsoyad.Location = new System.Drawing.Point(329, 62);
            this.tbhastakayitsoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbhastakayitsoyad.Name = "tbhastakayitsoyad";
            this.tbhastakayitsoyad.Size = new System.Drawing.Size(266, 32);
            this.tbhastakayitsoyad.TabIndex = 2;
            // 
            // tbhastakayitad
            // 
            this.tbhastakayitad.Location = new System.Drawing.Point(329, 20);
            this.tbhastakayitad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbhastakayitad.Name = "tbhastakayitad";
            this.tbhastakayitad.Size = new System.Drawing.Size(266, 32);
            this.tbhastakayitad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefon No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adı :";
            // 
            // HastaKayit
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbhastakayitcinsiyet);
            this.Controls.Add(this.mtbhastakayittel);
            this.Controls.Add(this.mtbhastakayittc);
            this.Controls.Add(this.tbhastakayitsifre);
            this.Controls.Add(this.tbhastakayitsoyad);
            this.Controls.Add(this.tbhastakayitad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("OpenSymbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HastaKayit";
            this.Text = "HastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbhastakayitcinsiyet;
        private System.Windows.Forms.MaskedTextBox mtbhastakayittel;
        private System.Windows.Forms.MaskedTextBox mtbhastakayittc;
        private System.Windows.Forms.TextBox tbhastakayitsifre;
        private System.Windows.Forms.TextBox tbhastakayitsoyad;
        private System.Windows.Forms.TextBox tbhastakayitad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}