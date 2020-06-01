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

namespace DataBaseManangementProject
{
    public partial class kar_zarar : Form
    {
        private SqlConnection connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
        private SqlCommand commandName;
        private SqlDataReader dr;

        public kar_zarar()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string strsold;
            decimal result = 0;

            if (D1.Value != D2.Value)
            {
                connection.Open();
                strsold = "select price from sold where datee between @startDate and @endDate";
                commandName = new SqlCommand(strsold, connection);
                commandName.Parameters.AddWithValue("@startDate", D1.Value.Date);
                commandName.Parameters.AddWithValue("@endDate", D2.Value.Date);
                dr = commandName.ExecuteReader();
                while (dr.Read())
                {
                    result += Convert.ToDecimal(dr["price"]);
                }
                dr.Close();
                string strcost = "select  sum(c.Price) Price from cost c where c.Date between @startDate and @endDate";
                commandName = new SqlCommand(strcost, connection);
                commandName.Parameters.AddWithValue("@startDate", D1.Value.Date);
                commandName.Parameters.AddWithValue("@endDate", D2.Value.Date);
                dr = commandName.ExecuteReader();
                while (dr.Read() && dr["Price"] != DBNull.Value)
                {
                    result -= Convert.ToDecimal(dr["Price"]);
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                connection.Open();
                strsold = "select price from sold where datee= @startDate";
                commandName = new SqlCommand(strsold, connection);
                commandName.Parameters.AddWithValue("@startDate", D1.Value.Date);
                dr = commandName.ExecuteReader();
                while (dr.Read())
                {
                    result += Convert.ToDecimal(dr["price"]);
                }
                dr.Close();
               
               string strcost = "select  sum(c.Price) Price from cost c where c.Date=@startDate ";
                commandName = new SqlCommand(strcost, connection);
                commandName.Parameters.AddWithValue("@startDate", Convert.ToDateTime(D1.Value.Date));
                dr = commandName.ExecuteReader();
                while (dr.Read()&& dr["Price"] !=DBNull.Value)
                {
                    result -= Convert.ToDecimal(dr["Price"]);
                }
                dr.Close();
                connection.Close();
            }
            Result_Label.Text = result.ToString();
        }

        private void kar_zarar_Load(object sender, EventArgs e)
        {
            D1.Value = DateTime.Now;
            D2.Value = DateTime.Now;
        }
    }
}
