namespace UAS_OOP_1204036
{
    partial class UpdateMahasiswa
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
            this.dgUpdateMhs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdatePrd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUpdateMhs
            // 
            this.dgUpdateMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpdateMhs.Location = new System.Drawing.Point(66, 75);
            this.dgUpdateMhs.Name = "dgUpdateMhs";
            this.dgUpdateMhs.Size = new System.Drawing.Size(443, 193);
            this.dgUpdateMhs.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Update Data Mahasiswa";
            // 
            // UpdatePrd
            // 
            this.UpdatePrd.Location = new System.Drawing.Point(250, 285);
            this.UpdatePrd.Name = "UpdatePrd";
            this.UpdatePrd.Size = new System.Drawing.Size(75, 23);
            this.UpdatePrd.TabIndex = 8;
            this.UpdatePrd.Text = "Update";
            this.UpdatePrd.UseVisualStyleBackColor = true;
            this.UpdatePrd.Click += new System.EventHandler(this.UpdatePrd_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(28, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "Untuk menghapus data klik pada kotak paling kiri untuk memblok data yang akan dih" +
    "apus atau delete";
            // 
            // UpdateMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdatePrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUpdateMhs);
            this.Name = "UpdateMahasiswa";
            this.Text = "UpdateMahasiswa";
            this.Load += new System.EventHandler(this.UpdateMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUpdateMhs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdatePrd;
        private System.Windows.Forms.Label label2;
    }
}