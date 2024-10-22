using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Are You Sure?","Information Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mainlo_btn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
        }

        private void addbooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = true;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
        }

        private void issuebooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = true;
        }

        private void returnbooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = true;
            issueBooks1.Visible = false;
        }
    }
}
