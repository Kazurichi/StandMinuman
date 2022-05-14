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
	public partial class FormMasterMinuman : Form
	{
		public FormMasterMinuman()
		{
			InitializeComponent();
		}

		private void FormMasterMinuman_Load(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("Select * from minuman", Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridViewMinuman.DataSource = null;
				dataGridViewMinuman.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Minuman!");
			}
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
