﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StandMinuman
{
    public partial class FormLogin : Form
    {
        public static DataRow user;
        public FormLogin()
        {
            InitializeComponent();
            Koneksi.openConn();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text != "" && textBoxPass.Text != "")
            {
                string queryTest = "SELECT count(*) FROM users WHERE username = '" + textBoxUser.Text + "'  AND password = '" + textBoxPass.Text + "' AND status = 1";
                string query = "SELECT * FROM users WHERE username = '" + textBoxUser.Text + "'  AND password = '" + textBoxPass.Text + "' AND status = 1";
                //try
                //{
                    MySqlCommand cmd = new MySqlCommand(queryTest, Koneksi.getConn());

                    int test = Convert.ToInt32(cmd.ExecuteScalar());
                    if (test > 0)
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, Koneksi.getConn());
                        DataTable temp = new DataTable();
                        adapter.Fill(temp);
                        user = temp.Rows[0];
                        //0 //id user
                        //1 //username
                        //2 //password
                        //3 //nama
                        //4 //privilege | 2 = admin, 1 = seller
                        //5 //status

                        int privilege = Convert.ToInt32(user.ItemArray[4].ToString());
                        if(privilege == 1)
                        {
                            FormTransaksi frm = new FormTransaksi();
                            this.Hide();
                            frm.ShowDialog();
                            this.Show();
                            Clear();
                        }
                        else
                        {
                            FormAdminMenu frm = new FormAdminMenu();
                            this.Hide();
                            frm.ShowDialog();
                            this.Show();
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal Login! Akun tidak ditemukan!");
                    }
                //}
                //catch (Exception a)
                //{
                //    MessageBox.Show(a.Message);
                //    MessageBox.Show("Gagal Login! Akun tidak ditemukan!");
                //}
            }
            else
            {
                MessageBox.Show("Isikan Username/Password");
            }
        }

        public void Clear()
        {
            textBoxPass.Text = "";
            textBoxUser.Text = "";
            user = null;
        }

		private void FormLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
