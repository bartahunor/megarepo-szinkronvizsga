namespace BH_vegzosok
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.betolt = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.betolt);
            this.flowLayoutPanel1.Controls.Add(this.a);
            this.flowLayoutPanel1.Controls.Add(this.b);
            this.flowLayoutPanel1.Controls.Add(this.c);
            this.flowLayoutPanel1.Controls.Add(this.d);
            this.flowLayoutPanel1.Controls.Add(this.e);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 304);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // betolt
            // 
            this.betolt.AutoSize = true;
            this.betolt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.betolt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.betolt.Location = new System.Drawing.Point(3, 3);
            this.betolt.Name = "betolt";
            this.betolt.Size = new System.Drawing.Size(127, 52);
            this.betolt.TabIndex = 0;
            this.betolt.Text = "CSV BETÖLTÉSE";
            this.betolt.UseVisualStyleBackColor = false;
            this.betolt.Click += new System.EventHandler(this.betolt_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.a.Location = new System.Drawing.Point(136, 3);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(124, 52);
            this.a.TabIndex = 0;
            this.a.Text = "A";
            this.a.UseVisualStyleBackColor = false;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b.Location = new System.Drawing.Point(266, 3);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(121, 52);
            this.b.TabIndex = 0;
            this.b.Text = "B";
            this.b.UseVisualStyleBackColor = false;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.c.Location = new System.Drawing.Point(393, 3);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(128, 52);
            this.c.TabIndex = 0;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.d.Location = new System.Drawing.Point(527, 3);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(119, 52);
            this.d.TabIndex = 0;
            this.d.Text = "D";
            this.d.UseVisualStyleBackColor = false;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.e.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.e.Location = new System.Drawing.Point(652, 3);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(115, 52);
            this.e.TabIndex = 0;
            this.e.Text = "E";
            this.e.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Végzősök";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button betolt;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button e;
    }
}

