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
    public partial class UpdateMahasiswa : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;

        public UpdateMahasiswa()
        {
            InitializeComponent();
        }

        private void UpdateMahasiswa_Load(object sender, EventArgs e)
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
            dgUpdateMhs.DataSource = ds;
            dgUpdateMhs.DataMember = "ms_mhs";
            dgUpdateMhs.Refresh();
            conn.Close();
        }

        private void UpdatePrd_Click(object sender, EventArgs e)
        {
            //string myConnectionstring = "integrated security=true;data source=.;initial catalog=DESKTOP-NAWAF\\P6_1204036";
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from ms_mhs", myConnection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;

            myTransaction = myConnection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(ds, "ms_mhs");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " baris diperbarui", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTransaction.Rollback();
            }
        }
    }
}
