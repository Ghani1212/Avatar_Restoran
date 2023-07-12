using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avatar_Restoran
{
    public partial class Chasier : Form
    {
        public Chasier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Chasier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDataSet2.melayani' table. You can move, or remove it, as needed.
            this.melayaniTableAdapter.Fill(this.restoranDataSet2.melayani);
            // TODO: This line of code loads data into the 'restoranDataSet1.mensuplai' table. You can move, or remove it, as needed.
            this.mensuplaiTableAdapter.Fill(this.restoranDataSet1.mensuplai);

        }
    }
}
