namespace UAS_OOP_1204036
{
    partial class ViewMahasiswa
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
            this.dgMhs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMhs
            // 
            this.dgMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMhs.Enabled = false;
            this.dgMhs.Location = new System.Drawing.Point(66, 75);
            this.dgMhs.Name = "dgMhs";
            this.dgMhs.Size = new System.Drawing.Size(443, 193);
            this.dgMhs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tampilan Data Mahasiswa";
            // 
            // ViewMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMhs);
            this.Name = "ViewMahasiswa";
            this.Text = "Tampilan Mahasiswa";
            this.Load += new System.EventHandler(this.ViewMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMhs;
        private System.Windows.Forms.Label label1;
    }
}