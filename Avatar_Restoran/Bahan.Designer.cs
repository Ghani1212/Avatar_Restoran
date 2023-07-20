
namespace Avatar_Restoran
{
    partial class Bahan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bahan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodebahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockbahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bahanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet12 = new Avatar_Restoran.restoranDataSet12();
            this.bahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet4 = new Avatar_Restoran.restoranDataSet4();
            this.bahanTableAdapter = new Avatar_Restoran.restoranDataSet4TableAdapters.bahanTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bahanTableAdapter1 = new Avatar_Restoran.restoranDataSet12TableAdapters.bahanTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.restoranDataSet16 = new Avatar_Restoran.restoranDataSet16();
            this.bahanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bahanTableAdapter2 = new Avatar_Restoran.restoranDataSet16TableAdapters.bahanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, -370);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 889);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(435, -58);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(527, 577);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Bahan  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Bahan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock Bahan :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodebahanDataGridViewTextBoxColumn,
            this.namabahanDataGridViewTextBoxColumn,
            this.stockbahanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bahanBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(146, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kodebahanDataGridViewTextBoxColumn
            // 
            this.kodebahanDataGridViewTextBoxColumn.DataPropertyName = "kode_bahan";
            this.kodebahanDataGridViewTextBoxColumn.HeaderText = "kode_bahan";
            this.kodebahanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodebahanDataGridViewTextBoxColumn.Name = "kodebahanDataGridViewTextBoxColumn";
            this.kodebahanDataGridViewTextBoxColumn.Width = 125;
            // 
            // namabahanDataGridViewTextBoxColumn
            // 
            this.namabahanDataGridViewTextBoxColumn.DataPropertyName = "nama_bahan";
            this.namabahanDataGridViewTextBoxColumn.HeaderText = "nama_bahan";
            this.namabahanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namabahanDataGridViewTextBoxColumn.Name = "namabahanDataGridViewTextBoxColumn";
            this.namabahanDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockbahanDataGridViewTextBoxColumn
            // 
            this.stockbahanDataGridViewTextBoxColumn.DataPropertyName = "stock_bahan";
            this.stockbahanDataGridViewTextBoxColumn.HeaderText = "stock_bahan";
            this.stockbahanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockbahanDataGridViewTextBoxColumn.Name = "stockbahanDataGridViewTextBoxColumn";
            this.stockbahanDataGridViewTextBoxColumn.Width = 125;
            // 
            // bahanBindingSource1
            // 
            this.bahanBindingSource1.DataMember = "bahan";
            this.bahanBindingSource1.DataSource = this.restoranDataSet12;
            // 
            // restoranDataSet12
            // 
            this.restoranDataSet12.DataSetName = "restoranDataSet12";
            this.restoranDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bahanBindingSource
            // 
            this.bahanBindingSource.DataMember = "bahan";
            this.bahanBindingSource.DataSource = this.restoranDataSet4;
            // 
            // restoranDataSet4
            // 
            this.restoranDataSet4.DataSetName = "restoranDataSet4";
            this.restoranDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bahanTableAdapter
            // 
            this.bahanTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahanBindingSource1, "kode_bahan", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(379, 233);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 38);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahanBindingSource1, "nama_bahan", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(379, 306);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 38);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahanBindingSource1, "stock_bahan", true));
            this.textBox3.Location = new System.Drawing.Point(465, 383);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bahanTableAdapter1
            // 
            this.bahanTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // restoranDataSet16
            // 
            this.restoranDataSet16.DataSetName = "restoranDataSet16";
            this.restoranDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bahanBindingSource2
            // 
            this.bahanBindingSource2.DataMember = "bahan";
            this.bahanBindingSource2.DataSource = this.restoranDataSet16;
            // 
            // bahanTableAdapter2
            // 
            this.bahanTableAdapter2.ClearBeforeFill = true;
            // 
            // Bahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bahan";
            this.Text = "Bahan";
            this.Load += new System.EventHandler(this.Bahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private restoranDataSet4 restoranDataSet4;
        private System.Windows.Forms.BindingSource bahanBindingSource;
        private restoranDataSet4TableAdapters.bahanTableAdapter bahanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockbahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private restoranDataSet12 restoranDataSet12;
        private System.Windows.Forms.BindingSource bahanBindingSource1;
        private restoranDataSet12TableAdapters.bahanTableAdapter bahanTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private restoranDataSet16 restoranDataSet16;
        private System.Windows.Forms.BindingSource bahanBindingSource2;
        private restoranDataSet16TableAdapters.bahanTableAdapter bahanTableAdapter2;
    }
}