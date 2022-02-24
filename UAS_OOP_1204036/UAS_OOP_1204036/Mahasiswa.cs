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
    public partial class Mahasiswa : Form
    {
        string prodi;
        public Mahasiswa()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True");

            conn.Open();

            SqlCommand sc = new SqlCommand("SELECT * FROM ms_prodi", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("kode_prodi", typeof(string));
            dt.Columns.Add("singkatan", typeof(string));
            dt.Load(reader);

            cbProdi.ValueMember = "kode_prodi";
            cbProdi.DisplayMember = "singkatan";
            cbProdi.DataSource = dt;

            conn.Close();
        }

        private void SubmitMhs_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (tbNpm.Text != "" && int.TryParse(tbNpm.Text.ToString(), out i))
            {
                if (NamaMhs.Text != "" && !NamaMhs.Text.ToString().Any(char.IsDigit))
                {
                    if (cbProdi.Text != "")
                    {
                        string sql = "INSERT INTO ms_mhs VALUES('"
                                    + tbNpm.Text + "','"
                                    + NamaMhs.Text + "','"
                                    + cbProdi.SelectedValue + "')";

                        UpdateDB(sql);

                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Kolom prodi mahasiswa belum dipilih!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Kolom nama mahasiswa tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kolom NPM mahasiswa tidak boleh kosong !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateDB(string cmd)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True");
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = cmd;
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Basisdata berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception z)
            {
                MessageBox.Show(z.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.prodi = cbProdi.SelectedValue.ToString();
        }

        private void ClearMhs_Click(object sender, EventArgs e)
        {
            tbNpm.Text = null;
            NamaMhs.Text = null;
            cbProdi.SelectedIndex = 0;
        }

        private void tbNpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NamaMhs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled= true;
            }
        }
    }
}
