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
using System.Xml;
using System.Xml.Serialization;

namespace _152120201021_Abdulkerim_Pekince_lab5
{
    public partial class UserInfo : Form
    {
        XmlSerializer xs;
        List<User> ls;
        string id_;
        string type_;
        string name_;
        string surname_;
        string password_;
        string mail_;
        int main_form;
        public UserInfo()
        {
            InitializeComponent();
            ls = new List<User>();
            xs = new XmlSerializer(typeof(List<User>));
        }

        public UserInfo(string id,string type, string name, string surname, string password, string mail)
        {
            InitializeComponent();
            ls = new List<User>();
            xs = new XmlSerializer(typeof(List<User>));
            id_ = id;
            type_ = type;
            name_ = name;
            surname_ = surname;
            password_ = password;
            mail_ = mail;
        }

        public UserInfo(int t)
        {
            InitializeComponent();
            ls = new List<User>();
            xs = new XmlSerializer(typeof(List<User>));
            main_form = t;
        }

        private void txtbox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtbox_id.MaxLength = 8;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int k = 0;
            //if(txtbox_id.Text.Length > 0 && name_ == null)
            //{
            //    if (new FileInfo("20201021.xml").Length > 0)
            //    {
            //        using (XmlReader xr = XmlReader.Create("20201021.xml"))
            //        {
            //            ls = (List<User>)xs.Deserialize(xr);
            //        }

            //        for (; k < ls.Count; k++)
            //        {
            //            if (ls[k].Id == txtbox_id.Text)
            //            {
            //                k = -1;
            //                break;
            //            }
            //        }
            //    }
                
            //}
            if(txtbox_id.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "Id kısmını doldurunuz.";
            }
            else if(txtbox_usertype.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "User type kısmını doldurunuz.";
            }
            else if(txtbox_username.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "User Name kısmını doldurunuz.";
            }
            else if(txtbox_password.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "Password kısmını doldurunuz.";
            }
            else if(txtbox_surname.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "User surname kısmını doldurunuz.";
            }
            else if(txtbox_mail.Text.Length == 0)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "Mail kısmını doldurunuz.";
            }
            else if(k == -1)
            {
                lbl_uyari.ForeColor = Color.DarkRed;
                lbl_uyari.Text = "Girmiş olduğunuz kullanıcı id'si sistemde kayıtlı.";
            }
            else
            {
                FileStream f = new FileStream("20201021.xml", FileMode.OpenOrCreate, FileAccess.Read);
                f.Close();
                if (name_ != null)
                {
                    using (XmlReader xr = XmlReader.Create("20201021.xml"))
                    {
                        ls = (List<User>)xs.Deserialize(xr);
                    }
                    File.Delete("20201021.xml");
                    int index = 0;
                    for (index = 0; index < ls.Count; index++)
                    {
                        if (ls[index].Id == id_)
                        {
                            break;
                        }
                    }
                    if(index < ls.Count)
                    {
                        ls.RemoveAt(index);
                    }
                    else
                    {
                        lbl_uyari.ForeColor= Color.DarkRed;
                        lbl_uyari.Text = "id is not found";
                    }
                }
                //else if (new FileInfo("20201021.xml").Length != 0)
                //{
                //    FileStream sf = new FileStream("20201021.xml", FileMode.OpenOrCreate, FileAccess.Read);
                //    ls = (List<User>)xs.Deserialize(sf);
                    
                //    sf.Close();
                //    File.Delete("20201021.xml");
                //}
                FileStream fs = new FileStream("20201021.xml", FileMode.OpenOrCreate, FileAccess.Write);
                User one = new User();
                one.Id = txtbox_id.Text;
                one.UserName = txtbox_username.Text;
                one.UserSurname = txtbox_surname.Text;
                one.Password = txtbox_password.Text;
                one.UserType = txtbox_usertype.Text;
                one.UserMail = txtbox_mail.Text;


                

                ls.Add(one);
                xs.Serialize(fs, ls);

                fs.Close();

                lbl_uyari.ForeColor = Color.Green;
                lbl_uyari.Text = "Başarıyla kaydedildi";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(main_form == 3)
            {
                this.Close();
            }
            else
            {
                this.Close();
                AdminPanel admin = new AdminPanel();
                admin.Show();
            }

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            if(name_ != null)
            {
                txtbox_id.Text = id_;
                txtbox_usertype.Text = type_;
                txtbox_username.Text = name_;
                txtbox_surname.Text = surname_;
                txtbox_password.Text = password_;
                txtbox_mail.Text = mail_;
            }
        }
    }
}
