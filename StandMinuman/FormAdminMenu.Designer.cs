﻿
namespace StandMinuman
{
	partial class FormAdminMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMenu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.masterSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masterMinumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masterToppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterSellerToolStripMenuItem,
            this.masterMinumanToolStripMenuItem,
            this.masterToppingToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.laporanToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 29);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// masterSellerToolStripMenuItem
			// 
			this.masterSellerToolStripMenuItem.Name = "masterSellerToolStripMenuItem";
			this.masterSellerToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
			this.masterSellerToolStripMenuItem.Text = "Master Seller";
			this.masterSellerToolStripMenuItem.Click += new System.EventHandler(this.masterSellerToolStripMenuItem_Click);
			// 
			// masterMinumanToolStripMenuItem
			// 
			this.masterMinumanToolStripMenuItem.Name = "masterMinumanToolStripMenuItem";
			this.masterMinumanToolStripMenuItem.Size = new System.Drawing.Size(141, 25);
			this.masterMinumanToolStripMenuItem.Text = "Master Minuman";
			this.masterMinumanToolStripMenuItem.Click += new System.EventHandler(this.masterMinumanToolStripMenuItem_Click);
			// 
			// masterToppingToolStripMenuItem
			// 
			this.masterToppingToolStripMenuItem.Name = "masterToppingToolStripMenuItem";
			this.masterToppingToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
			this.masterToppingToolStripMenuItem.Text = "Master Topping";
			this.masterToppingToolStripMenuItem.Click += new System.EventHandler(this.masterToppingToolStripMenuItem_Click);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
			this.logoutToolStripMenuItem.Text = "Logout";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
			// 
			// laporanToolStripMenuItem
			// 
			this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
			this.laporanToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
			this.laporanToolStripMenuItem.Text = "Laporan";
			this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(261, 309);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(274, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Stand <Name Placeholder>";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(293, 63);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 220);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// FormAdminMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 344);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormAdminMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAdminMenu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem masterSellerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masterMinumanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masterToppingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}