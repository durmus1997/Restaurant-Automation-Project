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
    public partial class Tables : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dr;
        
        public Tables()
        {
            InitializeComponent();
        }

        private void M1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Siparis siparis = new Siparis();
            string number = btn.Text.Substring(5);
            siparis.label6.Text = number;
            siparis.label7.Text = "aç";
            this.Hide();
            siparis.ShowDialog();

        }

        private void Tables_Load(object sender, EventArgs e)
        {
            List<number> tableList=new List<number>();
            connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
            connection.Open();
            command = new SqlCommand("select Table_No from dbo.Sold", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Table_No"]!=DBNull.Value) { 
                tableList.Add(new number
                {
                    no = Convert.ToInt32(dr["Table_No"])
                });
                }
            }
            foreach(var x in tableList)
            {
                switchf(x.no);
            }
            connection.Close();
        }
        void switchf(int no)
        {
            switch (no)
            {
                case 1:
                    {
                        M1.BackColor = Color.Red;
                        M1.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        M2.BackColor = Color.Red;
                        M2.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        M3.Enabled = false;
                        M3.BackColor = Color.Red;
                        break;
                    }
                case 4:
                    {
                        M4.Enabled = false;
                        M4.BackColor = Color.Red;
                        break;
                    }
                case 5:
                    {
                        M5.Enabled = false;
                        M5.BackColor = Color.Red;
                        break;
                    }
                case 6:
                    {
                        M6.Enabled = false;
                        M6.BackColor = Color.Red;
                        break;
                    }
                case 7:
                    {
                        M7.Enabled = false;
                        M7.BackColor = Color.Red;
                        break;
                    }
                case 8:
                    {
                        M8.Enabled = false;
                        M8.BackColor = Color.Red;
                        break;
                    }
                case 9:
                    {
                        M9.Enabled = false;
                        M9.BackColor = Color.Red;
                        break;
                    }
                case 10:
                    {
                        M10.Enabled = false;
                        M10.BackColor = Color.Red;
                        break;
                    }
                case 11:
                    {
                        M11.Enabled = false;
                        M11.BackColor = Color.Red;
                        break;
                    }
                case 12:
                    {
                        M12.Enabled = false;
                        M12.BackColor = Color.Red;
                        break;
                    }
                case 13:
                    {
                        M13.Enabled = false;
                        M13.BackColor = Color.Red;
                        break;
                    }
                case 14:
                    {
                        M14.Enabled = false;
                        M14.BackColor = Color.Red;
                        break;
                    }
                case 15:
                    {
                        M15.Enabled = false;
                        M15.BackColor = Color.Red;
                        break;
                    }
                case 16:
                    {
                        M16.Enabled = false;
                        M16.BackColor = Color.Red;
                        break;
                    }
                case 17:
                    {
                        M17.Enabled = false;
                        M17.BackColor = Color.Red;
                        break;
                    }
                case 18:
                    {
                        M18.Enabled = false;
                        M18.BackColor = Color.Red;
                        break;
                    }
                case 19:
                    {
                        M19.Enabled = false;
                        M19.BackColor = Color.Red;
                        break;
                    }
                case 20:
                    {
                        M20.Enabled = false;
                        M20.BackColor = Color.Red;
                        break;
                    }
            }
        }
    }
}
