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

namespace _152120201021_Abdulkerim_Pekince_lab5
{
    public partial class UserInfo_with_SQL : Form
    {
        string sql;
        string id, type, name, surname, password, mail;
        public UserInfo_with_SQL()
        {
            InitializeComponent();
        }

        private void UserInfo_with_SQL_Load(object sender, EventArgs e)
        {
            if(id != null)
            {
                txtbox_id.Text = id;
                txtbox_usertype.Text = type;
                txtbox_username.Text = name;
                txtbox_surname.Text = surname;
                txtbox_password.Text = password;
                txtbox_mail.Text = mail;
                txtbox_id.ReadOnly = true;
            }
        }

        public UserInfo_with_SQL(string s)
        {
            InitializeComponent();
            sql = s;
        }
        public UserInfo_with_SQL(string s, string a1, string a2, string a3, string a4, string a5, string a6)
        {
            InitializeComponent();
            sql = s;
            id = a1;
            type = a2;
            name = a3;
            surname = a4;
            password = a5;
            mail = a6;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtbox_id.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "Id kısmını doldurunuz.";
            }
            else if (txtbox_usertype.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "User type kısmını doldurunuz.";
            }
            else if (txtbox_username.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "User Name kısmını doldurunuz.";
            }
            else if (txtbox_password.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "Password kısmını doldurunuz.";
            }
            else if (txtbox_surname.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "User surname kısmını doldurunuz.";
            }
            else if (txtbox_mail.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "Mail kısmını doldurunuz.";
            }
            else if(id != null)
            {
                SqlConnection conn = new SqlConnection(sql);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                string q = "UPDATE UsersInfo set UserType = '"+txtbox_usertype.Text+"',UserName = '"+txtbox_username.Text+"'," +
                    "Password = '"+txtbox_password.Text+"',UserSurname = '"+txtbox_surname.Text+"',Mail = '"+txtbox_mail.Text+"' where ID = " + id;
                comm.CommandText = q;
                comm.ExecuteNonQuery();

                conn.Close();
                lbl_uyari.ForeColor = Color.Green;
                lbl_uyari.Text = "Başarıyla güncellendi";
            }

            else
            {
                SqlConnection conn = new SqlConnection(sql);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                string q = "insert into UsersInfo (ID,UserType,UserName,Password,UserSurname,Mail) VALUES ('" + txtbox_id.Text + "','" + txtbox_usertype.Text + "','" +
                    txtbox_username.Text + "','" + txtbox_password.Text + "','" + txtbox_surname.Text + "','" + txtbox_mail.Text + "')";
                comm.CommandText = q;
                comm.ExecuteNonQuery();
                conn.Close();
                lbl_uyari.ForeColor = Color.Green;
                lbl_uyari.Text = "Başarıyla kaydedildi";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtbox_id.MaxLength = 8;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
