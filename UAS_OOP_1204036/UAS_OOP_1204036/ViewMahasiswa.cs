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
    public partial class ViewMahasiswa : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;

        public ViewMahasiswa()
        {
            InitializeComponent();
        }

        private void ViewMahasiswa_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from ms_mhs";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "ms_mhs");
            dgMhs.DataSource = ds;
            dgMhs.DataMember = "ms_mhs";
            dgMhs.Refresh();
            conn.Close();
        }
    }
}
