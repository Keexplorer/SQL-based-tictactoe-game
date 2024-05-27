using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120201021_Abdulkerim_Pekince_lab5
{
    public partial class GameDifficulty : Form
    {
        string user;
        public GameDifficulty()
        {
            InitializeComponent();
        }
        public GameDifficulty(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(user,1);
            form2.Show();
        }

        private void btn_medium_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(user, 2);
            form2.Show();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(user, 3);
            form2.Show();
        }
    }
}
