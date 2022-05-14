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

namespace StandMinuman
{
	public partial class FormMasterSeller : Form
	{
		DataTable dt;
		public FormMasterSeller()
		{
			InitializeComponent();
			
		}

		private void FormMasterSeller_Load(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("Select id_users as 'ID user',username as 'Username',password as 'Password',nama as 'Nama User',status as 'Status' from users where privilege=1", Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				dt = new DataTable();
				da.Fill(dt);
				dataGridViewUser.DataSource = null;
				dataGridViewUser.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Seller!");
			}
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
