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
    public partial class RegisterForm : Form
    {
        SqlConnection connection=new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryNew;Integrated Security=True;TrustServerCertificate=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            LoginForm lg=new LoginForm();
            this.Hide();
            lg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Information Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void registersp_cb_CheckedChanged(object sender, EventArgs e)
        {
            registerpass_txt.PasswordChar = registersp_cb.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(registeremail_txt.Text=="" || registername_txt.Text=="" || registerpass_txt.Text == "")
            {
                MessageBox.Show("Please Fill All The Feilds","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        using(SqlCommand cmd=new SqlCommand("SELECT COUNT(*) FROM users WHERE username=@name", connection))
                        {
                            cmd.Parameters.AddWithValue("@name",registername_txt.Text.Trim());
                            int count=(int)cmd.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(registername_txt.Text.Trim() + "User Name Already Taken", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                DateTime day = DateTime.Today;
                                using (SqlCommand command = new SqlCommand("INSERT INTO users(email,username,password,date_register) VALUES (@email,@name,@password,@regdate)", connection))
                                {
                                    command.Parameters.AddWithValue("@email", registeremail_txt.Text.Trim());
                                    command.Parameters.AddWithValue("@name",registername_txt.Text.Trim());
                                    command.Parameters.AddWithValue("@password",registerpass_txt.Text.Trim());
                                    command.Parameters.AddWithValue("@regdate", day.ToString());

                                    command.ExecuteNonQuery();

                                    MessageBox.Show("Successfully Registered", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm lg=new LoginForm();
                                    this.Hide();
                                    lg.Show();
                                }
                            }
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Error Occured" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        private void registerpass_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
