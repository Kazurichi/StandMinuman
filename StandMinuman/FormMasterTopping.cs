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
	public partial class FormMasterTopping : Form
	{
		public FormMasterTopping()
		{
			InitializeComponent();
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormMasterTopping_Load(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("Select * from topping", Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridViewTopping.DataSource = null;
				dataGridViewTopping.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Minuman!");
			}
		}
	}
}
