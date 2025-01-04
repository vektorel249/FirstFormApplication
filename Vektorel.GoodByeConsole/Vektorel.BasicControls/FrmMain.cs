namespace Vektorel.BasicControls
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Konuyla ilgili video
            //https://www.youtube.com/watch?v=xEIqs1rGC90

            if (string.IsNullOrEmpty(txtLeft.Text) && string.IsNullOrEmpty(txtRight.Text))
            {
                MessageBox.Show("Önce kelime eklemelisiniz");
                return;
            }
            if (string.IsNullOrEmpty(txtLeft.Text))
            {
                txtLeft.Text = txtRight.Text;
                txtRight.Text = null;
            }
            else
            {
                txtRight.Text = txtLeft.Text;
                txtLeft.Text = null;
            }
        }
    }
}
