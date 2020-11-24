using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace ajandeklista
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("server = localhost; database = ajandek; uid = root; pwd = ;");
            conn.Open();

            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }
            };
            AdatBetoltes();
        }
        void AdatBetoltes()
        {
            ajandekListBox.Items.Clear();
            string sql = @"
            SELECT `id`, `nev`, `uzlet`
            FROM ajandek
            ORDER BY `nev`
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (Exception)
                    {
                        uzlet = "";
                    }
                    var ajandek = new Ajandek(id, nev, uzlet);
                    ajandekListBox.Items.Add(ajandek.ToString());
                }
            }
        }
        void AdatBeszuras(string nev_input,string bolt_input)
        {
            if (bolt_input=="")
            {
                bolt_input = null;
            }
            string sql = @"
            INSERT INTO ajandek(nev,uzlet)
            VALUES (@nev,@uzlet)
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@nev", nev_input);
            comm.Parameters.AddWithValue("@uzlet", bolt_input);
            comm.ExecuteNonQuery();
        }

        private void button_ajandekHozzaadas_Click(object sender, EventArgs e)
        {
            if (textBox_nev.Text!="")
            {
                AdatBeszuras(textBox_nev.Text,textBox_bolt.Text);
            }
            AdatBetoltes();
        }
    }
}
