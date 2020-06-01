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
    public partial class Guncelle : Form
    {
        List<UpdateProducts> foods = new List<UpdateProducts>();
        List<UpdateProducts> drinks = new List<UpdateProducts>();
        List<string> TypeOfDrinks = new List<string>();
        List<string> TypeOfFoods = new List<string>();
        List<string> CurrentProductTypes = new List<string>();
        List<string> foodName = new List<string>();
        List<string> drinkName = new List<string>();
        List<Change> deletedFoodTypes = new List<Change>();
        List<Change> deletedDrinkTypes = new List<Change>();
        List<Change> addedFoodTypes = new List<Change>();
        List<Change> addedDrinkTypes = new List<Change>();
        SqlConnection connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
        SqlCommand commandFood;
        SqlCommand commandDrink;
        SqlCommand commandType;
        SqlCommand commandUpdate;
        bool isFood = true;
        private int index;

        SqlDataReader dr;
        public Guncelle()
        {
            InitializeComponent();
            GetProductsFromDataBase();
            FoodOrDrink(foodName, TypeOfFoods);
            P_Amount_Label.Visible = false;
            AmountPieceText.Visible = false;
            ProductAmountBox.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Update_Product_Click(object sender, EventArgs e)
        {
            if (DropDown.SelectedItem != null)
            {
                connection.Open();

                foreach (var item in deletedDrinkTypes)
                {
                    commandUpdate = new SqlCommand("Delete dbo.Menu_Drink where Id_Drink = @deletedID and Id_Type = @deletedType ", connection);
                    commandUpdate.Parameters.AddWithValue("@deletedID", item.productID);
                    commandUpdate.Parameters.AddWithValue("@deletedType", item.typeID);
                    commandUpdate.ExecuteNonQuery();
                }
                foreach (var item in deletedFoodTypes)
                {
                    commandUpdate = new SqlCommand("Delete dbo.Menu_Food where Id_Food = @deletedID and Id_Type = @deletedType ", connection);
                    commandUpdate.Parameters.AddWithValue("@deletedID", item.productID);
                    commandUpdate.Parameters.AddWithValue("@deletedType", item.typeID);
                    commandUpdate.ExecuteNonQuery();
                }
                foreach (var item in addedFoodTypes)
                {
                    commandUpdate = new SqlCommand("insert into dbo.Menu_Food values(@insertID,@insertType) ", connection);
                    commandUpdate.Parameters.AddWithValue("@insertID", item.productID);
                    commandUpdate.Parameters.AddWithValue("@insertType", item.typeID);
                    commandUpdate.ExecuteNonQuery();
                }
                foreach (var item in addedDrinkTypes)
                {
                    commandUpdate = new SqlCommand("insert into dbo.Menu_Drink values(@insertID,@insertType) ", connection);
                    commandUpdate.Parameters.AddWithValue("@insertID", item.productID);
                    commandUpdate.Parameters.AddWithValue("@insertType", item.typeID);
                    commandUpdate.ExecuteNonQuery();
                }

                UpdateInformation();

                MessageBox.Show("Güncellendi");

                connection.Close();
                ResetAllData();

                Guncelle newForm1 = new Guncelle();
                newForm1.Show();
                this.Dispose(false);
            }
            else
            {
                MessageBox.Show("Onur, yapma böyle şeyler!!!");
            }
        }




        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFood)
            {
                index = foods.FindIndex(o => o.Name == DropDown.SelectedItem.ToString());
                SetAllData(index, foods);
            }
            else
            {
                index = drinks.FindIndex(o => o.Name == DropDown.SelectedItem.ToString());
                SetAllData(index, drinks);
            }

            DropDown.Enabled = false;
            IsFood.Enabled = false;
            IsDrink.Enabled = false;
        }

        private void IsFood_CheckedChanged(object sender, EventArgs e)
        {
            P_Amount_Label.Visible = false;
            AmountPieceText.Visible = false;
            ProductAmountBox.Visible = false;
            FoodOrDrink(foodName, TypeOfFoods);
            ResetAllData();
            ResetUpdateData();
            isFood = true;
        }
        private void IsDrink_CheckedChanged(object sender, EventArgs e)
        {
            P_Amount_Label.Visible = true;
            AmountPieceText.Visible = true;
            ProductAmountBox.Visible = true;
            FoodOrDrink(drinkName, TypeOfDrinks);
            ResetAllData();
            ResetUpdateData();
            isFood = false;
        }
        #region Functions
        private void FoodOrDrink(List<string> products, List<string> type)
        {
            DropDown.Items.Clear();
            TypeComboBox.Items.Clear();
            TypeListBox.Items.Clear();
            foreach (var item in products)
            {
                DropDown.Items.Add(item);

            }
            foreach (var item in type)
            {
                TypeComboBox.Items.Add(item);
            }
        }
        private void GetProductsFromDataBase()
        {
            TypeOfDrinks.Clear();
            TypeOfFoods.Clear();
            foods.Clear();
            drinks.Clear();

            connection.Open();
            commandFood = new SqlCommand("Select f.Id as FoodId,f.Name as FoodName,f.Price as FoodPrice, tf.Name as TypeOfFood, tf.Id as foodTypeID from dbo.Food f,dbo.Type_of_Food tf, dbo.Menu_Food mf where f.Id = mf.Id_Food and mf.Id_Type = tf.Id order by f.Name", connection);
            commandDrink = new SqlCommand("select  d.Id as DrinkId, d.Name as DrinkName, d.Price as DrinkPrice,d.Piece as DrinkPiece, td.Name as TypeofDrink,td.Id as drinkTypeID from dbo.Drink d, dbo.Type_of_Drink td,dbo.Menu_Drink md where d.Id = md.Id_Drink and md.Id_Type = td.Id order by d.Name", connection);
            commandType = new SqlCommand("select tf.Name as TypeFoodName from dbo.Type_of_Food tf", connection);

            dr = commandFood.ExecuteReader();
            while (dr.Read())
            {
                foods.Add(new UpdateProducts { Id = (int)dr["FoodId"], Name = dr["FoodName"].ToString(), Price = (decimal)dr["FoodPrice"], TypeofProduct = dr["TypeofFood"].ToString(), TypeID = (int)dr["foodTypeID"], Piece = 0 });
            }
            dr.Close();

            commandFood = new SqlCommand("Select Name from dbo.Food", connection);
            dr = commandFood.ExecuteReader();
            while (dr.Read())
            {
                foodName.Add(dr["Name"].ToString());
            }
            dr.Close();

            dr = commandDrink.ExecuteReader();
            while (dr.Read())
            {
                drinks.Add(new UpdateProducts { Id = (int)dr["DrinkId"], Name = dr["DrinkName"].ToString(), Price = (decimal)dr["DrinkPrice"], TypeofProduct = dr["TypeofDrink"].ToString(), TypeID = (int)dr["drinkTypeID"], Piece = (int)dr["DrinkPiece"] });
            }
            dr.Close();

            commandDrink = new SqlCommand("Select Name from dbo.Drink", connection);
            dr = commandDrink.ExecuteReader();
            while (dr.Read())
            {
                drinkName.Add(dr["Name"].ToString());
            }
            dr.Close();

            dr = commandType.ExecuteReader();
            while (dr.Read())
            {
                TypeOfFoods.Add(dr["TypeFoodName"].ToString());
            }
            dr.Close();

            commandType = new SqlCommand("select td.Name as TypeDrinkName from dbo.Type_of_Drink td", connection);

            dr = commandType.ExecuteReader();
            while (dr.Read())
            {
                TypeOfDrinks.Add(dr["TypeDrinkName"].ToString());
            }
            dr.Close();


            connection.Close();
        }

        private void SetAllData(int index, List<UpdateProducts> products)
        {
            TypeListBox.Items.Clear();
            CurrentProductTypes.Clear();
            PName_Label.Text = products[index].Name;
            P_Price_Label.Text = products[index].Price.ToString() + " ₺";
            P_Amount_Label.Text = products[index].Piece.ToString();
            ProductNameBox.Text = products[index].Name;
            ProductPriceBox.Value = products[index].Price;
            ProductAmountBox.Value = products[index].Piece;
            foreach (var item in products)
            {
                if (item.Name == products[index].Name)
                {
                    CurrentProductTypes.Add(item.TypeofProduct);
                    TypeListBox.Items.Add(item.TypeofProduct);
                }
            }
        }
        private void ResetAllData()
        {
            PName_Label.Text = "-";
            P_Price_Label.Text = "0 ₺";
            P_Amount_Label.Text = "-";
            DropDown.Text = "";

            ProductAmountBox.Value = 0;
            ResetUpdateData();

        }

        private void ResetUpdateData()
        {
            ProductNameBox.Text = null;
            ProductPriceBox.Value = 0;
            ProductAmountBox.Value = 0;
            TypeListBox.Items.Clear();
            TypeComboBox.Text = "";
        }

        private void UpdateInformation()
        {
            if (isFood)
            {
                commandUpdate = new SqlCommand("Update dbo.Food  set Name = @name, Price = @price where Id = @selectedFoodID", connection);
                commandUpdate.Parameters.AddWithValue("@name", ProductNameBox.Text);
                commandUpdate.Parameters.AddWithValue("@price", ProductPriceBox.Value);
                commandUpdate.Parameters.AddWithValue("@selectedFoodID", foods[index].Id);
                commandUpdate.ExecuteNonQuery();
            }
            else
            {
                commandUpdate = new SqlCommand("Update dbo.Drink set Name = @name, Price = @price,Piece = @piece where Id = @selectedDrinkID", connection);
                commandUpdate.Parameters.AddWithValue("@name", ProductNameBox.Text);
                commandUpdate.Parameters.AddWithValue("@price", ProductPriceBox.Value);
                commandUpdate.Parameters.AddWithValue("@piece", ProductAmountBox.Value);
                commandUpdate.Parameters.AddWithValue("@selectedDrinkID", drinks[index].Id);
                commandUpdate.ExecuteNonQuery();
            }

        }

        #endregion Functions

        private void TypeListBox_DoubleClick(object sender, EventArgs e)
        {
            if (TypeListBox.Items.Count > 1)
            {
                int typeIndex = TypeComboBox.Items.IndexOf(TypeListBox.SelectedItem) + 1;
                if (isFood)
                {
                    deletedFoodTypes.Add(new Change { productID = foods[index].Id, typeID = typeIndex });
                }
                else
                {
                    deletedDrinkTypes.Add(new Change { productID = drinks[index].Id, typeID = typeIndex });
                }

                CurrentProductTypes.Remove(TypeListBox.SelectedItem.ToString());
                TypeListBox.Items.Clear();

                foreach (var item in CurrentProductTypes)
                {
                    TypeListBox.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Onur, Sen misin kardeşim ?");

            }

        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeListBox.Items.Add(TypeComboBox.SelectedItem.ToString());
            if (isFood)
            {
                addedFoodTypes.Add(new Change { productID = foods[index].Id, typeID = TypeComboBox.SelectedIndex + 1 });
            }
            else
            {
                addedDrinkTypes.Add(new Change { productID = drinks[index].Id, typeID = TypeComboBox.SelectedIndex + 1 });

            }

            if (!CurrentProductTypes.Contains(TypeComboBox.SelectedItem.ToString()))
                CurrentProductTypes.Add(TypeComboBox.SelectedItem.ToString());

            TypeListBox.Items.Clear();
            foreach (var item in CurrentProductTypes)
            {
                TypeListBox.Items.Add(item);

            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ResetAllData();
            DropDown.Enabled = true;
            IsFood.Enabled = true;
            IsDrink.Enabled = true;

        }
    }
}

[System.Serializable]
public class UpdateProducts
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Piece { get; set; }
    public decimal Price { get; set; }
    public string TypeofProduct { get; set; }
    public int TypeID { get; set; }

}
[System.Serializable]
public class Change
{
    public int productID { get; set; }
    public int typeID { get; set; }
}
