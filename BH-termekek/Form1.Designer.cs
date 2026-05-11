namespace BH_termekek
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
            this.termekekdgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sorszam = new System.Windows.Forms.TextBox();
            this.beolv = new System.Windows.Forms.Button();
            this.mutat1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hanyadika = new System.Windows.Forms.TextBox();
            this.muti = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keres = new System.Windows.Forms.TextBox();
            this.mutika = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.datum = new System.Windows.Forms.TextBox();
            this.mutatfinal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.termekekdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // termekekdgv
            // 
            this.termekekdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termekekdgv.Location = new System.Drawing.Point(342, 12);
            this.termekekdgv.Name = "termekekdgv";
            this.termekekdgv.Size = new System.Drawing.Size(893, 306);
            this.termekekdgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adja meg a termék sorszámát:";
            // 
            // sorszam
            // 
            this.sorszam.Location = new System.Drawing.Point(156, 24);
            this.sorszam.Name = "sorszam";
            this.sorszam.Size = new System.Drawing.Size(100, 20);
            this.sorszam.TabIndex = 2;
            this.sorszam.TextChanged += new System.EventHandler(this.sorszam_TextChanged);
            // 
            // beolv
            // 
            this.beolv.Location = new System.Drawing.Point(1160, 333);
            this.beolv.Name = "beolv";
            this.beolv.Size = new System.Drawing.Size(75, 23);
            this.beolv.TabIndex = 3;
            this.beolv.Text = "Beolvasás";
            this.beolv.UseVisualStyleBackColor = true;
            this.beolv.Click += new System.EventHandler(this.beolv_Click);
            // 
            // mutat1
            // 
            this.mutat1.Location = new System.Drawing.Point(262, 22);
            this.mutat1.Name = "mutat1";
            this.mutat1.Size = new System.Drawing.Size(75, 23);
            this.mutat1.TabIndex = 4;
            this.mutat1.Text = "Mutat";
            this.mutat1.UseVisualStyleBackColor = true;
            this.mutat1.Click += new System.EventHandler(this.mutat1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adja meg a hónap napját";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hanyadika
            // 
            this.hanyadika.Location = new System.Drawing.Point(156, 50);
            this.hanyadika.Name = "hanyadika";
            this.hanyadika.Size = new System.Drawing.Size(100, 20);
            this.hanyadika.TabIndex = 2;
            this.hanyadika.TextChanged += new System.EventHandler(this.sorszam_TextChanged);
            // 
            // muti
            // 
            this.muti.Location = new System.Drawing.Point(262, 48);
            this.muti.Name = "muti";
            this.muti.Size = new System.Drawing.Size(75, 23);
            this.muti.TabIndex = 5;
            this.muti.Text = "Mutat";
            this.muti.UseVisualStyleBackColor = true;
            this.muti.Click += new System.EventHandler(this.muti_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Keresés";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // keres
            // 
            this.keres.Location = new System.Drawing.Point(156, 82);
            this.keres.Name = "keres";
            this.keres.Size = new System.Drawing.Size(100, 20);
            this.keres.TabIndex = 2;
            this.keres.TextChanged += new System.EventHandler(this.sorszam_TextChanged);
            // 
            // mutika
            // 
            this.mutika.Location = new System.Drawing.Point(262, 80);
            this.mutika.Name = "mutika";
            this.mutika.Size = new System.Drawing.Size(75, 23);
            this.mutika.TabIndex = 6;
            this.mutika.Text = "Mutat";
            this.mutika.UseVisualStyleBackColor = true;
            this.mutika.Click += new System.EventHandler(this.mutika_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Keresés";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Keresés";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.sorszam_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Keresés";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.sorszam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Keresés";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.sorszam_TextChanged);
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(156, 121);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(100, 20);
            this.datum.TabIndex = 2;
            this.datum.TextChanged += new System.EventHandler(this.sorszam_TextChanged);
            // 
            // mutatfinal
            // 
            this.mutatfinal.Location = new System.Drawing.Point(262, 121);
            this.mutatfinal.Name = "mutatfinal";
            this.mutatfinal.Size = new System.Drawing.Size(75, 23);
            this.mutatfinal.TabIndex = 7;
            this.mutatfinal.Text = "Mutat";
            this.mutatfinal.UseVisualStyleBackColor = true;
            this.mutatfinal.Click += new System.EventHandler(this.mutatfinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 450);
            this.Controls.Add(this.mutatfinal);
            this.Controls.Add(this.mutika);
            this.Controls.Add(this.muti);
            this.Controls.Add(this.mutat1);
            this.Controls.Add(this.beolv);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.keres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hanyadika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sorszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.termekekdgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.termekekdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView termekekdgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sorszam;
        private System.Windows.Forms.Button beolv;
        private System.Windows.Forms.Button mutat1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hanyadika;
        private System.Windows.Forms.Button muti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keres;
        private System.Windows.Forms.Button mutika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox datum;
        private System.Windows.Forms.Button mutatfinal;
    }
}

