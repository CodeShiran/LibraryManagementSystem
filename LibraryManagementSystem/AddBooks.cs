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
using System.IO;
using System.Drawing.Text;

namespace LibraryManagementSystem
{
    public partial class AddBooks : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryNew;Integrated Security=True;TrustServerCertificate=True");
        public AddBooks()
        {
            InitializeComponent();
            displayBooks();
        }

        private void abimport_txt_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;*.png) | *.jpg;*png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    abimagebox.ImageLocation = imagePath;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addbooks_addbtn_Click(object sender, EventArgs e)
        {
            if(abimagebox==null || addbooks_bttxt.Text=="" || addbooks_authortxt.Text=="" || addbooks_bitxt.Text=="" || addbooks_statustxt.Text == "")
            {
                MessageBox.Show("Fill All The Feilds","Warning Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if(connection.State != ConnectionState.Open)
                {
                    try
                    {
                        DateTime today= DateTime.Today;
                        connection.Open();
                        string path = Path.Combine(@"D:\My\CS P\1019\LibraryManagementSystem\LibraryManagementSystem\Books Directory\"+ addbooks_authortxt.Text.Trim()+"_" + ".jpg");

                        string directoryPath= Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        File.Copy(abimagebox.ImageLocation,path, true);

                        using (SqlCommand command = new SqlCommand("INSERT INTO books (book_title,author,publish_date,image,status,date_insert) VALUES(@title,@author,@publishdate,@image,@status,@dateinsert)", connection))
                        {
                            command.Parameters.AddWithValue("@title",addbooks_bttxt.Text.Trim());
                            command.Parameters.AddWithValue("@author",addbooks_authortxt.Text.Trim());
                            command.Parameters.AddWithValue("@publishdate",addbooks_bitxt.Value);
                            command.Parameters.AddWithValue("@image", abimagebox.ImageLocation);
                            command.Parameters.AddWithValue("@status",addbooks_statustxt.Text.Trim());               
                            command.Parameters.AddWithValue("@dateinsert", today);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Successfully Added","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            displayBooks();
                            clearFeilds();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error Message "+ex.Message,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void clearFeilds()
        {
            addbooks_bttxt.Text = "";
            addbooks_authortxt.Text = "";
            addbooks_bitxt.Text = "";
            addbooks_statustxt.SelectedIndex = -1;
            abimagebox.Image = null;
        }
        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List<DataAddBooks> listData = dab.addBooksData();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listData;
            dataGridView1.Refresh();

        }
        private int bookId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row=dataGridView1.Rows[e.RowIndex];
                bookId = (int)row.Cells[0].Value;
                addbooks_bttxt.Text = row.Cells[1].Value.ToString();
                addbooks_authortxt.Text=row.Cells[2].Value.ToString();
                addbooks_bitxt.Text= row.Cells[3].Value.ToString();
                string imagePath=row.Cells[4].Value?.ToString();

                if (imagePath != null || imagePath.Length>=1)
                {
                    abimagebox.Image=Image.FromFile(imagePath); 
                }
                else
                {
                    abimagebox.Image=null;
                }
                addbooks_statustxt.Text = row.Cells[5].Value.ToString();
            }
        }

        private void addbooks_clearbtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }
    }
}
