using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS_OOP_1204036
{
    public partial class Home : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True");
        public Home()
        {
            InitializeComponent();
        }

        private void prodi_Click(object sender, EventArgs e)
        {
            InputProdi inputProdi = new InputProdi();
            inputProdi.MdiParent = this;
            inputProdi.Show();
        }

        private void mhs_Click(object sender, EventArgs e)
        {
            Mahasiswa TampilMahasiswa = new Mahasiswa();
            TampilMahasiswa.MdiParent = this;
            TampilMahasiswa.Show();
        }

        private void Ulang_Click(object sender, EventArgs e)
        {
            DaftarUlang TampilDaftar = new DaftarUlang();
            TampilDaftar.MdiParent = this;
            TampilDaftar.Show();
        }

        private void TampilanProdi_Click(object sender, EventArgs e)
        {
            ViewProdi ViewProdi = new ViewProdi();
            ViewProdi.MdiParent = this;
            ViewProdi.Show();
        }

        private void TampilanMhs_Click(object sender, EventArgs e)
        {
            ViewMahasiswa ViewMahasiswa = new ViewMahasiswa();
            ViewMahasiswa.MdiParent = this;
            ViewMahasiswa.Show();
        }

        private void UpdatePrd_Click(object sender, EventArgs e)
        {
            UpdateProdi UpdateProdi = new UpdateProdi();
            UpdateProdi.MdiParent = this;
            UpdateProdi.Show();
        }

        private void updateMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMahasiswa UpdateMahasiswa = new UpdateMahasiswa();
            UpdateMahasiswa.MdiParent = this;
            UpdateMahasiswa.Show();
        }

        private void reportDaftarUlang_Click(object sender, EventArgs e)
        {
            ViewDaftarUlang ViewDaftarUlang = new ViewDaftarUlang();
            ViewDaftarUlang.MdiParent = this;
            ViewDaftarUlang.Show();
        }

        private void updateDaftarUlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDaftarUlang UpdateDaftarUlang = new UpdateDaftarUlang();
            UpdateDaftarUlang.MdiParent = this;
            UpdateDaftarUlang.Show();
        }
    }
}
