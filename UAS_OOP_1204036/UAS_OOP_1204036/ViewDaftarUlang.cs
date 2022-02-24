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
using System.Globalization;

namespace UAS_OOP_1204036
{
    public partial class ViewDaftarUlang : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;

        public ViewDaftarUlang()
        {
            InitializeComponent();
        }

        private void ViewDaftarUlang_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT ms_mhs.npm,nama_mhs,nama_prodi,grade,total_biaya FROM ms_mhs JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi JOIN tr_daftar_ulang ON ms_mhs.npm=tr_daftar_ulang.npm";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "ms_mhs");
            dgProdi.DataSource = ds;
            dgProdi.DataMember = "ms_mhs";
            dgProdi.Refresh();
            conn.Close();
        }
    }
}
