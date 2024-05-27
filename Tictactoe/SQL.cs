using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _152120201021_Abdulkerim_Pekince_lab5
{
    public partial class SQL : Form
    {
        string id;
        public SQL()
        {
            InitializeComponent();
        }

        private void SQL_Load(object sender, EventArgs e)
        {
            btn_add.Hide();
            btn_delete.Hide();
            btn_list.Hide();
            btn_update.Hide();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();       
            try {
                conn.ConnectionString = txtbx_constr.Text;
                conn.Open();
                MessageBox.Show("Successfully Connected");
                btn_add.Show();
                btn_delete.Show();
                btn_update.Show();
                btn_list.Show();
                conn.Close();
            }
            catch(Exception) { 
                MessageBox.Show("Connection Failed!");
                btn_add.Hide();
                btn_delete.Hide();
                btn_list.Hide();
                btn_update.Hide();

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = txtbx_constr.Text;
                UserInfo_with_SQL u = new UserInfo_with_SQL(txtbx_constr.Text);
                u.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Connection String is wrong!");
                btn_add.Hide();
                btn_delete.Hide();
                btn_list.Hide();
                btn_update.Hide();

            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = txtbx_constr.Text;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                string q = "select * from UsersInfo";
                comm.CommandText = q;
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(comm);
                data.Fill(dt);
                dgv_users.DataSource = dt;

                conn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Connection String is wrong!");
                btn_add.Hide();
                btn_delete.Hide();
                btn_list.Hide();
                btn_update.Hide();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = txtbx_constr.Text;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                if (dgv_users.CurrentRow == null || dgv_users.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Please make one selection");
                }
                else
                {
                    id = dgv_users.CurrentRow.Cells[0].Value.ToString();
                    string q = "Delete from UsersInfo where ID = " + id;
                    comm.CommandText = q;
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Deleted");

                }
                
                conn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Connection String is wrong!");
                btn_add.Hide();
                btn_delete.Hide();
                btn_list.Hide();
                btn_update.Hide();

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = txtbx_constr.Text;
                if (dgv_users.CurrentRow == null || dgv_users.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Please make one selection");
                }
                else
                {
                    id = dgv_users.CurrentRow.Cells[0].Value.ToString();
                    string type = dgv_users.CurrentRow.Cells[1].Value.ToString();
                    string name = dgv_users.CurrentRow.Cells[2].Value.ToString();
                    string surname = dgv_users.CurrentRow.Cells[3].Value.ToString();
                    string password = dgv_users.CurrentRow.Cells[4].Value.ToString();
                    string mail = dgv_users.CurrentRow.Cells[5].Value.ToString();

                    UserInfo_with_SQL u = new UserInfo_with_SQL(txtbx_constr.Text,id,type,name,surname,password,mail);
                    u.Show();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Connection String is wrong!");
                btn_add.Hide();
                btn_delete.Hide();
                btn_list.Hide();
                btn_update.Hide();

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
