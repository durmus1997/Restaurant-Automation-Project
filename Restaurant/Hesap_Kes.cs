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
    public partial class Hesap_Kes : Form
    {
        SqlConnection connection;
        SqlCommand command, command2;
        SqlDataReader dr;
        List<products> foodresult = new List<products>();
        List<products> drinkresult = new List<products>();
        List<int> table_no = new List<int>();
        decimal total = 0;
        public Hesap_Kes()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Search_Table_Tbox_ValueChanged(object sender, EventArgs e)
        {
            Food_List.Items.Clear();
            Cost_List.Items.Clear();
            foodresult.Clear();
            drinkresult.Clear();
            Total.Text = "";
        }

        private void Cut_Bill_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
            connection.Open();
            Food_List.Items.Clear();
            Cost_List.Items.Clear();
            foodresult.Clear();
            drinkresult.Clear();
            command = new SqlCommand("update sold set Table_No=NULL where Table_No=@tno", connection);
            command.Parameters.AddWithValue("@tno", Convert.ToInt32(Search_Table_Tbox.SelectedItem));
            command.ExecuteNonQuery();
            connection.Close();
            Total.Text = "";
            Search_Table_Tbox.Enabled = true;
            MessageBox.Show("İşlem Tamam");
            Search_Table_Tbox.Text = "";
        }
        void Go_Cut()
        {
            connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
            connection.Open();
            command = new SqlCommand("select  Table_no from sold", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Table_no"] != DBNull.Value)
                {
                    if (!table_no.Contains(Convert.ToInt32(dr["Table_no"])))
                    {

                        table_no.Add(Convert.ToInt32(dr["Table_no"]));
                    }
                }
            }
            dr.Close();
            foreach (int x in table_no)
            {
                Search_Table_Tbox.Items.Add(x);
            }
            connection.Close();
        }
        private void Hesap_Kes_Load(object sender, EventArgs e)
        {

            Go_Cut();
        }
       
     
        private void Result_Click(object sender, EventArgs e)
        {

            connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
            connection.Open();
            Food_List.Items.Clear();
            Cost_List.Items.Clear();
            foodresult.Clear();
            drinkresult.Clear();
            Total.Text = "";
            Search_Table_Tbox.Enabled = false;

            command = new SqlCommand("select Id_Food,Id_Drink,Price from sold where Table_No=@tno", connection);
            command.Parameters.AddWithValue("@tno", Convert.ToInt32(Search_Table_Tbox.SelectedItem));
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Id_Drink"] != DBNull.Value)
                {
                    drinkresult.Add(new products { price = Convert.ToDecimal(dr["Price"]), Id = Convert.ToInt32(dr["Id_Drink"]) });
                }
                if (dr["Id_Food"] != DBNull.Value)
                {
                    foodresult.Add(new products { price = Convert.ToDecimal(dr["Price"]), Id = Convert.ToInt32(dr["Id_Food"]) });
                }
            }
            dr.Close();
            foreach (var x in drinkresult)
            {
                command2 = new SqlCommand("select Name from Drink where Id=@id", connection);
                command2.Parameters.AddWithValue("@id", x.Id);
                string name = command2.ExecuteScalar().ToString();
                Food_List.Items.Add(name);
                Cost_List.Items.Add(x.price);
                total = total + x.price;
               
            }
            foreach (var x in foodresult)
            {
                command2 = new SqlCommand("select Name from Food where Id=@id", connection);
                command2.Parameters.AddWithValue("@id", x.Id);
                string name = command2.ExecuteScalar().ToString();
                Food_List.Items.Add(name);
                Cost_List.Items.Add(x.price);
                total = total + x.price;
            }
            Total.Text = total.ToString();
            connection.Close();
            Go_Cut();
           
        }
    }
}
