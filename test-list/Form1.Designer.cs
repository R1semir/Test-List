namespace test_list
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
            this.btnListele1 = new System.Windows.Forms.Button();
            this.btnListele2 = new System.Windows.Forms.Button();
            this.btnListele3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnListele4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele1
            // 
            this.btnListele1.Location = new System.Drawing.Point(23, 337);
            this.btnListele1.Name = "btnListele1";
            this.btnListele1.Size = new System.Drawing.Size(204, 28);
            this.btnListele1.TabIndex = 0;
            this.btnListele1.Text = "Listele";
            this.btnListele1.UseVisualStyleBackColor = true;
            this.btnListele1.Click += new System.EventHandler(this.btnListele1_Click);
            // 
            // btnListele2
            // 
            this.btnListele2.Location = new System.Drawing.Point(311, 337);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(204, 28);
            this.btnListele2.TabIndex = 1;
            this.btnListele2.Text = "Listele2";
            this.btnListele2.UseVisualStyleBackColor = true;
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // btnListele3
            // 
            this.btnListele3.Location = new System.Drawing.Point(588, 337);
            this.btnListele3.Name = "btnListele3";
            this.btnListele3.Size = new System.Drawing.Size(204, 28);
            this.btnListele3.TabIndex = 2;
            this.btnListele3.Text = "Listele3";
            this.btnListele3.UseVisualStyleBackColor = true;
            this.btnListele3.Click += new System.EventHandler(this.btnListele3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 290);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(311, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(204, 290);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(588, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(204, 290);
            this.listBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(308, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sayı Ara =";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(835, 12);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(255, 290);
            this.listBox4.TabIndex = 10;
            // 
            // btnListele4
            // 
            this.btnListele4.Location = new System.Drawing.Point(835, 337);
            this.btnListele4.Name = "btnListele4";
            this.btnListele4.Size = new System.Drawing.Size(255, 28);
            this.btnListele4.TabIndex = 9;
            this.btnListele4.Text = "Listele4";
            this.btnListele4.UseVisualStyleBackColor = true;
            this.btnListele4.Click += new System.EventHandler(this.btnListele4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 381);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnListele4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListele3);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.btnListele1);
            this.Name = "Form1";
            this.Text = "List-Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele1;
        private System.Windows.Forms.Button btnListele2;
        private System.Windows.Forms.Button btnListele3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btnListele4;
    }
}

