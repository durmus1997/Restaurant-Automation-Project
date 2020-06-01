using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManangementProject
{

    public partial class Tarif : Form
    {

        SqlConnection connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
        SqlCommand commandID;
        SqlCommand commandName;
        SqlCommand commandInsert;
        SqlCommand commandBool;
        SqlDataReader dr;
        List<products> Selected_item_list = new List<products>();
        private int selectedMaterialId;
        private int selectedFoodId;
        private decimal selectedAmount;
        private string selectedFood;
        private string selectedMaterial = null;
        private bool isAmount = true;
        public Tarif()
        {
            InitializeComponent();
        }

        private void Tarif_Load(object sender, EventArgs e)
        {
            connection.Open();
            commandName = new SqlCommand("select Name from dbo.Type_of_Food", connection);
            dr = commandName.ExecuteReader();
            while (dr.Read())
            {
                Type_Food.Items.Add(dr["Name"]);
            }
            dr.Close();
            connection.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Type_Food_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food_List.Items.Clear();
            Material_List.Items.Clear();
            string foodId = Type_Food.SelectedItem.ToString();
            connection.Open();
            commandName = new SqlCommand("select Name from dbo.Food where Id in(select Id_Food from dbo.Menu_Food where Id_Type in(select Id from dbo.Type_of_Food where Name=@type_Id))", connection);
            commandName.Parameters.AddWithValue("@type_Id", foodId);
            dr = commandName.ExecuteReader();
            while (dr.Read())
            {
                Food_List.Items.Add(dr["Name"]);
            }
            dr.Close();
            commandName = new SqlCommand("select Name from dbo.Materials", connection);

            dr = commandName.ExecuteReader();
            while (dr.Read())
            {
                Material_List.Items.Add(dr["Name"]);
            }
            dr.Close();
            connection.Close();
        }

        private void Food_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipe_List.Items.Clear();
            selectedFood = null;
            if (Food_List.SelectedItem != null)
            {
                selectedFood = Food_List.SelectedItem.ToString();
                connection.Open();

                commandID = new SqlCommand("select Id from dbo.Food where Name=@selected_Name", connection);
                commandID.Parameters.AddWithValue("@selected_Name", selectedFood);
                dr = commandID.ExecuteReader();
                while (dr.Read())
                {
                    selectedFoodId = (int)dr["Id"];
                }
                dr.Close();

                commandName = new SqlCommand("select Name from dbo.Materials where Id in (select Id_Material from dbo.Recipe where Id_Food in(" + selectedFoodId + "))", connection);
                commandName.Parameters.AddWithValue("@selected_Name", selectedFood);
                dr = commandName.ExecuteReader();
                while (dr.Read())
                {
                    Recipe_List.Items.Add(dr["Name"]);
                }
                dr.Close();

                connection.Close();
            }
        }

        private void Material_List_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (Material_List.SelectedItem != null)
            {
                selectedMaterial = Material_List.SelectedItem.ToString();
                connection.Open();
                commandID = new SqlCommand("select Id from dbo.Materials where Name=@selected_Material", connection);
                commandID.Parameters.AddWithValue("@selected_Material", selectedMaterial);
                dr = commandID.ExecuteReader();
                while (dr.Read())
                {
                    selectedMaterialId = (int)(dr["Id"]);
                }
                dr.Close();

                commandBool = new SqlCommand("select Amount_Piece from dbo.Materials where Name = @selectedMaterial", connection);
                commandBool.Parameters.AddWithValue("@selectedMaterial", selectedMaterial);
                dr = commandBool.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["Amount_Piece"])>0)
                    {
                        Amount_Numeric.DecimalPlaces = 0;
                        Amount.Text = "Piece :";
                        isAmount = false;
                    }
                    else
                    {
                        Amount_Numeric.DecimalPlaces = 3;
                        Amount.Text = "Amount KG :";
                        isAmount = true;
                    }
                }
                dr.Close();
                connection.Close();

            }
            else
            {
                selectedMaterialId = 0;
            }


        }
        private void Add_Material_Button(object sender, EventArgs e)
        {
            if (selectedFood != null && !Recipe_List.Items.Contains(selectedMaterial) && Amount_Numeric.Value>0)
            {
                connection.Open();
                commandInsert = (isAmount) ? new SqlCommand("insert into Recipe values(@Id_Food,@Id_Material,@Amount,0)", connection) : new SqlCommand("insert into Recipe values(@Id_Food,@Id_Material,0,@Piece)", connection);
                commandInsert.Parameters.AddWithValue("@Id_Food", selectedFoodId);
                commandInsert.Parameters.AddWithValue("@Id_Material", selectedMaterialId);
                if (isAmount)
                {
                    commandInsert.Parameters.AddWithValue("@Amount", Amount_Numeric.Value);
                }
                else
                {
                    commandInsert.Parameters.AddWithValue("@Piece", (int)Amount_Numeric.Value);
                }
                commandInsert.ExecuteNonQuery();
                Recipe_List.Items.Clear();
                commandName = new SqlCommand("select Name from dbo.Materials where Id in (select Id_Material from dbo.Recipe where Id_Food in(" + selectedFoodId + "))", connection);
                commandName.Parameters.AddWithValue("@selected_Name", selectedFood);
                dr = commandName.ExecuteReader();
                while (dr.Read())
                {
                    Recipe_List.Items.Add(dr["Name"]);
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Kardes oruc musun zaten var..");
            }
        }

        private void Recipe_List_DoubleClick(object sender, EventArgs e)
        {
            if (Recipe_List.SelectedItem != null)
            {
                connection.Open();
                string selectedName = Recipe_List.SelectedItem.ToString();
                commandName = new SqlCommand("delete from Recipe where Id in (select a.Id from(select Id_Food, Id from dbo.Recipe r where Id_Material in (select Id from dbo.Materials where Name = @selectedName))a join (select Id from dbo.Food where Name = @selectedFood) b on b.Id = a.Id_Food) ", connection);
                commandName.Parameters.AddWithValue("@selectedFood", selectedFood);
                commandName.Parameters.AddWithValue("@selectedName", selectedName);
                commandName.ExecuteNonQuery();

                Recipe_List.Items.Clear();
                commandName = new SqlCommand("select Name from dbo.Materials where Id in (select Id_Material from dbo.Recipe where Id_Food in(" + selectedFoodId + "))", connection);
                commandName.Parameters.AddWithValue("@selected_Name", selectedFood);
                dr = commandName.ExecuteReader();
                while (dr.Read())
                {
                    Recipe_List.Items.Add(dr["Name"]);
                }
                dr.Close();

                connection.Close();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Recipe_List.SelectedItem != null)
            {
                connection.Open();
                string selectedName = Recipe_List.SelectedItem.ToString();
                commandName = new SqlCommand("delete from Recipe where Id in (select a.Id from(select Id_Food, Id from dbo.Recipe r where Id_Material in (select Id from dbo.Materials where Name = @selectedName))a join (select Id from dbo.Food where Name = @selectedFood) b on b.Id = a.Id_Food) ", connection);
                commandName.Parameters.AddWithValue("@selectedFood", selectedFood);
                commandName.Parameters.AddWithValue("@selectedName", selectedName);
                commandName.ExecuteNonQuery();

                Recipe_List.Items.Clear();
                commandName = new SqlCommand("select Name from dbo.Materials where Id in (select Id_Material from dbo.Recipe where Id_Food in(" + selectedFoodId + "))", connection);
                commandName.Parameters.AddWithValue("@selected_Name", selectedFood);
                dr = commandName.ExecuteReader();
                while (dr.Read())
                {
                    Recipe_List.Items.Add(dr["Name"]);
                }
                dr.Close();

                connection.Close();
            }
        }

        private void Material_List_DoubleClick(object sender, EventArgs e)
        {
            if (selectedFood != null && !Recipe_List.Items.Contains(selectedMaterial) && Amount_Numeric.Value > 0)
            {
                selectedAmount = (int)Amount_Numeric.Value;
                connection.Open();
                commandInsert = (isAmount) ? new SqlCommand("insert into Recipe values(@Id_Food,@Id_Material,@Amount,0)", connection) : new SqlCommand("insert into Recipe values(@Id_Food,@Id_Material,0,@Piece)", connection);
                commandInsert.Parameters.AddWithValue("@Id_Food", selectedFoodId);
                commandInsert.Parameters.AddWithValue("@Id_Material", selectedMaterialId);
                if (isAmount)
                {
                    commandInsert.Parameters.AddWithValue("@Amount", Amount_Numeric.Value);
                }
                else
                {
                    commandInsert.Parameters.AddWithValue("@Piece", (int)Amount_Numeric.Value);
                }
                commandInsert.ExecuteNonQuery();
                Recipe_List.Items.Clear();
                commandName = new SqlCommand("select Name from dbo.Materials where Id in (select Id_Material from dbo.Recipe where Id_Food in(" + selectedFoodId + "))", connection);
                commandName.Parameters.AddWithValue("@selected_Name", selectedFood);
                dr = commandName.ExecuteReader();
                while (dr.Read())
                {
                    Recipe_List.Items.Add(dr["Name"]);
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Kardes oruc musun zaten var..");
            }
        }
    }
}
