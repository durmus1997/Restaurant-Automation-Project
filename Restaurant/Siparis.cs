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
    public partial class Siparis : Form
    {
        SqlConnection connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
        SqlCommand command, command2;
        SqlDataReader dr;
        List<products> food = new List<products>();
        List<products> drink = new List<products>();
        List<recipe> recipes = new List<recipe>();
        decimal total = 0;
        decimal total2 = 0;
        private void Siparis_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
          
            connection.Open();
            command = new SqlCommand("select Name from dbo.Type_of_Food", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                Type_food.Items.Add(dr["Name"]);
            }
            dr.Close();
            command = new SqlCommand("select Name from dbo.Type_of_Drink", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                Type_drink.Items.Add(dr["Name"]);
            }
            dr.Close();
            connection.Close();
            Isopen();
        }
        void Isopen()
        {
            if (label7.Text != "")
            {
                label6.Visible = false;
                Add.Enabled = true;
                Save.Enabled = true;
                Food_list.Enabled = true;
                Drink_list.Enabled = true;
                Type_food.Enabled = true;
                Type_drink.Enabled = true;
                Choosen_list.Enabled = true;
            }
            else
            {
                label6.Text = "Lütfen Önce Masa Seçin..";
                Add.Enabled = false;
                Save.Enabled = false;
                Food_list.Enabled = false;
                Drink_list.Enabled = false;
                Type_food.Enabled = false;
                Type_drink.Enabled = false;
                Choosen_list.Enabled = false;
            }
        }

        public Siparis()
        {
            InitializeComponent();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            total2 = 0;
           
            connection.Open();
            string selected_drink = "";
            string selected_food = "";
            int id = 0;
            //sağ listeye drinkler dolduruluyor..drink listesi hazırlanıyor..varsa veritabınında içecek 1 azalıyor yoksa uyarı bitince uyarı
            if (Drink_list.SelectedItem != null && Drink_list.SelectedIndex.ToString() != "")
            {
                selected_drink = Drink_list.SelectedItem.ToString();
                command = new SqlCommand("select Price,Id from dbo.Drink where Name=@name", connection);
                command.Parameters.AddWithValue("@name", selected_drink);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    drink.Add(new products { Name = selected_drink, price = Convert.ToDecimal(dr["Price"]), Id = Convert.ToInt32(dr["Id"]) });
                    id = Convert.ToInt32(dr["Id"]);
                }
                dr.Close();
                command2 = new SqlCommand("select Piece from Drink where Id=@id", connection);
                command2.Parameters.AddWithValue("@id", id);
                int piece = Convert.ToInt32(command2.ExecuteScalar()) - 1;
                if (piece > 0)
                {
                    command2 = new SqlCommand("Update Drink set piece=@newp where Id=@id", connection);
                    command2.Parameters.AddWithValue("@id", id);
                    command2.Parameters.AddWithValue("@newp", piece);
                    command2.ExecuteNonQuery();
                }
                else if (piece == 0)
                {
                    MessageBox.Show(selected_drink + "Bitiyor... ona göre");
                }
                else if (piece < 0)
                {
                    MessageBox.Show(selected_drink + "abi o kalmamıs bea");
                }


            }
            //sağ listeye foodlar dolduruluyor..food listesi hazırlanıyor..varsa veritabınında food recp. kadar azalıyor yoksa uyarı bitince uyarı
            if (Food_list.SelectedItem != null && Food_list.SelectedIndex.ToString() != "")
            {
                selected_food = Food_list.SelectedItem.ToString();
                command = new SqlCommand("select Price,Id from dbo.Food where Name=@name", connection);
                command.Parameters.AddWithValue("@name", selected_food);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    food.Add(new products { Name = selected_food, price = Convert.ToDecimal(dr["Price"]), Id = Convert.ToInt32(dr["Id"]) });
                    id = Convert.ToInt32(dr["Id"]);
                }
                dr.Close();
                command = new SqlCommand("select Id_Material,Amount_KG,Amount_Piece from Recipe where Id_Food=@Fıd", connection);
                command.Parameters.AddWithValue("@Fıd", id);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["Amount_KG"]) != 0)
                    {
                        recipes.Add(new recipe { Id_Material = Convert.ToInt32(dr["Id_Material"]), Amount_KG = Convert.ToDecimal(dr["Amount_KG"]), Amount_Piece = -1 });
                    }
                    else if (Convert.ToInt32(dr["Amount_Piece"]) != 0)
                    {
                        recipes.Add(new recipe { Id_Material = Convert.ToInt32(dr["Id_Material"]), Amount_KG = -1, Amount_Piece = Convert.ToInt32(dr["Amount_Piece"]) });

                    }
                }
                dr.Close();
                //fodd lar materialden düştü
                foreach (var x in recipes)
                {
                    if (x.Amount_KG != -1)
                    {
                        command = new SqlCommand("select Amount_KG from Materials where Id=@ıd", connection);
                        command.Parameters.AddWithValue("@ıd", x.Id_Material);
                        decimal kg = Convert.ToDecimal(command.ExecuteScalar()) - x.Amount_KG;
                        if (kg > 0)
                        {
                            command = new SqlCommand("update Materials set Amount_KG=@kg where Id=@ıd", connection);
                            command.Parameters.AddWithValue("@ıd", x.Id_Material);
                            command.Parameters.AddWithValue("@kg", kg);
                            command.ExecuteNonQuery();
                        }
                        if (kg == 0)
                        {
                            MessageBox.Show(x.Id_Material.ToString() + "--Bu yemek bir daha çıkmaz eksik malzeme var ha...");
                        }
                        if (kg < 0)
                        {
                            MessageBox.Show("Haşa ben allah mıyım yokdan vaar edem....");
                        }
                    }
                    if (x.Amount_Piece != -1)
                    {

                        command = new SqlCommand("select Amount_Piece from Materials where Id=@ıd", connection);
                        command.Parameters.AddWithValue("@ıd", x.Id_Material);
                        int piece = Convert.ToInt32(command.ExecuteScalar()) - x.Amount_Piece;
                        if (piece > 0)
                        {
                            command = new SqlCommand("update Materials set Amount_Piece=@piece where Id=@ıd", connection);
                            command.Parameters.AddWithValue("@ıd", x.Id_Material);
                            command.Parameters.AddWithValue("@piece", piece);
                            command.ExecuteNonQuery();
                        }
                        if (piece == 0)
                        {
                            MessageBox.Show(x.Id_Material.ToString() + "--Bu yemek bir daha çıkmaz eksik malzeme var ha...");
                        }
                        if (piece < 0)
                        {
                            MessageBox.Show("Haşa ben allah mıyım yokdan vaar edem....");
                        }
                    }
                }
            }
            //sağ listeye yazıldı
            if (selected_drink != "")
                Choosen_list.Items.Add(selected_drink);
            //sağ listeye yazıldı
            if (selected_food != "")
                Choosen_list.Items.Add(selected_food);
            //total yazılyor
            foreach (var x in food)
            {
                total2 += x.price;

            }
            //total yazılyor
            foreach (var x in drink)
            {
                total2 += x.price;

            }
            Sum.Text = total2.ToString();
            Food_list.ClearSelected();
            Drink_list.ClearSelected();
            connection.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
           
            connection.Open();
            if (label6.Text != "")
            {
                int table_NO = Convert.ToInt32(label6.Text);
                foreach (var x in drink)
                {

                    command = new SqlCommand("insert into sold values(@id,NULL,@price,@date,@table,1)", connection);
                    command.Parameters.AddWithValue("@id", x.Id);
                    command.Parameters.AddWithValue("@price", x.price);
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.Parameters.AddWithValue("@table", table_NO);
                    command.ExecuteNonQuery();


                }
                foreach (var x in food)
                {

                    command = new SqlCommand("insert into sold values(NULL,@id,@price,@date,@table,NULL)", connection);
                    command.Parameters.AddWithValue("@id", x.Id);
                    command.Parameters.AddWithValue("@price", x.price);
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.Parameters.AddWithValue("@table", table_NO);
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
            Choosen_list.Items.Clear();
            Sum.Text = "";
            Drink_list.Items.Clear();
            Food_list.Items.Clear();
            label7.Text = "";
            Isopen();
            Siparis siparis = new Siparis();
            this.Hide();
            siparis.ShowDialog();


        }

        private void Type_Food_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food_list.Items.Clear();
            string index = Type_food.SelectedItem.ToString();
          
            connection.Open();
            command = new SqlCommand("select Name from dbo.Food where Id in(select Id_Food from dbo.Menu_Food where Id_Type in(select Id from dbo.Type_of_Food where Name=@type_Id))", connection);
            command.Parameters.AddWithValue("@type_Id", index);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                Food_list.Items.Add(dr["Name"]);
            }
            dr.Close();
            connection.Close();
        }

        private void Type_Drink_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drink_list.Items.Clear();
            string index = Type_drink.SelectedItem.ToString();
           
            connection.Open();
            command = new SqlCommand("select Name from dbo.Drink where Id in(select Id_Drink from dbo.Menu_Drink where Id_Type in(select Id from dbo.Type_of_Drink where Name=@type_Id))", connection);
            command.Parameters.AddWithValue("@type_Id", index);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                Drink_list.Items.Add(dr["Name"]);
            }
            dr.Close();
            connection.Close();
        }

        private void Choosen_list_DoubleClick(object sender, EventArgs e)
        {
            if (Choosen_list.SelectedItem != null)
            {
                
                connection.Open();
                string item = Choosen_list.SelectedItem.ToString();
                Choosen_list.Items.Remove(item);
                var isMatch = food.FirstOrDefault(x => x.Name == item);
                if (isMatch != null)
                {

                    var itemIndex = food.FirstOrDefault(a => a.Name == item);
                    food.Remove(itemIndex);
                    total = total2;
                    total -= itemIndex.price;
                    Sum.Text = total.ToString();
                    total2 = total;

                    command = new SqlCommand("select Id_Material from Recipe where Id_Food=@id", connection);
                    command.Parameters.AddWithValue("@id", itemIndex.Id);
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    foreach (var x in recipes)
                    {
                        if (x.Id_Material == id)
                        {
                            if (x.Amount_KG != -1)
                            {
                                command = new SqlCommand("select Amount_KG from Materials where Id=@ıd", connection);
                                command.Parameters.AddWithValue("@ıd", x.Id_Material);
                                decimal kg = Convert.ToDecimal(command.ExecuteScalar()) + x.Amount_KG;
                                if (kg > 0)
                                {
                                    command = new SqlCommand("update Materials set Amount_KG=@kg where Id=@ıd", connection);
                                    command.Parameters.AddWithValue("@ıd", x.Id_Material);
                                    command.Parameters.AddWithValue("@kg", kg);
                                    command.ExecuteNonQuery();
                                }
                                if (kg == 0)
                                {
                                    MessageBox.Show("Bu yemek bir daha çıkmaz eksik malzeme var ha...");
                                }
                                if (kg < 0)
                                {
                                    MessageBox.Show("Haşa ben allah mıyım yokdan vaar edem....");
                                }
                            }
                            if (x.Amount_Piece != -1)
                            {

                                command = new SqlCommand("select Amount_Piece from Materials where Id=@ıd", connection);
                                command.Parameters.AddWithValue("@ıd", x.Id_Material);
                                int piece = Convert.ToInt32(command.ExecuteScalar()) + x.Amount_Piece;
                                if (piece > 0)
                                {
                                    command = new SqlCommand("update Materials set Amount_Piece=@piece where Id=@ıd", connection);
                                    command.Parameters.AddWithValue("@ıd", x.Id_Material);
                                    command.Parameters.AddWithValue("@piece", piece);
                                    command.ExecuteNonQuery();
                                }
                                if (piece == 0)
                                {
                                    MessageBox.Show("Bu yemek bir daha çıkmaz eksik malzeme var ha...");
                                }
                                if (piece < 0)
                                {
                                    MessageBox.Show("Haşa ben allah mıyım yokdan vaar edem....");
                                }
                            }
                        }
                    }


                }
                //drinkler için geri yükleeme
                else
                {
                    var itemIndex = drink.FirstOrDefault(a => a.Name == item);
                    drink.Remove(itemIndex);
                    total = total2;
                    total -= itemIndex.price;
                    Sum.Text = total.ToString();
                    total2 = total;
                    command2 = new SqlCommand("select Piece from Drink where name=@name", connection);
                    command2.Parameters.AddWithValue("@name", itemIndex.Name);
                    int piece = Convert.ToInt32(command2.ExecuteScalar()) + 1;
                    command2 = new SqlCommand("update Drink set piece=@piece where name=@name", connection);
                    command2.Parameters.AddWithValue("@name", itemIndex.Name);
                    command2.Parameters.AddWithValue("@piece", piece);
                    command2.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void table_button_Click(object sender, EventArgs e)
        {
            Tables table = new Tables();
            table.Show();
            this.Hide();

        }

    }
}
