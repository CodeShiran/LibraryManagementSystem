using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    internal class DataIssueBook
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryNew;Integrated Security=True;TrustServerCertificate=True");
        public int Id { get; set; }
        public string IssueId {  get; set; }    
        public string Name { get; set; }    
        public string Contact {  get; set; }
        public string Email { get; set; }
        public string BookTitle { get; set; }
        public string Author {  get; set; }
        public string DateIssue {  get; set; }  
        public string DateReturn {  get; set; }
        public string status {  get; set; }


        public List<DataIssueBook> IssueBooksData()
        {
            List<DataIssueBook>listData= new List<DataIssueBook>();
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM issues WHERE delete_date IS NULL", connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            DataIssueBook db = new DataIssueBook();
                            db.Id=(int)reader["ID"];
                            db.IssueId = reader["issue_id"].ToString();
                            db.Name = reader["full_name"].ToString();
                            db.Contact = reader["contact"].ToString() ;
                            db.Email = reader["email"].ToString();
                            db.BookTitle=reader["book_title"].ToString();
                            db.Author = reader["author"].ToString();
                            db.DateIssue = reader["issue_date"].ToString();
                            db.DateReturn = reader["return_date"].ToString();
                            db.status = reader["status"].ToString();

                            listData.Add(db);



                        }
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
            return listData;
        }
    }
}
