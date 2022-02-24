namespace UAS_OOP_1204036
{
    partial class Mahasiswa
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNpm = new System.Windows.Forms.TextBox();
            this.NamaMhs = new System.Windows.Forms.TextBox();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.SubmitMhs = new System.Windows.Forms.Button();
            this.ClearMhs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Mahasiswa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nama Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Program Studi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = ":";
            // 
            // tbNpm
            // 
            this.tbNpm.Location = new System.Drawing.Point(194, 91);
            this.tbNpm.Name = "tbNpm";
            this.tbNpm.Size = new System.Drawing.Size(142, 20);
            this.tbNpm.TabIndex = 16;
            // 
            // NamaMhs
            // 
            this.NamaMhs.Location = new System.Drawing.Point(194, 125);
            this.NamaMhs.Name = "NamaMhs";
            this.NamaMhs.Size = new System.Drawing.Size(142, 20);
            this.NamaMhs.TabIndex = 17;
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Location = new System.Drawing.Point(194, 156);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(142, 21);
            this.cbProdi.TabIndex = 18;
            this.cbProdi.SelectedIndexChanged += new System.EventHandler(this.cbProdi_SelectedIndexChanged);
            // 
            // SubmitMhs
            // 
            this.SubmitMhs.Location = new System.Drawing.Point(75, 207);
            this.SubmitMhs.Name = "SubmitMhs";
            this.SubmitMhs.Size = new System.Drawing.Size(75, 23);
            this.SubmitMhs.TabIndex = 19;
            this.SubmitMhs.Text = "Submit";
            this.SubmitMhs.UseVisualStyleBackColor = true;
            this.SubmitMhs.Click += new System.EventHandler(this.SubmitMhs_Click);
            // 
            // ClearMhs
            // 
            this.ClearMhs.Location = new System.Drawing.Point(208, 207);
            this.ClearMhs.Name = "ClearMhs";
            this.ClearMhs.Size = new System.Drawing.Size(75, 23);
            this.ClearMhs.TabIndex = 20;
            this.ClearMhs.Text = "Clear";
            this.ClearMhs.UseVisualStyleBackColor = true;
            this.ClearMhs.Click += new System.EventHandler(this.ClearMhs_Click);
            // 
            // Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 274);
            this.Controls.Add(this.ClearMhs);
            this.Controls.Add(this.SubmitMhs);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.NamaMhs);
            this.Controls.Add(this.tbNpm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Mahasiswa";
            this.Text = "Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNpm;
        private System.Windows.Forms.TextBox NamaMhs;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Button SubmitMhs;
        private System.Windows.Forms.Button ClearMhs;
    }
}