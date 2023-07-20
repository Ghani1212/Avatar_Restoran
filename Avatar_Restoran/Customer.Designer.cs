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
            this.memesanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet3 = new Avatar_Restoran.restoranDataSet3();
            this.txtJumlahPemesanan = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
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
            this.memesanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet13 = new Avatar_Restoran.restoranDataSet13();
            this.memesanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet11 = new Avatar_Restoran.restoranDataSet11();
            this.memesanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet9 = new Avatar_Restoran.restoranDataSet9();
            this.memesanTableAdapter = new Avatar_Restoran.restoranDataSet3TableAdapters.memesanTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.memesanTableAdapter1 = new Avatar_Restoran.restoranDataSet9TableAdapters.memesanTableAdapter();
            this.memesanTableAdapter2 = new Avatar_Restoran.restoranDataSet11TableAdapters.memesanTableAdapter();
            this.memesanTableAdapter3 = new Avatar_Restoran.restoranDataSet13TableAdapters.memesanTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // NAMA
            // 
            this.NAMA.AutoSize = true;
            this.NAMA.BackColor = System.Drawing.Color.BurlyWood;
            this.NAMA.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAMA.ForeColor = System.Drawing.Color.OldLace;
            this.NAMA.Location = new System.Drawing.Point(299, 20);
            this.NAMA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(471, 32);
            this.NAMA.TabIndex = 0;
            this.NAMA.Text = "SILAHKAN PESAN DISINI ヽ(*⌒▽⌒*)ﾉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Pemesanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(628, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(32, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(628, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Pelanggan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(32, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(180, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 35);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tanggal Pemesanan";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dateTimePicker.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(429, 68);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(409, 42);
            this.dateTimePicker.TabIndex = 8;
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
            // txtJumlahPemesanan
            // 
            this.txtJumlahPemesanan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memesanBindingSource, "jumlah_pesanan", true));
            this.txtJumlahPemesanan.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahPemesanan.Location = new System.Drawing.Point(291, 433);
            this.txtJumlahPemesanan.Margin = new System.Windows.Forms.Padding(4);
            this.txtJumlahPemesanan.Name = "txtJumlahPemesanan";
            this.txtJumlahPemesanan.Size = new System.Drawing.Size(245, 45);
            this.txtJumlahPemesanan.TabIndex = 18;
            // 
            // txtHarga
            // 
            this.txtHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memesanBindingSource, "harga", true));
            this.txtHarga.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(139, 314);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(245, 45);
            this.txtHarga.TabIndex = 19;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-113, -96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 652);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(595, -182);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 478);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(492, -47);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(877, 615);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(805, 470);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(892, 428);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(980, 470);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.dataGridView.DataSource = this.memesanBindingSource3;
            this.dataGridView.Location = new System.Drawing.Point(65, 126);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(928, 170);
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
            // memesanBindingSource3
            // 
            this.memesanBindingSource3.DataMember = "memesan";
            this.memesanBindingSource3.DataSource = this.restoranDataSet13;
            // 
            // restoranDataSet13
            // 
            this.restoranDataSet13.DataSetName = "restoranDataSet13";
            this.restoranDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memesanBindingSource2
            // 
            this.memesanBindingSource2.DataMember = "memesan";
            this.memesanBindingSource2.DataSource = this.restoranDataSet11;
            // 
            // restoranDataSet11
            // 
            this.restoranDataSet11.DataSetName = "restoranDataSet11";
            this.restoranDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memesanBindingSource1
            // 
            this.memesanBindingSource1.DataMember = "memesan";
            this.memesanBindingSource1.DataSource = this.restoranDataSet9;
            // 
            // restoranDataSet9
            // 
            this.restoranDataSet9.DataSetName = "restoranDataSet9";
            this.restoranDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memesanTableAdapter
            // 
            this.memesanTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IDP1001",
            "IDP1002",
            "IDP1003",
            "IDP1004",
            "IDP1005"});
            this.comboBox1.Location = new System.Drawing.Point(828, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "M001",
            "M002",
            "M003",
            "M004"});
            this.comboBox3.Location = new System.Drawing.Point(828, 377);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 28;
            // 
            // memesanTableAdapter1
            // 
            this.memesanTableAdapter1.ClearBeforeFill = true;
            // 
            // memesanTableAdapter2
            // 
            this.memesanTableAdapter2.ClearBeforeFill = true;
            // 
            // memesanTableAdapter3
            // 
            this.memesanTableAdapter3.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtJumlahPemesanan);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memesanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet9)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtJumlahPemesanan;
        private System.Windows.Forms.TextBox txtHarga;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private restoranDataSet9 restoranDataSet9;
        private System.Windows.Forms.BindingSource memesanBindingSource1;
        private restoranDataSet9TableAdapters.memesanTableAdapter memesanTableAdapter1;
        private restoranDataSet11 restoranDataSet11;
        private System.Windows.Forms.BindingSource memesanBindingSource2;
        private restoranDataSet11TableAdapters.memesanTableAdapter memesanTableAdapter2;
        private restoranDataSet13 restoranDataSet13;
        private System.Windows.Forms.BindingSource memesanBindingSource3;
        private restoranDataSet13TableAdapters.memesanTableAdapter memesanTableAdapter3;
        private System.Windows.Forms.TextBox textBox1;
    }
}