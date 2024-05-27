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
    public partial class Form2 : Form
    {
        int cho = 1;
        public Form2()
        {
            InitializeComponent();
        }

        string user;
        public Form2(string s, int i)
        {
            InitializeComponent();
            user = s;
            cho = i;
        }
        public Form2(string s)
        {
            InitializeComponent();
            user = s;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if(user != "admin")
            {
                btn_admin.Hide();
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel admin = new AdminPanel();
            admin.Show();
        }

        private void btn_newgame_Click(object sender, EventArgs e)
        {
            if(cho == 1)
            {
                this.Close();
                Game game = new Game(user,cho);
                game.Show();
            }
            else if(cho == 2)
            {
                this.Close();
                Game4x4 gm4 = new Game4x4(user, cho);
                gm4.Show();
            }
            else
            {
                this.Close();
                Game5x5 gm5 = new Game5x5(user, cho);
                gm5.Show();
            }
        }

        private void btn_difficult_Click(object sender, EventArgs e)
        {
            this.Close();
            GameDifficulty diff = new GameDifficulty(user);
            diff.Show();
        }
    }
}
