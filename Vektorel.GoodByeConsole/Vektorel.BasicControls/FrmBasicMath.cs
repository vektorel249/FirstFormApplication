using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.BasicControls
{
    public partial class FrmBasicMath : Form
    {
        public FrmBasicMath()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txt1.Text) + int.Parse(txt2.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txt1.Text) - int.Parse(txt2.Text)).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txt1.Text) * int.Parse(txt2.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtResult.Text = (double.Parse(txt1.Text) / double.Parse(txt2.Text)).ToString();
        }
    }
}
