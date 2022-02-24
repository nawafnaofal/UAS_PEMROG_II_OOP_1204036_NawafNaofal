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
using System.Text.RegularExpressions;
using System.Globalization;

namespace UAS_OOP_1204036
{
    public partial class DaftarUlang : Form
    {
        Decimal rupiah;
        public DaftarUlang()
        {
            InitializeComponent();

        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            int potongan = (Int32.Parse(biaya_kuliah.Text.ToString()) * 50) / 100;
            tbPotongan.Text = potongan.ToString();
            int total = Int32.Parse(biaya_kuliah.Text.ToString()) - potongan;
            tbTotal.Text = total.ToString();
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            int potongan = (Int32.Parse(biaya_kuliah.Text.ToString()) * 25) / 100;
            tbPotongan.Text = potongan.ToString();
            int total = Int32.Parse(biaya_kuliah.Text.ToString()) - potongan;
            tbTotal.Text = total.ToString();
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            int potongan = (Int32.Parse(biaya_kuliah.Text.ToString()) * 10) / 100;
            tbPotongan.Text = potongan.ToString();
            int total = Int32.Parse(biaya_kuliah.Text.ToString()) - potongan;
            tbTotal.Text = total.ToString();
        }

        private void UpdateDB(string sql)
        {
            try
            {
                string connection = "Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True";
                SqlConnection koneksi = new SqlConnection(connection);
                koneksi.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Database berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubmitDaftar_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (npm.Text != "" && int.TryParse(npm.Text.ToString(), out i))
            {
                if (rbA.Checked != false || rbB.Checked != false || rbC.Checked != false)
                {
                    string grade = "";
                    if (rbA.Checked)
                    {
                        grade = "A";
                    }
                    if (rbB.Checked)
                    {
                        grade = "B";
                    }
                    if (rbC.Checked)
                    {
                        grade = "C";
                    }
                    string sql = "INSERT INTO tr_daftar_ulang VALUES('"
                        + npm.Text + "','"
                        + grade + "','"
                        + tbTotal.Text + "')";

                    UpdateDB(sql);

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Grade Selesai Mahasiswa belum dipilih!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("NPM Mahasiswa belum diisi dan pastikan formatnya benar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cariNPM_Click(object sender, EventArgs e)
        {
            string getLastIdSql = "SELECT nama_mhs,nama_prodi,biaya_kuliah FROM ms_mhs " +
                "JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi WHERE npm='" + npm.Text + "'";

            string connection = "Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True";
            SqlConnection koneksi = new SqlConnection(connection);
            koneksi.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, koneksi);
            SqlDataReader hasil;

            hasil = sc.ExecuteReader();
            if (hasil.HasRows)
            {
                while (hasil.Read())
                {
                    nama_mhs.Text = hasil["nama_mhs"].ToString();
                    nama_prodi.Text = hasil["nama_prodi"].ToString();
                    biaya_kuliah.Text = hasil["biaya_kuliah"].ToString();
                }
            }
        }

        private void biaya_kuliah_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(biaya_kuliah.Text))
            {
                rupiah = 0;
            }
            else
            {
                rupiah = decimal.Parse(biaya_kuliah.Text);
            }
            biaya.Text = rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        private void tbPotongan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPotongan.Text))
            {
                rupiah = 0;
            }
            else
            {
                rupiah = decimal.Parse(tbPotongan.Text);
            }
            potong.Text = rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTotal.Text))
            {
                rupiah = 0;
            }
            else
            {
                rupiah = decimal.Parse(tbTotal.Text);
            }
            totall.Text = rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        private void npm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void totall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
