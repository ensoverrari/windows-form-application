
namespace HYS
{
    partial class DoktorBilgiGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbdoktorgüncellead = new System.Windows.Forms.TextBox();
            this.tbdoktorgüncellesoyad = new System.Windows.Forms.TextBox();
            this.tbdoktorguncellesifre = new System.Windows.Forms.TextBox();
            this.mtbdoktorgüncelletc = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoktorguncellebrans = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCKN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Branş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şifre :";
            // 
            // tbdoktorgüncellead
            // 
            this.tbdoktorgüncellead.Location = new System.Drawing.Point(158, 37);
            this.tbdoktorgüncellead.Name = "tbdoktorgüncellead";
            this.tbdoktorgüncellead.Size = new System.Drawing.Size(162, 32);
            this.tbdoktorgüncellead.TabIndex = 1;
            // 
            // tbdoktorgüncellesoyad
            // 
            this.tbdoktorgüncellesoyad.Location = new System.Drawing.Point(158, 87);
            this.tbdoktorgüncellesoyad.Name = "tbdoktorgüncellesoyad";
            this.tbdoktorgüncellesoyad.Size = new System.Drawing.Size(162, 32);
            this.tbdoktorgüncellesoyad.TabIndex = 2;
            // 
            // tbdoktorguncellesifre
            // 
            this.tbdoktorguncellesifre.Location = new System.Drawing.Point(158, 240);
            this.tbdoktorguncellesifre.Name = "tbdoktorguncellesifre";
            this.tbdoktorguncellesifre.Size = new System.Drawing.Size(162, 32);
            this.tbdoktorguncellesifre.TabIndex = 5;
            // 
            // mtbdoktorgüncelletc
            // 
            this.mtbdoktorgüncelletc.Location = new System.Drawing.Point(158, 138);
            this.mtbdoktorgüncelletc.Mask = "00000000000";
            this.mtbdoktorgüncelletc.Name = "mtbdoktorgüncelletc";
            this.mtbdoktorgüncelletc.Size = new System.Drawing.Size(162, 32);
            this.mtbdoktorgüncelletc.TabIndex = 3;
            this.mtbdoktorgüncelletc.ValidatingType = typeof(int);
            // 
            // cmbdoktorguncellebrans
            // 
            this.cmbdoktorguncellebrans.FormattingEnabled = true;
            this.cmbdoktorguncellebrans.Location = new System.Drawing.Point(158, 189);
            this.cmbdoktorguncellebrans.Name = "cmbdoktorguncellebrans";
            this.cmbdoktorguncellebrans.Size = new System.Drawing.Size(162, 36);
            this.cmbdoktorguncellebrans.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DoktorBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbdoktorguncellebrans);
            this.Controls.Add(this.mtbdoktorgüncelletc);
            this.Controls.Add(this.tbdoktorguncellesifre);
            this.Controls.Add(this.tbdoktorgüncellesoyad);
            this.Controls.Add(this.tbdoktorgüncellead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("OpenSymbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoktorBilgiGuncelle";
            this.Text = "DoktorBilgiGuncelle";
            this.Load += new System.EventHandler(this.DoktorBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbdoktorgüncellead;
        private System.Windows.Forms.TextBox tbdoktorgüncellesoyad;
        private System.Windows.Forms.TextBox tbdoktorguncellesifre;
        private System.Windows.Forms.MaskedTextBox mtbdoktorgüncelletc;
        private System.Windows.Forms.ComboBox cmbdoktorguncellebrans;
        private System.Windows.Forms.Button button1;
    }
}