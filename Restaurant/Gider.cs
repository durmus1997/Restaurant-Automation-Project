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
    public partial class Gider : Form
    {

        SqlConnection connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
        SqlCommand commandName;
        SqlCommand commandInsert;
        SqlCommand commandID;
        SqlCommand commandUpdate;
        SqlDataReader dr;
        List<string> materialList = new List<string>();
        List<string> drinkList = new List<string>();
        int selectedMaterialId = 0;
        int drinkPiece = 0;
        int materialPiece = 0;
        decimal materialAmount = 0;
        bool isKG = false;
        bool isDrink = false;


        public Gider()
        {
            InitializeComponent();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Ekle_Gider_Click(object sender, EventArgs e)
        {
            if (selectedMaterialId != 0)
            {
                if (numericUpDown.Value != 0)
                {

                    if (numericUpDown_Cost.Value != 0)
                    {
                        if (!isDrink)
                        {
                            connection.Open();
                            commandInsert = (isKG) ? new SqlCommand("insert into dbo.Cost values(@Id_Material,@Date,@Price,NULL,@AmountKG,NULL)", connection) : new SqlCommand("insert into dbo.Cost values(@Id_Material,@Date,@Price,@Piece,NULL,NULL)", connection);
                            commandInsert.Parameters.AddWithValue("@Date", DateTime.Now);
                            commandInsert.Parameters.AddWithValue("@Id_Material", selectedMaterialId);
                            commandInsert.Parameters.AddWithValue("@Price", numericUpDown_Cost.Value);
                            if (isKG)
                            {
                                commandInsert.Parameters.AddWithValue("@AmountKG", numericUpDown.Value);
                            }
                            else
                            {
                                commandInsert.Parameters.AddWithValue("@Piece", (int)numericUpDown.Value);
                            }
                            commandInsert.ExecuteNonQuery();
                            connection.Close();
                        }
                        else
                        {
                            connection.Open();
                            commandInsert = new SqlCommand("insert into dbo.Cost values(NULL,@Date,@Price,NULL,NULL,@Id_Drink)", connection);
                            commandInsert.Parameters.AddWithValue("@Date", DateTime.Now);
                            commandInsert.Parameters.AddWithValue("@Price", numericUpDown_Cost.Value);
                            commandInsert.Parameters.AddWithValue("@Id_Drink", selectedMaterialId);

                            commandInsert.ExecuteNonQuery();
                            connection.Close();
                        }

                        connection.Open();
                        if (isDrink)
                        {
                            commandUpdate = new SqlCommand("Update dbo.Drink Set Piece += @SetPiece where Id = @selectedId", connection);
                            commandUpdate.Parameters.AddWithValue("@SetPiece", numericUpDown.Value);
                            commandUpdate.Parameters.AddWithValue("@selectedId", selectedMaterialId);
                            MessageBox.Show("İçecek güncellendi");
                            MessageBox.Show(selectedMaterialId + "");
                            commandUpdate.ExecuteNonQuery();
                        }
                        else if (isKG)
                        {
                            commandUpdate = new SqlCommand("Update dbo.Materials Set Amount_KG += @SetAmount where Id = @selectedId", connection);
                            commandUpdate.Parameters.AddWithValue("@SetAmount", numericUpDown.Value);
                            commandUpdate.Parameters.AddWithValue("@selectedId", selectedMaterialId);
                            commandUpdate.ExecuteNonQuery();
                        }
                        else
                        {
                            commandUpdate = new SqlCommand("Update dbo.Materials Set Amount_Piece += @SetAmount where Id = @selectedId", connection);
                            commandUpdate.Parameters.AddWithValue("@SetAmount", numericUpDown.Value);
                            commandUpdate.Parameters.AddWithValue("@selectedId", selectedMaterialId);
                            commandUpdate.ExecuteNonQuery();
                        }

                        connection.Close();
                        ResetFields();


                        MessageBox.Show("Gider Eklendi...");
                    }
                    else
                    {
                        MessageBox.Show("Lutfen Fiyat giriniz");
                    }
                }
                else
                {
                    MessageBox.Show("Lutfen urun adedi giriniz");
                }
            }
            else
            {
                MessageBox.Show("Lutfen material seciniz");
            }
        }

        private void Material_Combo_Box(object sender, EventArgs e)
        {
            drinkPiece = 0;
            materialPiece = 0;
            materialAmount = 0;

            if (MaterialComboBox.SelectedItem != null)
            {
                string selectedDrink = MaterialComboBox.SelectedItem.ToString();
                if (isDrink)
                {
                    connection.Open();
                    commandID = new SqlCommand("select Id,Piece from dbo.Drink where Name=@selected_Material", connection);
                    commandID.Parameters.AddWithValue("@selected_Material", selectedDrink);
                    dr = commandID.ExecuteReader();
                    while (dr.Read())
                    {
                        selectedMaterialId = (int)(dr["Id"]);
                        drinkPiece = (int)(dr["Piece"]);
                        MessageBox.Show(drinkPiece + "");
                    }
                    dr.Close();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    commandID = new SqlCommand("select Id,Amount_Piece,Amount_KG from dbo.Materials where Name=@selected_Material", connection);
                    commandID.Parameters.AddWithValue("@selected_Material", selectedDrink);
                    dr = commandID.ExecuteReader();
                    while (dr.Read())
                    {
                        selectedMaterialId = (int)(dr["Id"]);

                        if ((decimal)dr["Amount_KG"] != 0)
                        {
                            materialAmount = (decimal)dr["Amount_KG"];
                        }
                        else if ((int)dr["Amount_Piece"] != 0)
                        {
                            materialPiece = ((int)dr["Amount_Piece"]);
                        }

                        if (materialAmount > 0)
                        {
                            isKG = true;
                            numericUpDown.DecimalPlaces = 3;
                            MessageBox.Show(materialAmount + "");
                        }
                        else if (materialPiece > 0)
                        {
                            isKG = false;
                            numericUpDown.DecimalPlaces = 0;
                            MessageBox.Show(materialPiece + "");
                        }
                    }
                    dr.Close();
                    connection.Close();
                }
            }
        }
        private void ResetFields()
        {
            numericUpDown.Value = 0;
            selectedMaterialId = 0;
            numericUpDown_Cost.Value = 0;
            MaterialComboBox.SelectedItem = null;
            MaterialComboBox.Text = "";
            drinkPiece = 0;
            materialPiece = 0;
            materialAmount = 0;
        }

        private void Material_CheckedChanged(object sender, EventArgs e)
        {
            MaterialComboBox.Items.Clear();
            MaterialComboBox.Text = null;

            foreach (var item in materialList)
            {
                MaterialComboBox.Items.Add(item);
            }

            UrunAdi.Text = "Material Seç :";
            isDrink = false;
        }

        private void Drink_CheckedChanged(object sender, EventArgs e)
        {
            MaterialComboBox.Items.Clear();
            MaterialComboBox.Text = null;
            foreach (var item in drinkList)
            {
                MaterialComboBox.Items.Add(item);
            }
            numericUpDown.DecimalPlaces = 0;
            isDrink = true;
            UrunAdi.Text = "İçecek Seç :";
        }

        private void Gider_Load(object sender, EventArgs e)
        {

            MaterialComboBox.Items.Clear();

            connection.Open();
            commandName = new SqlCommand("select Name from dbo.Materials", connection);
            dr = commandName.ExecuteReader();
            while (dr.Read())
            {
                materialList.Add((string)dr["Name"]);
            }
            dr.Close();
            connection.Close();


            connection.Open();
            commandName = new SqlCommand("select Name from dbo.Drink", connection);
            dr = commandName.ExecuteReader();
            while (dr.Read())
            {
                drinkList.Add((string)dr["Name"]);
            }
            dr.Close();
            connection.Close();
            MaterialComboBox.Items.Clear();

            foreach (var item in materialList)
            {
                MaterialComboBox.Items.Add(item);
            }
        }
    }
}
