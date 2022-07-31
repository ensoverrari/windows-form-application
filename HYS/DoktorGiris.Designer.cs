
namespace HYS
{
    partial class DoktorGiris
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
            this.mtbdoktorgiristc = new System.Windows.Forms.MaskedTextBox();
            this.tbdoktorgirissifre = new System.Windows.Forms.TextBox();
            this.btndoktorgiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // mtbdoktorgiristc
            // 
            this.mtbdoktorgiristc.Location = new System.Drawing.Point(275, 77);
            this.mtbdoktorgiristc.Mask = "00000000000";
            this.mtbdoktorgiristc.Name = "mtbdoktorgiristc";
            this.mtbdoktorgiristc.Size = new System.Drawing.Size(223, 32);
            this.mtbdoktorgiristc.TabIndex = 2;
            this.mtbdoktorgiristc.ValidatingType = typeof(int);
            // 
            // tbdoktorgirissifre
            // 
            this.tbdoktorgirissifre.Location = new System.Drawing.Point(275, 137);
            this.tbdoktorgirissifre.Name = "tbdoktorgirissifre";
            this.tbdoktorgirissifre.Size = new System.Drawing.Size(223, 32);
            this.tbdoktorgirissifre.TabIndex = 3;
            // 
            // btndoktorgiris
            // 
            this.btndoktorgiris.Location = new System.Drawing.Point(298, 197);
            this.btndoktorgiris.Name = "btndoktorgiris";
            this.btndoktorgiris.Size = new System.Drawing.Size(167, 36);
            this.btndoktorgiris.TabIndex = 4;
            this.btndoktorgiris.Text = "Giriş Yap";
            this.btndoktorgiris.UseVisualStyleBackColor = true;
            this.btndoktorgiris.Click += new System.EventHandler(this.btndoktorgiris_Click);
            // 
            // DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndoktorgiris);
            this.Controls.Add(this.tbdoktorgirissifre);
            this.Controls.Add(this.mtbdoktorgiristc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("OpenSymbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoktorGiris";
            this.Text = "DoktorGiris";
            this.Load += new System.EventHandler(this.DoktorGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbdoktorgiristc;
        private System.Windows.Forms.TextBox tbdoktorgirissifre;
        private System.Windows.Forms.Button btndoktorgiris;
    }
}