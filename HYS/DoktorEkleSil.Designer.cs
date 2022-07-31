
namespace HYS
{
    partial class DoktorEkleSil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbdoktoreklesilbrans = new System.Windows.Forms.ComboBox();
            this.tbdoktoreklesilad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbdoktoreklesilsoyad = new System.Windows.Forms.TextBox();
            this.tbdoktoreklesilsifre = new System.Windows.Forms.TextBox();
            this.mtbdoktoreklesiltc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 389);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbdoktoreklesilbrans
            // 
            this.cbdoktoreklesilbrans.FormattingEnabled = true;
            this.cbdoktoreklesilbrans.Location = new System.Drawing.Point(149, 194);
            this.cbdoktoreklesilbrans.Name = "cbdoktoreklesilbrans";
            this.cbdoktoreklesilbrans.Size = new System.Drawing.Size(145, 36);
            this.cbdoktoreklesilbrans.TabIndex = 11;
            // 
            // tbdoktoreklesilad
            // 
            this.tbdoktoreklesilad.Location = new System.Drawing.Point(149, 29);
            this.tbdoktoreklesilad.Name = "tbdoktoreklesilad";
            this.tbdoktoreklesilad.Size = new System.Drawing.Size(145, 32);
            this.tbdoktoreklesilad.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "TCKN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Branş :";
            // 
            // tbdoktoreklesilsoyad
            // 
            this.tbdoktoreklesilsoyad.Location = new System.Drawing.Point(149, 85);
            this.tbdoktoreklesilsoyad.Name = "tbdoktoreklesilsoyad";
            this.tbdoktoreklesilsoyad.Size = new System.Drawing.Size(145, 32);
            this.tbdoktoreklesilsoyad.TabIndex = 10;
            // 
            // tbdoktoreklesilsifre
            // 
            this.tbdoktoreklesilsifre.Location = new System.Drawing.Point(149, 253);
            this.tbdoktoreklesilsifre.Name = "tbdoktoreklesilsifre";
            this.tbdoktoreklesilsifre.Size = new System.Drawing.Size(145, 32);
            this.tbdoktoreklesilsifre.TabIndex = 10;
            // 
            // mtbdoktoreklesiltc
            // 
            this.mtbdoktoreklesiltc.Location = new System.Drawing.Point(149, 141);
            this.mtbdoktoreklesiltc.Mask = "00000000000";
            this.mtbdoktoreklesiltc.Name = "mtbdoktoreklesiltc";
            this.mtbdoktoreklesiltc.Size = new System.Drawing.Size(145, 32);
            this.mtbdoktoreklesiltc.TabIndex = 16;
            this.mtbdoktoreklesiltc.ValidatingType = typeof(int);
            // 
            // DoktorEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 439);
            this.Controls.Add(this.mtbdoktoreklesiltc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbdoktoreklesilbrans);
            this.Controls.Add(this.tbdoktoreklesilsifre);
            this.Controls.Add(this.tbdoktoreklesilsoyad);
            this.Controls.Add(this.tbdoktoreklesilad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("OpenSymbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoktorEkleSil";
            this.Text = "DoktorEkleSil";
            this.Load += new System.EventHandler(this.DoktorEkleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbdoktoreklesilbrans;
        private System.Windows.Forms.TextBox tbdoktoreklesilad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbdoktoreklesilsoyad;
        private System.Windows.Forms.TextBox tbdoktoreklesilsifre;
        private System.Windows.Forms.MaskedTextBox mtbdoktoreklesiltc;
    }
}