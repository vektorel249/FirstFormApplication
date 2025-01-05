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
    public partial class FrmSmallGame : Form
    {
        public FrmSmallGame()
        {
            InitializeComponent();
        }
        bool movedToUp = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnLeft.Left += 5;
            btnRight.Left -= 5;

            var rightSideOfLeftButton = btnLeft.Left + btnLeft.Width;
            if (btnRight.Left - rightSideOfLeftButton <= 5 && !movedToUp)
            {
                movedToUp = true;
                btnRight.Top -= 30;
            }

            var rightSideOfRightButton = btnRight.Left + btnRight.Width;

            if (btnLeft.Left > rightSideOfRightButton && movedToUp)
            {
                btnRight.Top += 30;
                movedToUp = false;
            }
        }
    }
}
