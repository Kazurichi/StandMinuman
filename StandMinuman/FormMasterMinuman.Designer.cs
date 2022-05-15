
namespace StandMinuman
{
	partial class FormMasterMinuman
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
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.dataGridViewMinuman = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.kembaliKeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masterTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbnama = new System.Windows.Forms.TextBox();
			this.tbidminuman = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nUDStok = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonClearSearch = new System.Windows.Forms.Button();
			this.comboBoxAktif = new System.Windows.Forms.ComboBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.nUPHarga = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinuman)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDStok)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUPHarga)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(680, 415);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(109, 41);
			this.btnClear.TabIndex = 24;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(679, 368);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 41);
			this.btnDelete.TabIndex = 23;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(679, 321);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(109, 41);
			this.btnUpdate.TabIndex = 22;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsert.Location = new System.Drawing.Point(679, 274);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(109, 41);
			this.btnInsert.TabIndex = 21;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// dataGridViewMinuman
			// 
			this.dataGridViewMinuman.AllowUserToAddRows = false;
			this.dataGridViewMinuman.AllowUserToDeleteRows = false;
			this.dataGridViewMinuman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewMinuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMinuman.Location = new System.Drawing.Point(12, 33);
			this.dataGridViewMinuman.Name = "dataGridViewMinuman";
			this.dataGridViewMinuman.ReadOnly = true;
			this.dataGridViewMinuman.RowHeadersVisible = false;
			this.dataGridViewMinuman.Size = new System.Drawing.Size(776, 226);
			this.dataGridViewMinuman.TabIndex = 20;
			this.dataGridViewMinuman.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMinuman_CellMouseDoubleClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kembaliKeMenuToolStripMenuItem,
            this.masterTransaksiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 19;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// kembaliKeMenuToolStripMenuItem
			// 
			this.kembaliKeMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.kembaliKeMenuToolStripMenuItem.Name = "kembaliKeMenuToolStripMenuItem";
			this.kembaliKeMenuToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
			this.kembaliKeMenuToolStripMenuItem.Text = "Kembali ke Menu";
			this.kembaliKeMenuToolStripMenuItem.Click += new System.EventHandler(this.kembaliKeMenuToolStripMenuItem_Click);
			// 
			// masterTransaksiToolStripMenuItem
			// 
			this.masterTransaksiToolStripMenuItem.Name = "masterTransaksiToolStripMenuItem";
			this.masterTransaksiToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
			// 
			// tbnama
			// 
			this.tbnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbnama.Location = new System.Drawing.Point(126, 334);
			this.tbnama.Name = "tbnama";
			this.tbnama.Size = new System.Drawing.Size(179, 26);
			this.tbnama.TabIndex = 30;
			this.tbnama.TextChanged += new System.EventHandler(this.tbnama_TextChanged);
			// 
			// tbidminuman
			// 
			this.tbidminuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbidminuman.Location = new System.Drawing.Point(126, 301);
			this.tbidminuman.Name = "tbidminuman";
			this.tbidminuman.ReadOnly = true;
			this.tbidminuman.Size = new System.Drawing.Size(75, 26);
			this.tbidminuman.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(56, 399);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "Harga  :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(69, 369);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 20);
			this.label3.TabIndex = 27;
			this.label3.Text = "Stok :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 337);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 20);
			this.label2.TabIndex = 26;
			this.label2.Text = "Nama  :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 304);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 20);
			this.label1.TabIndex = 25;
			this.label1.Text = "ID Minuman  :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// nUDStok
			// 
			this.nUDStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nUDStok.Location = new System.Drawing.Point(126, 366);
			this.nUDStok.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nUDStok.Name = "nUDStok";
			this.nUDStok.Size = new System.Drawing.Size(180, 26);
			this.nUDStok.TabIndex = 33;
			this.nUDStok.ValueChanged += new System.EventHandler(this.nUDStok_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(127, 401);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 20);
			this.label5.TabIndex = 34;
			this.label5.Text = "Rp";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// buttonClearSearch
			// 
			this.buttonClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClearSearch.Location = new System.Drawing.Point(401, 265);
			this.buttonClearSearch.Name = "buttonClearSearch";
			this.buttonClearSearch.Size = new System.Drawing.Size(109, 28);
			this.buttonClearSearch.TabIndex = 52;
			this.buttonClearSearch.Text = "Clear Search";
			this.buttonClearSearch.UseVisualStyleBackColor = true;
			this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
			// 
			// comboBoxAktif
			// 
			this.comboBoxAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.comboBoxAktif.FormattingEnabled = true;
			this.comboBoxAktif.Items.AddRange(new object[] {
            "Semua",
            "Aktif",
            "Tidak Aktif"});
			this.comboBoxAktif.Location = new System.Drawing.Point(274, 265);
			this.comboBoxAktif.Name = "comboBoxAktif";
			this.comboBoxAktif.Size = new System.Drawing.Size(121, 28);
			this.comboBoxAktif.TabIndex = 51;
			this.comboBoxAktif.SelectedIndexChanged += new System.EventHandler(this.comboBoxAktif_SelectedIndexChanged);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(89, 266);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(179, 26);
			this.textBoxSearch.TabIndex = 50;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 269);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 20);
			this.label6.TabIndex = 49;
			this.label6.Text = "Search  :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// nUPHarga
			// 
			this.nUPHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nUPHarga.Location = new System.Drawing.Point(163, 399);
			this.nUPHarga.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.nUPHarga.Name = "nUPHarga";
			this.nUPHarga.Size = new System.Drawing.Size(142, 26);
			this.nUPHarga.TabIndex = 53;
			this.nUPHarga.ValueChanged += new System.EventHandler(this.nUPHarga_ValueChanged);
			// 
			// FormMasterMinuman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 462);
			this.Controls.Add(this.nUPHarga);
			this.Controls.Add(this.buttonClearSearch);
			this.Controls.Add(this.comboBoxAktif);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nUDStok);
			this.Controls.Add(this.tbnama);
			this.Controls.Add(this.tbidminuman);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.dataGridViewMinuman);
			this.Controls.Add(this.menuStrip1);
			this.Name = "FormMasterMinuman";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMasterMinuman";
			this.Load += new System.EventHandler(this.FormMasterMinuman_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinuman)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDStok)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUPHarga)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.DataGridView dataGridViewMinuman;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem kembaliKeMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masterTransaksiToolStripMenuItem;
		private System.Windows.Forms.TextBox tbnama;
		private System.Windows.Forms.TextBox tbidminuman;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nUDStok;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonClearSearch;
		private System.Windows.Forms.ComboBox comboBoxAktif;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nUPHarga;
	}
}