using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _152120201021_Abdulkerim_Pekince_lab5
{
    public partial class Form1 : Form
    {
        XmlSerializer xs;
        List<User> users;
        List<User> remember;
        public Form1()
        {
            InitializeComponent();
            users = new List<User>();
            remember = new List<User>();
            xs = new XmlSerializer(typeof(List<User>));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            //if (txtbox_username.Text.Length > 0)
            //{
            //    FileStream fs = new FileStream("20201021.xml", FileMode.OpenOrCreate, FileAccess.Read);
            //    if(new FileInfo("20201021.xml").Length > 0)
            //    {
            //        users = (List<User>)xs.Deserialize(fs);


            //        for (; i < users.Count; i++)
            //        {
            //            if (users[i].UserName == txtbox_username.Text)
            //            {
            //                if (txtbox_password.Text == users[i].Password)
            //                {
            //                    i = -1;
            //                    break;
            //                }
            //            }
            //        }
            //    }
               
            //    fs.Close();
            //}
            if(txtbox_username.Text.Length == 0)
            {
                lbl_uyarı.Text = "You should enter your username.";
            }
            else if(txtbox_password.Text.Length == 0)
            {
                lbl_uyarı.Text = "You should enter the password.";
            }
            else if(txtbox_username.Text == "admin")
            {
                if(txtbox_password.Text != "admin")
                {
                    lbl_uyarı.ForeColor = Color.DarkRed;
                    lbl_uyarı.Text = "Invalid username or password!";
                }
                else
                {
                    lbl_uyarı.ForeColor = Color.Green;
                    lbl_uyarı.Text = "Successfully login";
                    Form2 form2 = new Form2(txtbox_username.Text);
                    form2.Show();
                }
            }
            else if (txtbox_username.Text == "user")
            {
                if (txtbox_password.Text != "user")
                {
                    lbl_uyarı.ForeColor = Color.DarkRed;
                    lbl_uyarı.Text = "Invalid username or password!";
                }
                else
                {
                    lbl_uyarı.ForeColor = Color.Green;
                    lbl_uyarı.Text = "Successfully login";
                    Form2 form2 = new Form2(txtbox_username.Text);
                    form2.Show();
                }
            }
            else if(txtbox_username.Text == "1"&& txtbox_username.Text == "1")
            {
                lbl_uyarı.ForeColor = Color.Green;
                lbl_uyarı.Text = "Successfully login";
                Form2 form2 = new Form2(txtbox_username.Text);
                form2.Show();
            }
            else if(i == -1)
            {
                lbl_uyarı.ForeColor = Color.Green;
                lbl_uyarı.Text = "Successfully login";
                Form2 form2 = new Form2(txtbox_username.Text);
                form2.Show();
            }
            else
            {
                lbl_uyarı.ForeColor = Color.DarkRed;
                lbl_uyarı.Text = "Invalid username or password!";
            }
        }

        private void chbox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(chbox_showpass.Checked)
            {
                txtbox_password.UseSystemPasswordChar = false;
            }
            else
            {
                txtbox_password.UseSystemPasswordChar= true;
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo(3);
            ui.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream f = new FileStream("rememberme.xml", FileMode.OpenOrCreate, FileAccess.Read);
            f.Close();
            if (new FileInfo("rememberme.xml").Length != 0)
            {
                FileStream s = new FileStream("rememberme.xml", FileMode.OpenOrCreate, FileAccess.Read);
                remember = (List<User>)xs.Deserialize(s);
                txtbox_username.Text = remember[0].UserName;
                txtbox_password.Text = remember[0].Password;
                s.Close();
            }
            else
            {
                txtbox_username.Text = "";
                txtbox_password.Text = "";
            }
            File.Delete("rememberme.xml");
            FileStream sf = new FileStream("rememberme.xml", FileMode.OpenOrCreate, FileAccess.Read);
            sf.Close();
        }

        private void chbox_remember_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_remember.Checked)
            {
                if (txtbox_password.Text.Length > 0 && txtbox_username.Text.Length > 0)
                {
                    FileStream fs = new FileStream("rememberme.xml", FileMode.OpenOrCreate, FileAccess.Write);
                    User user = new User();
                    user.UserName = txtbox_username.Text;
                    user.Password = txtbox_password.Text;
                    user.UserSurname = "user";
                    user.Id = "user";
                    user.UserMail = "user";
                    user.UserType = "user";
                    remember.Add(user);
                    xs.Serialize(fs, remember);
                    fs.Close();
                    lbl_uyarı.Text = "";
                }
                else
                {
                    lbl_uyarı.ForeColor = Color.DarkRed;
                    lbl_uyarı.Text = "Enter your username and password to be remembered\nthen click again.";
                }
            }
            else
            {
                File.Delete("rememberme.xml");
                FileStream fs = new FileStream("rememberme.xml", FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
            }
        }

        private void btn_SQL_Click(object sender, EventArgs e)
        {
            SQL s = new SQL();
            s.Show();
        }
    }
}
