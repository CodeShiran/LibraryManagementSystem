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
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryNew;Integrated Security=True;TrustServerCertificate=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Information Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            RegisterForm rg = new RegisterForm();
            this.Hide();
            rg.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(loginuser_txt.Text=="" || loginpass_txt.Text == "")
            {
                MessageBox.Show("Please Fill All The Feilds","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username=@username AND password=@password",connection))
                        {
                            cmd.Parameters.AddWithValue("@username",loginuser_txt.Text.Trim());
                            cmd.Parameters.AddWithValue("@password",loginpass_txt.Text.Trim());

                            SqlDataAdapter sd=new SqlDataAdapter(cmd);
                            DataTable table=new DataTable();
                            sd.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfull","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                MainForm mf=new MainForm();
                                this.Hide();
                                mf.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect User Name Or Password", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void loginsp_cb_CheckedChanged(object sender, EventArgs e)
        {
            loginpass_txt.PasswordChar = loginsp_cb.Checked ? '\0': '*';
        }
    }
}
