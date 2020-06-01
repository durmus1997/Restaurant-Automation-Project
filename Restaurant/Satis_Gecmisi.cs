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
    public partial class Satis_Gecmisi : Form
    {
        private List<Sold> foodSold_List = new List<Sold>();
        private List<Sold> drinkSold_List = new List<Sold>();
        private SqlConnection connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
        private SqlCommand commandName;
        private SqlDataReader dr;
        private string strFood;
        private string strDrink;

        public Satis_Gecmisi()
        {
            InitializeComponent();
            //TestFunction();
        }
        private void Check_Click(object sender, EventArgs e)
        {
            Product_List.Items.Clear();
            Date_List.Items.Clear();
            foodSold_List.Clear();
            drinkSold_List.Clear();
            decimal price = 0;
            connection.Open();
            if (startDate.Value.Date != endDate.Value.Date)
            {
                strFood = "select f.Name as foodName,f.Price as foodPrice ,Datee from dbo.Food f, dbo.Sold s where EXISTS (Select Id_Food from dbo.Sold where Datee between @startDate and @endDate AND f.Id = Id_Food and s.Datee = Datee) order by s.Datee ASC";
                strDrink = "select d.Name as DrinkName,d.Price as drinkPrice, Datee from dbo.Drink d, dbo.Sold s where EXISTS (Select Id_Drink from dbo.Sold, dbo.Drink where Datee between @startDate and @endDate AND d.Id = Id_Drink and s.Datee = Datee) order by s.Datee ASC";
                commandName = new SqlCommand(strFood, connection);
                commandName.Parameters.AddWithValue("@startDate", startDate.Value.Date);
                commandName.Parameters.AddWithValue("@endDate", endDate.Value.Date);
            }
            else
            {
                strFood = "select f.Name as foodName,f.Price as foodPrice ,Datee from dbo.Food f, dbo.Sold s where EXISTS (Select Id_Food from dbo.Sold where Datee = @startDate AND f.Id = Id_Food and s.Datee = Datee) order by s.Datee ASC";
                strDrink = "select d.Name as DrinkName,d.Price as drinkPrice, Datee from dbo.Drink d, dbo.Sold s where EXISTS (Select Id_Drink from dbo.Sold, dbo.Drink where Datee = @startDate AND d.Id = Id_Drink and s.Datee = Datee) order by s.Datee ASC";
                commandName = new SqlCommand(strFood, connection);
                commandName.Parameters.AddWithValue("@startDate", startDate.Value.Date);

            }

            dr = commandName.ExecuteReader();
            while (dr.Read())
            {
                foodSold_List.Add(new Sold { Name = dr["foodName"].ToString(), price = (decimal)dr["foodPrice"], Datee = (DateTime)dr["Datee"] });
            }
            dr.Close();
            commandName = new SqlCommand(strDrink, connection);
            commandName.Parameters.AddWithValue("@startDate", startDate.Value);
            commandName.Parameters.AddWithValue("@endDate", endDate.Value);
            dr = commandName.ExecuteReader();
            while (dr.Read())
            {
                drinkSold_List.Add(new Sold { Name = dr["drinkName"].ToString(), price = (decimal)dr["drinkPrice"], Datee = (DateTime)dr["Datee"] });
            }
            dr.Close();
            foodSold_List.AddRange(drinkSold_List);

            List<Sold> orderedList = foodSold_List.OrderBy(o => o.Datee).ToList();

            foreach (var item in orderedList)
            {
                Product_List.Items.Add(item.Name);
                Date_List.Items.Add(item.Datee);
                price += item.price;
            }
            TotalPrice.Text = price.ToString() + " ₺";
            connection.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}

[System.Serializable]
public class Sold
{
    public string Name { get; set; }
    public decimal price { get; set; }
    public DateTime Datee { get; set; }
}
