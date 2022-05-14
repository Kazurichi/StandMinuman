
namespace StandMinuman
{
	partial class FormReport
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.sellerpenjualanTertinggiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sellerpenjualanTerendahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stokMinumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kembaliKeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerpenjualanTertinggiToolStripMenuItem,
            this.sellerpenjualanTerendahToolStripMenuItem,
            this.minumanToolStripMenuItem,
            this.stokMinumanToolStripMenuItem,
            this.toppingToolStripMenuItem,
            this.kembaliKeMenuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// sellerpenjualanTertinggiToolStripMenuItem
			// 
			this.sellerpenjualanTertinggiToolStripMenuItem.Name = "sellerpenjualanTertinggiToolStripMenuItem";
			this.sellerpenjualanTertinggiToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
			this.sellerpenjualanTertinggiToolStripMenuItem.Text = "Seller (penjualan tertinggi)";
			// 
			// sellerpenjualanTerendahToolStripMenuItem
			// 
			this.sellerpenjualanTerendahToolStripMenuItem.Name = "sellerpenjualanTerendahToolStripMenuItem";
			this.sellerpenjualanTerendahToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
			this.sellerpenjualanTerendahToolStripMenuItem.Text = "Seller (penjualan terendah)";
			// 
			// minumanToolStripMenuItem
			// 
			this.minumanToolStripMenuItem.Name = "minumanToolStripMenuItem";
			this.minumanToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
			this.minumanToolStripMenuItem.Text = "Penjualan Minuman";
			// 
			// stokMinumanToolStripMenuItem
			// 
			this.stokMinumanToolStripMenuItem.Name = "stokMinumanToolStripMenuItem";
			this.stokMinumanToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.stokMinumanToolStripMenuItem.Text = "Stok Minuman";
			// 
			// toppingToolStripMenuItem
			// 
			this.toppingToolStripMenuItem.Name = "toppingToolStripMenuItem";
			this.toppingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.toppingToolStripMenuItem.Text = "Topping";
			// 
			// kembaliKeMenuToolStripMenuItem
			// 
			this.kembaliKeMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.kembaliKeMenuToolStripMenuItem.Name = "kembaliKeMenuToolStripMenuItem";
			this.kembaliKeMenuToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
			this.kembaliKeMenuToolStripMenuItem.Text = "Kembali ke Menu";
			this.kembaliKeMenuToolStripMenuItem.Click += new System.EventHandler(this.kembaliKeMenuToolStripMenuItem_Click);
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 56);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.Size = new System.Drawing.Size(1011, 539);
			this.crystalReportViewer1.TabIndex = 1;
			// 
			// FormReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1011, 589);
			this.Controls.Add(this.crystalReportViewer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormReport";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sellerpenjualanTertinggiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sellerpenjualanTerendahToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minumanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stokMinumanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toppingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kembaliKeMenuToolStripMenuItem;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}