namespace UAS_OOP_1204036
{
    partial class UpdateDaftarUlang
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
            this.dgUpdateDaftar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateDaftar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateDaftar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUpdateDaftar
            // 
            this.dgUpdateDaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpdateDaftar.Location = new System.Drawing.Point(37, 144);
            this.dgUpdateDaftar.Name = "dgUpdateDaftar";
            this.dgUpdateDaftar.Size = new System.Drawing.Size(524, 151);
            this.dgUpdateDaftar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Update Data Daftar Ulang";
            // 
            // UpdateDaftar
            // 
            this.UpdateDaftar.Location = new System.Drawing.Point(175, 365);
            this.UpdateDaftar.Name = "UpdateDaftar";
            this.UpdateDaftar.Size = new System.Drawing.Size(75, 23);
            this.UpdateDaftar.TabIndex = 8;
            this.UpdateDaftar.Text = "Update";
            this.UpdateDaftar.UseVisualStyleBackColor = true;
            this.UpdateDaftar.Click += new System.EventHandler(this.UpdateDaftar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UpdateDaftarUlang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UpdateDaftar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUpdateDaftar);
            this.Name = "UpdateDaftarUlang";
            this.Text = "UpdateDaftarUlang";
            this.Load += new System.EventHandler(this.UpdateDaftarUlang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateDaftar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUpdateDaftar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateDaftar;
        private System.Windows.Forms.Button button2;
    }
}