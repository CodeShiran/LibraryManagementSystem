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

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryNew;Integrated Security=True;TrustServerCertificate=True");
        public ReturnBooks()
        {
            InitializeComponent();
            displayReturnedBookData();
        }

        private void rbimport_txt_Click(object sender, EventArgs e)
        {
            
        }

        private void returnBooks_retrurnBtn_Click(object sender, EventArgs e)
        {

        }
        public void displayReturnedBookData()
        {
            DataIssueBook db= new DataIssueBook();
            List<DataIssueBook> list = db.ReturnIssueBooksData();
            dataGridView1.DataSource = list;
        }
    }
}
