
namespace Avatar_Restoran
{
    partial class Chasier
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restoranDataSet1 = new Avatar_Restoran.restoranDataSet1();
            this.mensuplaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensuplaiTableAdapter = new Avatar_Restoran.restoranDataSet1TableAdapters.mensuplaiTableAdapter();
            this.restoranDataSet2 = new Avatar_Restoran.restoranDataSet2();
            this.melayaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.melayaniTableAdapter = new Avatar_Restoran.restoranDataSet2TableAdapters.melayaniTableAdapter();
            this.idkasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodepemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensuplaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melayaniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(560, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID Pelanggan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Avatar_Restoran.Properties.Resources.r13;
            this.pictureBox1.Location = new System.Drawing.Point(526, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 721);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(874, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Kasir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(819, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kode Pemesanan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(602, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 38);
            this.label6.TabIndex = 18;
            this.label6.Text = "Harga";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.melayaniBindingSource, "kode_pemesanan", true));
            this.textBox3.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(817, 317);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 45);
            this.textBox3.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.melayaniBindingSource, "harga", true));
            this.textBox1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(557, 317);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 45);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.melayaniBindingSource, "id_kasir", true));
            this.textBox2.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(818, 173);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 45);
            this.textBox2.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.melayaniBindingSource, "id_pelanggan", true));
            this.textBox4.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(537, 173);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 45);
            this.textBox4.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkasirDataGridViewTextBoxColumn,
            this.idpelangganDataGridViewTextBoxColumn,
            this.kodepemesananDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.melayaniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 208);
            this.dataGridView1.TabIndex = 23;
            // 
            // restoranDataSet1
            // 
            this.restoranDataSet1.DataSetName = "restoranDataSet1";
            this.restoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mensuplaiBindingSource
            // 
            this.mensuplaiBindingSource.DataMember = "mensuplai";
            this.mensuplaiBindingSource.DataSource = this.restoranDataSet1;
            // 
            // mensuplaiTableAdapter
            // 
            this.mensuplaiTableAdapter.ClearBeforeFill = true;
            // 
            // restoranDataSet2
            // 
            this.restoranDataSet2.DataSetName = "restoranDataSet2";
            this.restoranDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // melayaniBindingSource
            // 
            this.melayaniBindingSource.DataMember = "melayani";
            this.melayaniBindingSource.DataSource = this.restoranDataSet2;
            // 
            // melayaniTableAdapter
            // 
            this.melayaniTableAdapter.ClearBeforeFill = true;
            // 
            // idkasirDataGridViewTextBoxColumn
            // 
            this.idkasirDataGridViewTextBoxColumn.DataPropertyName = "id_kasir";
            this.idkasirDataGridViewTextBoxColumn.HeaderText = "id_kasir";
            this.idkasirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkasirDataGridViewTextBoxColumn.Name = "idkasirDataGridViewTextBoxColumn";
            this.idkasirDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpelangganDataGridViewTextBoxColumn
            // 
            this.idpelangganDataGridViewTextBoxColumn.DataPropertyName = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.HeaderText = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpelangganDataGridViewTextBoxColumn.Name = "idpelangganDataGridViewTextBoxColumn";
            this.idpelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodepemesananDataGridViewTextBoxColumn
            // 
            this.kodepemesananDataGridViewTextBoxColumn.DataPropertyName = "kode_pemesanan";
            this.kodepemesananDataGridViewTextBoxColumn.HeaderText = "kode_pemesanan";
            this.kodepemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodepemesananDataGridViewTextBoxColumn.Name = "kodepemesananDataGridViewTextBoxColumn";
            this.kodepemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(762, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(881, 461);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(990, 417);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Chasier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1077, 557);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Chasier";
            this.Text = "Chasier";
            this.Load += new System.EventHandler(this.Chasier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensuplaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melayaniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private restoranDataSet1 restoranDataSet1;
        private System.Windows.Forms.BindingSource mensuplaiBindingSource;
        private restoranDataSet1TableAdapters.mensuplaiTableAdapter mensuplaiTableAdapter;
        private restoranDataSet2 restoranDataSet2;
        private System.Windows.Forms.BindingSource melayaniBindingSource;
        private restoranDataSet2TableAdapters.melayaniTableAdapter melayaniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodepemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}