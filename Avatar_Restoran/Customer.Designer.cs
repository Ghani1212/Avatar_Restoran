namespace Avatar_Restoran
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.NAMA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtIdPelanggan = new System.Windows.Forms.TextBox();
            this.memesanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet3 = new Avatar_Restoran.restoranDataSet3();
            this.txtKodeMenu = new System.Windows.Forms.TextBox();
            this.txtJumlahPemesanan = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtKodePemesanan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.kodepemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodemenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahpesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglpemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memesanTableAdapter = new Avatar_Restoran.restoranDataSet3TableAdapters.memesanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NAMA
            // 
            this.NAMA.AutoSize = true;
            this.NAMA.BackColor = System.Drawing.Color.BurlyWood;
            this.NAMA.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAMA.ForeColor = System.Drawing.Color.OldLace;
            this.NAMA.Location = new System.Drawing.Point(224, 16);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(378, 26);
            this.NAMA.TabIndex = 0;
            this.NAMA.Text = "SILAHKAN PESAN DISINI ヽ(*⌒▽⌒*)ﾉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Pemesanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(471, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(24, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(471, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Pelanggan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(24, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(135, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tanggal Pemesanan";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dateTimePicker.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(322, 55);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(308, 35);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtIdPelanggan
            // 
            this.txtIdPelanggan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memesanBindingSource, "id_pelanggan", true));
            this.txtIdPelanggan.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPelanggan.Location = new System.Drawing.Point(618, 258);
            this.txtIdPelanggan.Name = "txtIdPelanggan";
            this.txtIdPelanggan.Size = new System.Drawing.Size(170, 38);
            this.txtIdPelanggan.TabIndex = 9;
            // 
            // memesanBindingSource
            // 
            this.memesanBindingSource.DataMember = "memesan";
            this.memesanBindingSource.DataSource = this.restoranDataSet3;
            // 
            // restoranDataSet3
            // 
            this.restoranDataSet3.DataSetName = "restoranDataSet3";
            this.restoranDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtKodeMenu
            // 
            this.txtKodeMenu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memesanBindingSource, "kode_menu", true));
            this.txtKodeMenu.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeMenu.Location = new System.Drawing.Point(604, 302);
            this.txtKodeMenu.Name = "txtKodeMenu";
            this.txtKodeMenu.Size = new System.Drawing.Size(185, 38);
            this.txtKodeMenu.TabIndex = 17;
            // 
            // txtJumlahPemesanan
            // 
            this.txtJumlahPemesanan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memesanBindingSource, "jumlah_pesanan", true));
            this.txtJumlahPemesanan.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahPemesanan.Location = new System.Drawing.Point(218, 352);
            this.txtJumlahPemesanan.Name = "txtJumlahPemesanan";
            this.txtJumlahPemesanan.Size = new System.Drawing.Size(185, 38);
            this.txtJumlahPemesanan.TabIndex = 18;
            // 
            // txtHarga
            // 
            this.txtHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memesanBindingSource, "harga", true));
            this.txtHarga.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(104, 255);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(185, 38);
            this.txtHarga.TabIndex = 19;
            // 
            // txtKodePemesanan
            // 
            this.txtKodePemesanan.BackColor = System.Drawing.Color.Snow;
            this.txtKodePemesanan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memesanBindingSource, "kode_pemesanan", true));
            this.txtKodePemesanan.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodePemesanan.Location = new System.Drawing.Point(205, 306);
            this.txtKodePemesanan.Name = "txtKodePemesanan";
            this.txtKodePemesanan.Size = new System.Drawing.Size(127, 38);
            this.txtKodePemesanan.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 586);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(446, -148);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(462, 388);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(369, -38);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(658, 500);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 22;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 348);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 23;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(735, 382);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 24;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodepemesananDataGridViewTextBoxColumn,
            this.kodemenuDataGridViewTextBoxColumn,
            this.jumlahpesananDataGridViewTextBoxColumn,
            this.idpelangganDataGridViewTextBoxColumn,
            this.tglpemesananDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.memesanBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(85, 102);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(596, 138);
            this.dataGridView.TabIndex = 25;
            // 
            // kodepemesananDataGridViewTextBoxColumn
            // 
            this.kodepemesananDataGridViewTextBoxColumn.DataPropertyName = "kode_pemesanan";
            this.kodepemesananDataGridViewTextBoxColumn.HeaderText = "kode_pemesanan";
            this.kodepemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodepemesananDataGridViewTextBoxColumn.Name = "kodepemesananDataGridViewTextBoxColumn";
            this.kodepemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodemenuDataGridViewTextBoxColumn
            // 
            this.kodemenuDataGridViewTextBoxColumn.DataPropertyName = "kode_menu";
            this.kodemenuDataGridViewTextBoxColumn.HeaderText = "kode_menu";
            this.kodemenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodemenuDataGridViewTextBoxColumn.Name = "kodemenuDataGridViewTextBoxColumn";
            this.kodemenuDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahpesananDataGridViewTextBoxColumn
            // 
            this.jumlahpesananDataGridViewTextBoxColumn.DataPropertyName = "jumlah_pesanan";
            this.jumlahpesananDataGridViewTextBoxColumn.HeaderText = "jumlah_pesanan";
            this.jumlahpesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahpesananDataGridViewTextBoxColumn.Name = "jumlahpesananDataGridViewTextBoxColumn";
            this.jumlahpesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpelangganDataGridViewTextBoxColumn
            // 
            this.idpelangganDataGridViewTextBoxColumn.DataPropertyName = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.HeaderText = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpelangganDataGridViewTextBoxColumn.Name = "idpelangganDataGridViewTextBoxColumn";
            this.idpelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // tglpemesananDataGridViewTextBoxColumn
            // 
            this.tglpemesananDataGridViewTextBoxColumn.DataPropertyName = "tgl_pemesanan";
            this.tglpemesananDataGridViewTextBoxColumn.HeaderText = "tgl_pemesanan";
            this.tglpemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglpemesananDataGridViewTextBoxColumn.Name = "tglpemesananDataGridViewTextBoxColumn";
            this.tglpemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // memesanTableAdapter
            // 
            this.memesanTableAdapter.ClearBeforeFill = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKodePemesanan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtJumlahPemesanan);
            this.Controls.Add(this.txtKodeMenu);
            this.Controls.Add(this.txtIdPelanggan);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NAMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtIdPelanggan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtKodeMenu;
        private System.Windows.Forms.TextBox txtJumlahPemesanan;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtKodePemesanan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView;
        private restoranDataSet3 restoranDataSet3;
        private System.Windows.Forms.BindingSource memesanBindingSource;
        private restoranDataSet3TableAdapters.memesanTableAdapter memesanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodepemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodemenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahpesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglpemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}