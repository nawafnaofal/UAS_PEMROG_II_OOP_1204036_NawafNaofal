namespace UAS_OOP_1204036
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.input = new System.Windows.Forms.ToolStripDropDownButton();
            this.mhs = new System.Windows.Forms.ToolStripMenuItem();
            this.prodi = new System.Windows.Forms.ToolStripMenuItem();
            this.Ulang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TampilanProdi = new System.Windows.Forms.ToolStripMenuItem();
            this.TampilanMhs = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePrd = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportDaftarUlang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.input,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // input
            // 
            this.input.AutoSize = false;
            this.input.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.input.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mhs,
            this.prodi,
            this.Ulang});
            this.input.Image = ((System.Drawing.Image)(resources.GetObject("input.Image")));
            this.input.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.input.Name = "input";
            this.input.ShowDropDownArrow = false;
            this.input.Size = new System.Drawing.Size(48, 22);
            this.input.Text = "I&nput";
            // 
            // mhs
            // 
            this.mhs.Name = "mhs";
            this.mhs.Size = new System.Drawing.Size(180, 22);
            this.mhs.Text = "Mahasiswa";
            this.mhs.Click += new System.EventHandler(this.mhs_Click);
            // 
            // prodi
            // 
            this.prodi.Name = "prodi";
            this.prodi.Size = new System.Drawing.Size(180, 22);
            this.prodi.Text = "Prodi";
            this.prodi.Click += new System.EventHandler(this.prodi_Click);
            // 
            // Ulang
            // 
            this.Ulang.Name = "Ulang";
            this.Ulang.Size = new System.Drawing.Size(180, 22);
            this.Ulang.Text = "Daftar Ulang";
            this.Ulang.Click += new System.EventHandler(this.Ulang_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TampilanProdi,
            this.TampilanMhs});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(36, 24);
            this.toolStripDropDownButton2.Text = "V&iew";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdatePrd,
            this.updateMahasiswaToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(49, 24);
            this.toolStripDropDownButton3.Text = "U&pdate";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportDaftarUlang});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.ShowDropDownArrow = false;
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(58, 24);
            this.toolStripDropDownButton4.Text = "T&ransaksi";
            // 
            // TampilanProdi
            // 
            this.TampilanProdi.Name = "TampilanProdi";
            this.TampilanProdi.Size = new System.Drawing.Size(183, 22);
            this.TampilanProdi.Text = "Tampilan Prodi";
            this.TampilanProdi.Click += new System.EventHandler(this.TampilanProdi_Click);
            // 
            // TampilanMhs
            // 
            this.TampilanMhs.Name = "TampilanMhs";
            this.TampilanMhs.Size = new System.Drawing.Size(183, 22);
            this.TampilanMhs.Text = "Tampilan Mahasiswa";
            this.TampilanMhs.Click += new System.EventHandler(this.TampilanMhs_Click);
            // 
            // UpdatePrd
            // 
            this.UpdatePrd.Name = "UpdatePrd";
            this.UpdatePrd.Size = new System.Drawing.Size(180, 22);
            this.UpdatePrd.Text = "Update Prodi";
            this.UpdatePrd.Click += new System.EventHandler(this.UpdatePrd_Click);
            // 
            // updateMahasiswaToolStripMenuItem
            // 
            this.updateMahasiswaToolStripMenuItem.Name = "updateMahasiswaToolStripMenuItem";
            this.updateMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateMahasiswaToolStripMenuItem.Text = "Update Mahasiswa";
            this.updateMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.updateMahasiswaToolStripMenuItem_Click);
            // 
            // reportDaftarUlang
            // 
            this.reportDaftarUlang.Name = "reportDaftarUlang";
            this.reportDaftarUlang.Size = new System.Drawing.Size(180, 22);
            this.reportDaftarUlang.Text = "Report Daftar Ulang";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton input;
        private System.Windows.Forms.ToolStripMenuItem mhs;
        private System.Windows.Forms.ToolStripMenuItem prodi;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem Ulang;
        private System.Windows.Forms.ToolStripMenuItem TampilanProdi;
        private System.Windows.Forms.ToolStripMenuItem TampilanMhs;
        private System.Windows.Forms.ToolStripMenuItem UpdatePrd;
        private System.Windows.Forms.ToolStripMenuItem updateMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportDaftarUlang;
    }
}

