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
    public partial class Sil : Form
    {
        SqlConnection connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
        SqlCommand command,command2;
        SqlDataReader dr;
        public Sil()
        {
            InitializeComponent();
        }

        private void Sil_Load(object sender, EventArgs e)
        {
            Menu_List_Dbox.Enabled = false;
        }

        private void Food_Rbutton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Food_Rbutton.Checked)
            {
                Menu_List_Dbox.Items.Clear();
                connection.Open();
                command = new SqlCommand("select Name from Food", connection);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Menu_List_Dbox.Items.Add(dr["Name"]);
                }
                dr.Close();
                Menu_List_Dbox.Enabled = true;
                connection.Close();
            }

        }

        private void Drink_Rbutton_CheckedChanged(object sender, EventArgs e)
        {
           
            if (Drink_Rbutton.Checked)
            {
                Menu_List_Dbox.Items.Clear();
                connection.Open();
                command = new SqlCommand("select Name from Drink", connection);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Menu_List_Dbox.Items.Add(dr["Name"]);
                }
                dr.Close();
                Menu_List_Dbox.Enabled = true;
                connection.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
            var name = Menu_List_Dbox.SelectedItem;
            if (name.ToString() == "" || name==null)
            {
                MessageBox.Show("Sileceğim..Ama neyi..?");
            }
            else
            {

                if (Food_Rbutton.Checked)
                {                   
                    connection.Open();
                    command = new SqlCommand("select Id from Food where Name=@name", connection);
                    command.Parameters.AddWithValue("@name", name.ToString());
                    var Iscontain = command.ExecuteScalar();
                    if (Iscontain != null)
                    {
                        command = new SqlCommand("delete from Food where Name=@name", connection);
                        command.Parameters.AddWithValue("@name", name.ToString());
                        command2 = new SqlCommand("delete from Menu_Food where Id_Food=@id", connection);
                        command2.Parameters.AddWithValue("@id", Convert.ToInt32(Iscontain));
                        command.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Sildim");
                        Menu_List_Dbox.Items.Clear();
                        Food_Rbutton.Checked = false;
                        Menu_List_Dbox.Text = "";
                    }
                    else
                        MessageBox.Show("Kayıtlı ürün bulunamadı.. İşlem Başarısız..");
                    connection.Close();
                }
                else if (Drink_Rbutton.Checked)
                {      
                    connection.Open();
                    command = new SqlCommand("select Id from Drink where Name=@name", connection);
                    command.Parameters.AddWithValue("@name", name.ToString());
                    var Iscontain = command.ExecuteScalar();
                    if (Iscontain != null)
                    {
                        command = new SqlCommand("delete from Drink where Name=@name", connection);
                        command.Parameters.AddWithValue("@name", name.ToString());
                        command2 = new SqlCommand("delete from Menu_Drink where Id_Drink=@id", connection);
                        command2.Parameters.AddWithValue("@id", Convert.ToInt32(Iscontain));
                        command.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Sildim..");
                        Menu_List_Dbox.Items.Clear();
                        Drink_Rbutton.Checked = false;
                        Menu_List_Dbox.Text = "";
                    }
                    else
                        MessageBox.Show("Kayıtlı ürün bulunamadı.. İşlem Başarısız..");
                    connection.Close();

                }
                else
                    MessageBox.Show("Seçim yap Seçimm..");
            }
        }
    }
}
