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
    public partial class Bahan : Form
    {
        public Bahan()
        {
            InitializeComponent();
        }

        private void Bahan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDataSet4.bahan' table. You can move, or remove it, as needed.
            this.bahanTableAdapter.Fill(this.restoranDataSet4.bahan);

        }
    }
}
