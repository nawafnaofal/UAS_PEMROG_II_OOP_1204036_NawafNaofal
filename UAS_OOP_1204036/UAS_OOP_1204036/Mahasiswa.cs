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
            if (tbNpm.Text != "" && tbNpm.TextLength == 7)
            {
                if (NamaMhs.Text != "")
                {
                          
                                
                                    if (cbProdi.Text != "- Pilih Program Studi -")
                                    {
                                        string npm = tbNpm.Text;
                                        string nama = NamaMhs.Text;                                        
                                        string prodi = this.prodi;

                                        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True");

                                        string sql = "insert into ms_mhs ([npm], [nama_mhs], " +
                                            " [kode_prodi]) values(@npm,@nama_mhs,@kode_prodi)";

                                        using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True"))
                                        {
                                            try
                                            {
                                                cnn.Open();

                                                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                                                {
                                                    cmd.Parameters.Add("@npm", SqlDbType.NVarChar).Value = npm;
                                                    cmd.Parameters.Add("@nama_mhs", SqlDbType.NVarChar).Value = nama;
                                                    cmd.Parameters.Add("@kode_prodi", SqlDbType.NVarChar).Value = prodi;

                                                    int rowsAdded = cmd.ExecuteNonQuery();
                                                    if (rowsAdded > 0)
                                                        MessageBox.Show("Data berhasil disimpan");
                                                    else
                                                        MessageBox.Show("Tidak ada data yang disimpan");



                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("ERROR:" + ex.Message);
                                            }
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show
                                                    ("Prodi belum diisi!",
                                                    "Informasi Data Submit",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                
                            
                        
                        
                        

                }
                else
                {
                    MessageBox.Show
                                ("Nama belum diisi!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                            ("NPM belum diisi!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
