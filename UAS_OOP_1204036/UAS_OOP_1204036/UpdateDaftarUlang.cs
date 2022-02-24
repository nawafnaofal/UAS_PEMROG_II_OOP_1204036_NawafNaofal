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
    public partial class UpdateDaftarUlang : Form
    {
        private DataSet ds;

        public UpdateDaftarUlang()
        {
            InitializeComponent();
            refreshDataSet();
        }

        private void UpdateDaftarUlang_Load(object sender, EventArgs e)
        {
            
        }

        public DataSet prdDataSet()
        {
            DataSet ds = new DataSet();

            try
            {
                string conn = "Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True";

                SqlConnection connection = new SqlConnection(conn);

                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = "SELECT ms_mhs.npm,nama_mhs,nama_prodi,grade,total_biaya FROM ms_mhs JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi JOIN tr_daftar_ulang ON ms_mhs.npm=tr_daftar_ulang.npm";
                command.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.TableMappings.Add("Table", "DaftarUlang");

                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ds;
        }

        private void refreshDataSet()
        {
            ds = prdDataSet();
            dgUpdateDaftar.DataSource = ds.Tables["DaftarUlang"];
        }

        private void UpdateDaftar_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=DESKTOP-7CON8MO;Initial Catalog=UAS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM tr_daftar_ulang", connection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;

            myTransaction = connection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(ds, "DaftarUlang");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " baris diperbarui", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTransaction.Rollback();
            }
        }
    }
}

