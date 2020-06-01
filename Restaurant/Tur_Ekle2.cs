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
    public partial class Tur_Ekle2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public Tur_Ekle2()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Type_Tbox.Text != ""&& (Food_Type_Rbutton.Checked || Drink_Type_Rbutton.Checked))
            {
                connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
                if (Drink_Type_Rbutton.Checked)
                {
                    connection.Open();
                    command = new SqlCommand("select Name from Type_of_Drink where Name=@name", connection);
                    command.Parameters.AddWithValue("@name", Type_Tbox.Text.ToUpper());
                    var Isvalid = command.ExecuteScalar();
                    if (Isvalid == null)
                    {
                        command = new SqlCommand("insert into Type_of_Drink values(@name)", connection);
                        command.Parameters.AddWithValue("@name", Type_Tbox.Text.ToUpper());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı...");
                        Ekle ekle = new Ekle();
                        this.Hide();
                        ekle.ShowDialog();
                       
                    }
                    else
                    {
                        MessageBox.Show("Zaten Kayıtlı...");
                    }
                    connection.Close();
                }
                else if (Food_Type_Rbutton.Checked)
                {
                    connection.Open();
                    command = new SqlCommand("select Name from Type_of_Food where Name=@name", connection);
                    command.Parameters.AddWithValue("@name", Type_Tbox.Text.ToUpper());
                    var Isvalid = command.ExecuteScalar();
                    if (Isvalid == null)
                    {
                        command = new SqlCommand("insert into Type_of_Food values(@name)", connection);
                        command.Parameters.AddWithValue("@name", Type_Tbox.Text.ToUpper());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı...");
                        Ekle ekle = new Ekle();
                        this.Hide();
                        ekle.ShowDialog();
                    
                    }
                    else
                    {
                        MessageBox.Show("Zaten Kayıtlı...");
                    }

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Boşluk Bırakma...");
                }
            }
            else
            {
                MessageBox.Show("Lütfen türü girdiğinizden ve bir kategori seçtiğinizden emin olun...");
            }

        }

        private void Drink_Type_Rbutton_CheckedChanged(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Type_Tbox.Enabled = true;
        }

        private void Food_Type_Rbutton_CheckedChanged(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Type_Tbox.Enabled = true;
        }

        private void Turk_Ekle2_Load(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Type_Tbox.Enabled = false;
        }
    }
}
