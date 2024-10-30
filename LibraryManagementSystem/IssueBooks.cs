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
            displayBookIssueData();
        }
        public void displayBookIssueData()
        {
            DataIssueBook dataIssueBook = new DataIssueBook();
            List<DataIssueBook> list = dataIssueBook.IssueBooksData();

            dataGridView1.DataSource = list;
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

                    using (SqlCommand cmd = new SqlCommand("SELECT id,book_title FROM books WHERE status='Available' AND date_delete IS NULL", connection))
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

        private void issuebooks_title_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State!= ConnectionState.Open)
            {
                if (issuebooks_title.SelectedIndex != -1)
                {
                    DataRowView SelectedRow = (DataRowView)issuebooks_title.SelectedItem;
                    int selectId = Convert.ToInt32(SelectedRow["id"]);

                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM books WHERE id=@id", connection))
                        {
                            cmd.Parameters.AddWithValue("@id", selectId);

                            SqlDataAdapter sd = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            sd.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                issuebooks_author.Text = table.Rows[0]["author"].ToString();

                                string imagePath = table.Rows[0]["image"].ToString();

                                if (imagePath != null)
                                {
                                    issuebooks_image.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    issuebooks_image.Image = null;
                                }
                            }


                        }
                    }
                    catch (Exception ex)
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
}
