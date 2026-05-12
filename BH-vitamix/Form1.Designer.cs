namespace BH_vitamix
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.termekek = new System.Windows.Forms.ComboBox();
            this.kiszerelesdb = new System.Windows.Forms.Label();
            this.vasarlok = new System.Windows.Forms.ListBox();
            this.osszertek = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(22, 251);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(362, 141);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(515, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 55);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // termekek
            // 
            this.termekek.FormattingEnabled = true;
            this.termekek.Location = new System.Drawing.Point(104, 47);
            this.termekek.Name = "termekek";
            this.termekek.Size = new System.Drawing.Size(184, 24);
            this.termekek.TabIndex = 2;
            this.termekek.SelectedIndexChanged += new System.EventHandler(this.termekek_SelectedIndexChanged);
            // 
            // kiszerelesdb
            // 
            this.kiszerelesdb.AutoSize = true;
            this.kiszerelesdb.Location = new System.Drawing.Point(101, 203);
            this.kiszerelesdb.Name = "kiszerelesdb";
            this.kiszerelesdb.Size = new System.Drawing.Size(125, 16);
            this.kiszerelesdb.TabIndex = 3;
            this.kiszerelesdb.Text = "Válassz kiszerelést!";
            // 
            // vasarlok
            // 
            this.vasarlok.FormattingEnabled = true;
            this.vasarlok.ItemHeight = 16;
            this.vasarlok.Location = new System.Drawing.Point(553, 47);
            this.vasarlok.Name = "vasarlok";
            this.vasarlok.Size = new System.Drawing.Size(120, 84);
            this.vasarlok.TabIndex = 4;
            this.vasarlok.SelectedIndexChanged += new System.EventHandler(this.vasarlok_SelectedIndexChanged);
            // 
            // osszertek
            // 
            this.osszertek.Location = new System.Drawing.Point(553, 203);
            this.osszertek.Name = "osszertek";
            this.osszertek.Size = new System.Drawing.Size(100, 22);
            this.osszertek.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osszertek);
            this.Controls.Add(this.vasarlok);
            this.Controls.Add(this.kiszerelesdb);
            this.Controls.Add(this.termekek);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox termekek;
        private System.Windows.Forms.Label kiszerelesdb;
        private System.Windows.Forms.ListBox vasarlok;
        private System.Windows.Forms.TextBox osszertek;
    }
}

