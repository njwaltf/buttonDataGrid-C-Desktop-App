using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonDataGrid
{
    public partial class Form1 : Form
    {
        string conS = @"Data Source=AWA-PC\SQLEXPRESS;Initial Catalog=db_lks;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            ShowData();
           
        }

        private void ShowData()
        {
            SqlConnection connection = new SqlConnection(conS);
            connection.Open();
            try 
            {
                string query = "SELECT id,name,made_from,type,description,image FROM [husbus]";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }





        /*private void displayData()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where id = @id";
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = 5;
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }*/

        /*private void getUser()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT username,email from users",conn);
            //scmd.Parameters.Add("@username",SqlDbType.NVarChar).Value = "njwaltf";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label1.Text = reader.GetString(0);
                label2.Text = reader.GetString(1);
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("mau apus kah?", "peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    //string name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    //MessageBox.Show("ini id dan nama " + id + " " + name);

                    SqlConnection connection = new SqlConnection(conS);
                    connection.Open();
                    try
                    {
                        string query = "DELETE FROM [husbus] WHERE id = '"+id+"'";
                        SqlCommand command = connection.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        MessageBox.Show("husbu dihapus!");
                        ShowData();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { connection.Close(); }
                }
                
            }

            //update
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                string name, made_from, type, desc;
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                made_from = dataGridView1.Rows[e.RowIndex].Cells["made_from"].Value.ToString();
                type = dataGridView1.Rows[e.RowIndex].Cells["type"].Value.ToString();
                desc = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();

                Form2 form2 = new Form2(id,name,made_from,type,desc);
                form2.Show();
                this.Hide();
            }
        }
    }
}
