
namespace HYS
{
    partial class SekreterGiris
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
            this.btnsekretergiris = new System.Windows.Forms.Button();
            this.tbsekretergirissifre = new System.Windows.Forms.TextBox();
            this.mtbsekretergiristc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsekretergiris
            // 
            this.btnsekretergiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsekretergiris.Location = new System.Drawing.Point(312, 212);
            this.btnsekretergiris.Name = "btnsekretergiris";
            this.btnsekretergiris.Size = new System.Drawing.Size(167, 36);
            this.btnsekretergiris.TabIndex = 9;
            this.btnsekretergiris.Text = "Giriş Yap";
            this.btnsekretergiris.UseVisualStyleBackColor = true;
            this.btnsekretergiris.Click += new System.EventHandler(this.btnsekretergiris_Click);
            // 
            // tbsekretergirissifre
            // 
            this.tbsekretergirissifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsekretergirissifre.Location = new System.Drawing.Point(289, 152);
            this.tbsekretergirissifre.Name = "tbsekretergirissifre";
            this.tbsekretergirissifre.Size = new System.Drawing.Size(223, 34);
            this.tbsekretergirissifre.TabIndex = 8;
            this.tbsekretergirissifre.UseSystemPasswordChar = true;
            // 
            // mtbsekretergiristc
            // 
            this.mtbsekretergiristc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbsekretergiristc.Location = new System.Drawing.Point(289, 92);
            this.mtbsekretergiristc.Mask = "00000000000";
            this.mtbsekretergiristc.Name = "mtbsekretergiristc";
            this.mtbsekretergiristc.Size = new System.Drawing.Size(223, 34);
            this.mtbsekretergiristc.TabIndex = 7;
            this.mtbsekretergiristc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(158, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "TCKN :";
            // 
            // SekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsekretergiris);
            this.Controls.Add(this.tbsekretergirissifre);
            this.Controls.Add(this.mtbsekretergiristc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SekreterGiris";
            this.Text = "SekreterGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsekretergiris;
        private System.Windows.Forms.TextBox tbsekretergirissifre;
        private System.Windows.Forms.MaskedTextBox mtbsekretergiristc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}