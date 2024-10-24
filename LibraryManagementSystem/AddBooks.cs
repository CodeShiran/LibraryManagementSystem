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

namespace LibraryManagementSystem
{
    public partial class AddBooks : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryNew;Integrated Security=True;TrustServerCertificate=True");
        public AddBooks()
        {
            InitializeComponent();
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
                        string path = Path.Combine(@"D:\My\CS P\1019\LibraryManagementSystem\LibraryManagementSystem\Books Directory\"+addbooks_bttxt.Text.Trim()+"_"+ addbooks_authortxt.Text.Trim()+"_" + ".jpg");

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
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error Message"+ex,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
