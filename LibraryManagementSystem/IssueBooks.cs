using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IssueBooks : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryNew;Integrated Security=True;TrustServerCertificate=True");
        public IssueBooks()
        {
            InitializeComponent();
            DataBookTitle();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void DataBookTitle()
        {
            if(connection.State!= ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM books WHERE status='Available' AND date_delete IS NULL", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        issuebooks_title.DataSource = dt;
                        issuebooks_title.DisplayMember = "book_title";
                        issuebooks_title.ValueMember = "id";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Message " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            
        }
    }
}
