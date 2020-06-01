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
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("server=DESKTOP-J2CCKR3 ;Initial Catalog=Restaurant;Integrated Security=true");
        SqlCommand command;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Urun_Guncelle_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.StartPosition = FormStartPosition.CenterScreen;
            guncelle.Show();
            this.Hide();

        }

        private void Urun_Ekle_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.StartPosition = FormStartPosition.CenterScreen;
            ekle.Show();
            this.Hide();
        }

        private void Urun_Cikar_Click(object sender, EventArgs e)
        {
            Sil sil = new Sil();
            sil.StartPosition = FormStartPosition.CenterScreen;
            sil.Show();
            this.Hide();
        }

        private void Gelir_Hesabi_Click(object sender, EventArgs e)
        {
            kar_zarar kz = new kar_zarar();
            kz.StartPosition = FormStartPosition.CenterScreen;
            kz.Show();
            this.Hide();
        }

        private void Cok_Satan_Click(object sender, EventArgs e)
        {
            string message = "**En Çok Satan Yiyecek: \n";
            string get_food = @"select f.Name from food  f where f.Id in(select t1.Id_Food from
                                (select count(s1.Id_Food) num_of_id, Id_Food  from sold s1 where s1.Id_Food is not null group by Id_Food) t1
                                join
                                (select max(t2.num_of_id)  max_num_of_id from
                                (select count(s2.Id_Food) num_of_id, Id_Food  from sold s2 where s2.Id_Food is not null group by Id_Food) t2) t3
                                on t3.max_num_of_id = t1.num_of_id)";
            string get_drink = @"select d.Name from Drink d where d.Id in
                                (select t1.Id_Drink from
                                (select count(s1.Id_Drink) num_of_id,Id_Drink  from sold s1 where s1.Id_Food is not null group by Id_Drink) t1
                                join
                                (select max(t2.num_of_id)  max_num_of_id from 
                                (select count(s2.Id_Drink) num_of_id,Id_Drink  from sold s2 where s2.Id_Drink is not null group by Id_Drink) t2) t3
                                on t3.max_num_of_id=t1.num_of_id)";
            connection.Open();
            command = new SqlCommand(get_food, connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                message += dr["Name"].ToString() + "\n";
            }
            dr.Close();
            message += "\n **En Çok Satan İçeçek: \n";
            command = new SqlCommand(get_drink, connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                message += dr["Name"].ToString() + "\n";
            }
            dr.Close();
            connection.Close();

            MessageBox.Show(message);
        }

        private void Satis_Gecmisi_Click(object sender, EventArgs e)
        {
            Satis_Gecmisi gecmis = new Satis_Gecmisi();
            gecmis.StartPosition = FormStartPosition.CenterScreen;
            gecmis.Show();
            this.Hide();
        }

        private void Tür_Ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tur_Ekle tur_ekle = new Tur_Ekle();
            tur_ekle.StartPosition = FormStartPosition.CenterScreen;
            tur_ekle.Show();

        }

        private void Siparis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Siparis sipariş = new Siparis();
            sipariş.StartPosition = FormStartPosition.CenterScreen;
            sipariş.Show();
        }

        private void Hesap_Kes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hesap_Kes hesap_kes = new Hesap_Kes();
            hesap_kes.StartPosition = FormStartPosition.CenterScreen;
            hesap_kes.Show();
        }

        private void Tarif_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarif tarif = new Tarif();
            tarif.StartPosition = FormStartPosition.CenterScreen;
            tarif.Show();
        }

        private void Giderler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gider gider = new Gider();
            gider.StartPosition = FormStartPosition.CenterScreen;
            gider.Show();
        }

        private void Materyal_Ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materyal_Ekle materyal_ekle = new Materyal_Ekle();
            materyal_ekle.StartPosition = FormStartPosition.CenterScreen;
            materyal_ekle.Show();
        }
    }
}
