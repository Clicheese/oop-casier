using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=crud";
            string query = "INSERT INTO tbl_barang(kode_barang,nama,harga_jual,harga_beli,jml_barang,satuan)VALUES('" + this.boxkodebarang.Text + "','" + this.boxnamabarang.Text + "','" + this.boxhargajual.Text + "','" + this.boxhargabeli.Text + "','" + this.boxjumlahbarang.Text + "','" + this.boxsatuan.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Success");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=crud";
            string query = "SELECT * FROM tbl_barang";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
			string connection = "server=localhost;user id=root;password=;database=crud";
			string query = "UPDATE tbl_barang SET nama='" + this.boxnamabarang.Text + "',harga_jual='" + this.boxhargajual.Text + "',harga_beli='" + this.boxhargabeli.Text + "',jml_barang='" + this.boxjumlahbarang.Text + "',satuan='" + this.boxsatuan.Text + "' WHERE kode_barang='" + this.boxkodebarang.Text + "'";
			MySqlConnection conn = new MySqlConnection(connection);
			MySqlCommand cmd = new MySqlCommand(query, conn);
			MySqlDataReader dr;
			conn.Open();
			cmd.ExecuteNonQuery();
			MessageBox.Show("Updated Succesfully");
			conn.Close();
		}

        private void button5_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=crud";
            string query = "DELETE FROM tbl_barang WHERE kode_barang='" + this.boxkodebarang.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Deleted Succesfully");
            conn.Close();
        }
    }
   }
