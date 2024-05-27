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
    public partial class AdminPanel : Form
    {
        XmlSerializer xs;
        List<User> users;
        public AdminPanel()
        {
            InitializeComponent();
            users = new List<User>();
            xs = new XmlSerializer(typeof(List<User>));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Close();
            UserInfo userInfo = new UserInfo();
            userInfo.Show();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("20201021.xml", FileMode.OpenOrCreate, FileAccess.Read);
            if(new FileInfo("20201021.xml").Length == 0)
            {
                MessageBox.Show("List is empty.");
            }
            else {
                users = (List<User>)xs.Deserialize(fs);


                dataGridView1.DataSource = users;
            }
            
            fs.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null || dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please make one selection");
            }
            else
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string type = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string surname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string password = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string mail = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                this.Close();
                UserInfo us = new UserInfo(id, type, name, surname, password, mail);
                us.Show();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txtbox_delete_id.Text.Length == 0)
            {
                MessageBox.Show("Please enter id ");
            }
            else
            {
                using (XmlReader xr = XmlReader.Create("20201021.xml"))
                {
                    users = (List<User>)xs.Deserialize(xr);
                }
                int i = 0;

                for (; i < users.Count; i++)
                {
                    if (users[i].Id == txtbox_delete_id.Text)
                    {
                        break;
                    }
                }
                if(i == users.Count)
                {
                    MessageBox.Show("the id you entered has not been found");
                }
                else
                {
                    users.RemoveAt(i);
                    File.Delete("20201021.xml");

                    FileStream fs = new FileStream("20201021.xml", FileMode.OpenOrCreate, FileAccess.Write);
                    xs.Serialize(fs, users);

                    fs.Close();
                    MessageBox.Show("Successfully deleted");
                }

            }
        }
    }
}
