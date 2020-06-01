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
    public partial class Ekle : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dr;
        List<products> foodList = new List<products>();
        List<products> drinkList = new List<products>();
        List<products> type_food = new List<products>();
        List<products> type_drink = new List<products>();
        public Ekle()
        {
            InitializeComponent();
        }

        private void Add_Type_Button_Click(object sender, EventArgs e)
        {
            Tur_Ekle2 t2 = new Tur_Ekle2();
            t2.Show();
            this.Hide();
           
        }

        private void Drink_Rbutton_CheckedChanged(object sender, EventArgs e)
        {

            if (Drink_Rbutton.Checked)
            {
                Type_List_Dbox.Items.Clear();
                foreach (var x in type_drink)
                {
                    Type_List_Dbox.Items.Add(x.Name);
                }
                Type_List_Dbox.Enabled = true;
                Add.Enabled = true;
                Type_List_Dbox.Enabled = true;
                pName_Box.Enabled = true;
                Price_Num.Enabled = true;
            }            
        }

        private void Food_Rbutton_CheckedChanged(object sender, EventArgs e)
        {

            if (Food_Rbutton.Checked)
            {
                Type_List_Dbox.Items.Clear();
                foreach (var x in type_food)
                {
                    Type_List_Dbox.Items.Add(x.Name);
                }
                Type_List_Dbox.Enabled = true;
                Add.Enabled = true;
                Type_List_Dbox.Enabled = true;
                pName_Box.Enabled = true;
                Price_Num.Enabled = true;
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
            connection.Open();
            command = new SqlCommand("select Name,Id from Type_of_Drink", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                type_drink.Add(new products { Name = dr["Name"].ToString(), Id = Convert.ToInt32(dr["Id"]) });
            }
            dr.Close();
            command = new SqlCommand("select Name,Id from Type_of_Food", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                type_food.Add(new products { Name = dr["Name"].ToString(), Id = Convert.ToInt32(dr["Id"]) });
            }
            dr.Close();
            command = new SqlCommand("select Name from Food", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                foodList.Add(new products { Name = dr["Name"].ToString() });
            }
            dr.Close();
            command = new SqlCommand("select Name from Drink", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                drinkList.Add(new products { Name = dr["Name"].ToString() });
            }
            dr.Close();
            connection.Close();
            Type_List_Dbox.Enabled = false;
            Add.Enabled = false;
            Type_List_Dbox.Enabled = false;
            pName_Box.Enabled = false;
            Price_Num.Enabled = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
            bool Iscontain = false;
            products pName = new products();
            pName.Name = pName_Box.Text.ToUpper();
            if (Drink_Rbutton.Checked)
            {
                if (pName_Box.Text != "" && Type_List_Dbox.SelectedItems != null && Price_Num.Value > 0)
                {
                    foreach (var x in drinkList)
                    {
                        if (x.Name == pName.Name)
                        {
                            Iscontain = true;
                            break;
                        }
                    }
                    if (!Iscontain)
                    {
                        connection.Open();
                        command = new SqlCommand("insert into Drink values(@name,@price,@piece)", connection);
                        command.Parameters.AddWithValue("@name", pName_Box.Text.ToUpper());
                        command.Parameters.AddWithValue("@price", Price_Num.Value);
                        command.Parameters.AddWithValue("@piece", 0);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("select Id from Drink where Name=@name", connection);
                        command.Parameters.AddWithValue("@name", pName_Box.Text.ToUpper());
                        int Id_Drink = Convert.ToInt32(command.ExecuteScalar());
                        command = new SqlCommand("select Name from Drink", connection);
                        dr = command.ExecuteReader();
                        drinkList.Clear();
                        while (dr.Read())
                        {
                            drinkList.Add(new products { Name = dr["Name"].ToString() });
                        }
                        dr.Close();
                        foreach (ListViewItem num_Type in Type_List_Dbox.SelectedItems)
                        {
                            foreach (var x in type_drink)
                            {

                                if (num_Type.Text == x.Name)
                                {
                                    command = new SqlCommand("insert into Menu_Drink values(@Id_Drink,@Id_Type)", connection);
                                    command.Parameters.AddWithValue("@Id_Drink", Id_Drink);
                                    command.Parameters.AddWithValue("@Id_Type", x.Id);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("kaydedildi");
                                    pName_Box.Text = "";
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kayıtlı");
                    }
                }
            }
            else if (Food_Rbutton.Checked)
            {
                if (pName_Box.Text != "" && Type_List_Dbox.SelectedItems != null && Price_Num.Value > 0)
                {
                    foreach(var x in foodList)
                    {
                        if (x.Name == pName.Name)
                        {
                            Iscontain = true;
                            break;
                        }
                    }
                    if (!Iscontain)
                    {
                        connection.Open();
                        command = new SqlCommand("insert into Food values(@name,@price)", connection);
                        command.Parameters.AddWithValue("@name", pName_Box.Text.ToUpper());
                        command.Parameters.AddWithValue("@price", Price_Num.Value);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("select Id from Food where Name=@name", connection);
                        command.Parameters.AddWithValue("@name", pName_Box.Text.ToUpper());
                        int Id_Food = Convert.ToInt32(command.ExecuteScalar());
                        command = new SqlCommand("select Name from Food", connection);
                        dr = command.ExecuteReader();
                        foodList.Clear();
                        while (dr.Read())
                        {
                            foodList.Add(new products { Name = dr["Name"].ToString() });
                        }
                        dr.Close();
                        foreach (ListViewItem num_Type in Type_List_Dbox.SelectedItems)
                        {
                            foreach (var x in type_food)
                            {

                                if (num_Type.Text == x.Name)
                                {
                                    command = new SqlCommand("insert into Menu_Food values(@Id_Food,@Id_Type)", connection);
                                    command.Parameters.AddWithValue("@Id_Food", Id_Food);
                                    command.Parameters.AddWithValue("@Id_Type", x.Id);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("kaydedildi");
                                    pName_Box.Text = "";
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kayıtlı");
                    }

                }
                else
                {
                    MessageBox.Show("Eksik Bir Şey Mi Var..?");
                }
            }

            else
            {
                MessageBox.Show("Seçim Yap");
            }
            connection.Close();
            Drink_Rbutton.Checked = false;
            Food_Rbutton.Checked = false;
            pName_Box.Text = "";
            Price_Num.Value = 1;
            Type_List_Dbox.Items.Clear();
        }
    }
}
