using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    internal class DataAddBooks
    {
        SqlConnection connection=new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryNew;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public int Id { get; set; }
        public string BookTitle {  get; set; }
        public string Author {  get; set; }
        public string Published {  get; set; }
        public string Status {  get; set; }

        public List<DataAddBooks> addBooksData()
        {
            List<DataAddBooks>list= new List<DataAddBooks>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM books WHERE date_delete IS NULL", connection))
                    {
                        SqlDataReader reader= cmd.ExecuteReader(); 
                        DataAddBooks dab=new DataAddBooks();
                        while (reader.Read())
                        {
                            dab.Id=(int)reader["id"];
                            dab.BookTitle = reader["book_title"].ToString();
                            dab.Author = reader["author"].ToString();
                            dab.Published = reader["publish_date"].ToString() ;
                            dab.Status = reader["status"].ToString();

                            list.Add(dab);
                        }
                        reader.Close();
                    }
                 
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error Occurrd" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            return list;
        }
        
    }
}
