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

namespace buttonDataGrid
{
    public partial class Form2 : Form
    {
        int id;
        string name, made_from, type, desc;
        string conS = @"Data Source=AWA-PC\SQLEXPRESS;Initial Catalog=db_lks;Integrated Security=True";
        SqlConnection conn = new SqlConnection("Data Source=AWA-PC\\SQLEXPRESS;Initial Catalog=db_lks;Integrated Security=True");


        private void rGame_CheckedChanged(object sender, EventArgs e)
        {
            type = "Game";
        }

        private void rAnime_CheckedChanged(object sender, EventArgs e)
        {
            type = "Anime";
        }

        private void rComic_CheckedChanged(object sender, EventArgs e)
        {
            type = "Comic";
        }

        public Form2(int id,string name,string made_from,string type,string desc)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.made_from = made_from;
            this.type = type;
            this.desc = desc;
            showData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void updateData()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [husbus] SET name = @name,description = @desc,made_from = @made_from,type = @type WHERE id = @id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@desc", SqlDbType.NVarChar).Value = txtDesc.Text;
            cmd.Parameters.Add("@made_from", SqlDbType.NVarChar).Value = txtMadeFrom.Text;
            cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Husbu berhasil diupdate!");
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void showData()
        {
            txtDesc.Text = desc;
            txtName.Text = name;
            txtMadeFrom.Text = made_from;

            if (type == "Anime")
            {
                rAnime.Checked = true;
                rComic.Checked = false;
                rGame.Checked = false;
            }
            else if (type == "Game")
            {
                rAnime.Checked = false;
                rComic.Checked = false;
                rGame.Checked = true;
            }
            else
            {
                rAnime.Checked = false;
                rComic.Checked = true;
                rGame.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
