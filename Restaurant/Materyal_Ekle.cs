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
    public partial class Materyal_Ekle : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public Materyal_Ekle()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Kg_Rbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (Kg_Rbutton.Checked)
            {
                Kg__Numeric.Value = 0;
                Kg__Numeric.Enabled = true;
            }
            else
            {
                Kg__Numeric.Value = 0;
                Kg__Numeric.Enabled = false;
            }
        }

        private void Piece_Rbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (Piece_Rbutton.Checked)
            {
                Piece_Numeric.Value = 0;
                Piece_Numeric.Enabled = true;
            }
            else
            {
                Piece_Numeric.Value = 0;
                Piece_Numeric.Enabled = false;
            }
        }

        private void Materyal_Ekle_Load(object sender, EventArgs e)
        {
            Piece_Numeric.Value = 0;
            Piece_Numeric.Enabled = false;
            Kg__Numeric.Value = 0;
            Kg__Numeric.Enabled = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name;
            connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
            connection.Open();
            if (Kg_Rbutton.Checked)
            {
                if (Kg__Numeric.Value > 0)
                { 
                    if (Add_Material_Tbox.Text != null && Add_Material_Tbox.Text != "")
                    {
                        name = Add_Material_Tbox.Text.ToUpper();
                        command = new SqlCommand("select Name from Materials where name=@name", connection);
                        command.Parameters.AddWithValue("@name", name);
                        var Isvalid = command.ExecuteScalar();
                        if (Isvalid!=null)
                        {
                           
                            MessageBox.Show("Zaten Kayıtlı...");
                        }
                        else
                        {
                            command = new SqlCommand("insert into Materials values(@name,@kg,@piece)", connection);
                            command.Parameters.AddWithValue("@name",name);
                            command.Parameters.AddWithValue("@kg", Kg__Numeric.Value);
                            command.Parameters.AddWithValue("@piece",0);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Eklendi..");
                            Kg__Numeric.Value = 0;
                            Piece_Numeric.Value = 0;
                            Add_Material_Tbox.Text = "";

                        }
                    }
                    else
                    {
                        MessageBox.Show("İsim girmedin...");
                    }
                }
                else
                {
                    MessageBox.Show("Kg olarak değer girin...");
                }
            }
            else if (Piece_Rbutton.Checked)
            {
                if (Piece_Numeric.Value > 0)
                {
                    if (Add_Material_Tbox.Text != null && Add_Material_Tbox.Text != "")
                    {
                        name = Add_Material_Tbox.Text.ToUpper();
                        command = new SqlCommand("select Name from Materials where name=@name", connection);
                        command.Parameters.AddWithValue("@name", name);
                        var Isvalid = command.ExecuteScalar();
                        if (Isvalid != null)
                        {

                            MessageBox.Show("Zaten Kayıtlı...");
                        }
                        else
                        {
                            command = new SqlCommand("insert into Materials values(@name,@kg,@piece)", connection);
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@kg", 0);
                            command.Parameters.AddWithValue("@piece", Convert.ToInt32(Piece_Numeric.Value));
                            command.ExecuteNonQuery();
                            Add_Material_Tbox.Text = "";
                            Kg__Numeric.Value = 0;
                            Piece_Numeric.Value = 0;
                            MessageBox.Show("Eklendi..");
                        }
                    }
                    else
                    {
                        MessageBox.Show("İsim girmedin...");
                    }

                }
                else
                {
                    MessageBox.Show("Tane olarak değer girin...");
                }
            }
            else
                MessageBox.Show("bir miktar seçip değer girin...");
            connection.Close();
        }
    }

}
