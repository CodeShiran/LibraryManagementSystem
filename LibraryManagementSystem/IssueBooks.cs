using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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
        public void clearFeilds()
        {
            issuebooks_id.Text = "";
            issuebooks_name.Text = "";
            issuebooks_tel.Text ="";
            issuebooks_email.Text ="";
            issuebooks_title.SelectedIndex =-1;
            issuebooks_author.SelectedIndex = -1;
            issuebooks_issueDate = null;
            issuebooks_returnDate= null;
            issuebooks_status.SelectedIndex =-1;
            issuebooks_image.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (issuebooks_id.Text == "" || issuebooks_name.Text=="" || issuebooks_tel.Text=="" || issuebooks_email.Text=="" || issuebooks_title.Text=="" || issuebooks_author.Text=="" || issuebooks_issueDate.Value==null || issuebooks_returnDate.Value==null || issuebooks_status.Text=="")
            {
                MessageBox.Show("Fill All The Feilds", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DateTime today= DateTime.Today;
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO issues (issue_id,full_name,contact,email,book_title,author,status,issue_date,return_date,insert_date) VALUES (@id,@name,@contact,@email,@title,@author,@status,@issueDate,@returnDate,@insertDate)",connection))
                    {
                        cmd.Parameters.AddWithValue("@id", issuebooks_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", issuebooks_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", issuebooks_tel.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", issuebooks_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@title", issuebooks_title.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", issuebooks_author.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", issuebooks_status.Text.Trim());
                        cmd.Parameters.AddWithValue("@issueDate", issuebooks_issueDate.Value);
                        cmd.Parameters.AddWithValue("@returnDate", issuebooks_returnDate.Value);
                        cmd.Parameters.AddWithValue("@insertDate",today);

                        cmd.ExecuteNonQuery();

                        

                        MessageBox.Show("Successfully Inserted","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        displayBookIssueData();

                        clearFeilds();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row= dataGridView1.Rows[e.RowIndex];
                issuebooks_id.Text = row.Cells[1].Value.ToString();
                issuebooks_name.Text = row.Cells[2].Value.ToString();
                issuebooks_tel.Text = row.Cells[3].Value.ToString();
                issuebooks_email.Text = row.Cells[4].Value.ToString();
                issuebooks_title.Text = row.Cells[5].Value.ToString();
                issuebooks_author.Text = row.Cells[6].Value.ToString();
                issuebooks_issueDate.Value = Convert.ToDateTime(row.Cells[7].Value).Date;
                issuebooks_returnDate.Value = Convert.ToDateTime(row.Cells[8].Value).Date;
                issuebooks_status.Text = row.Cells[9].Value.ToString();

                



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (issuebooks_id.Text == "" || issuebooks_name.Text == "" || issuebooks_tel.Text == "" || issuebooks_email.Text == "" || issuebooks_title.Text == "" || issuebooks_author.Text == "" || issuebooks_issueDate.Value == null || issuebooks_returnDate.Value == null || issuebooks_status.Text == "")
            {
                MessageBox.Show("Plaease Do A Selection", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure", "Information Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        DateTime today = DateTime.Today;
                        using (SqlCommand command = new SqlCommand("UPDATE issues SET full_name=@name,contact=@contact,email=@email,book_title=@title,author=@author,status=@status,issue_date=@issueDate,return_date=@returnDate,update_date=@updateDate WHERE issue_id=@issueId", connection))
                        {
                            command.Parameters.AddWithValue("@name",issuebooks_name.Text.Trim());
                            command.Parameters.AddWithValue("@contact", issuebooks_tel.Text.Trim());
                            command.Parameters.AddWithValue("@email", issuebooks_email.Text.Trim());
                            command.Parameters.AddWithValue("@title", issuebooks_title.Text.Trim());
                            command.Parameters.AddWithValue("@author", issuebooks_author.Text.Trim());
                            command.Parameters.AddWithValue("@status", issuebooks_status.Text.Trim());
                            command.Parameters.AddWithValue("@issueDate", issuebooks_issueDate.Value);
                            command.Parameters.AddWithValue("@returnDate", issuebooks_returnDate.Value);
                            command.Parameters.AddWithValue("@updateDate", today);
                            command.Parameters.AddWithValue("@issueId", issuebooks_id.Text.Trim());


                            command.ExecuteNonQuery();

                            MessageBox.Show("Successfully Updated", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayBookIssueData();

                            clearFeilds();
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
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
