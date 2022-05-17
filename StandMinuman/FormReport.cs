using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandMinuman
{
	public partial class FormReport : Form
	{
		int report = -1;
		public FormReport()
		{
			InitializeComponent();
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        public void reportTopping()
        {
            if (dateTimePickerAwal.Value < dateTimePickerAkhir.Value)
            {
                CrystalReportBanyakTopping rpt = new CrystalReportBanyakTopping();
                rpt.SetParameterValue("TanggalAwal", dateTimePickerAwal.Value);
                rpt.SetParameterValue("TanggalAkhir", dateTimePickerAkhir.Value);
                crystalReportViewer1.ReportSource = rpt;
            }
            else
            {
                MessageBox.Show("Tanggal akhir harus lebih besar dari tanggal awal!");
            }
        }

        private void toppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report = 5;
            tampilToolStripMenuItem.Enabled = true;
            resetBold();
            toppingToolStripMenuItem.Font = new Font(toppingToolStripMenuItem.Font, FontStyle.Bold);
        }

        public void resetBold()
        {
            sellerpenjualanTertinggiToolStripMenuItem.Font = new Font(sellerpenjualanTertinggiToolStripMenuItem.Font, FontStyle.Regular);
            sellerpenjualanTerendahToolStripMenuItem.Font = new Font(sellerpenjualanTerendahToolStripMenuItem.Font, FontStyle.Regular);
            minumanToolStripMenuItem.Font = new Font(minumanToolStripMenuItem.Font, FontStyle.Regular);
            stokMinumanToolStripMenuItem.Font = new Font(stokMinumanToolStripMenuItem.Font, FontStyle.Regular);
            toppingToolStripMenuItem.Font = new Font(toppingToolStripMenuItem.Font, FontStyle.Regular);
            
        }

        private void tampilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (report != -1)
            {
                if (report == 1)
                {
                    //report seller tertinggi
                }
                else if (report == 2)
                {
                    //report seller terendah
                }
                else if (report == 3)
                {
                    //report minuman
                }
                else if (report == 4)
                {
                    //report stok minuman
                }
                else
                {
                    reportTopping();
                }
            }
            else
            {
                MessageBox.Show("Test");
            }
        }
    }
}
