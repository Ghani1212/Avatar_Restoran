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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void NAMA_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDataSet3.memesan' table. You can move, or remove it, as needed.
            this.memesanTableAdapter.Fill(this.restoranDataSet3.memesan);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
