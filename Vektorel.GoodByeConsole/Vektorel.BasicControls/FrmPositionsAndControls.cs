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
    public partial class FrmPositionsAndControls : Form
    {
        public FrmPositionsAndControls()
        {
            InitializeComponent();
        }

        private void FrmPositionsAndControls_Load(object sender, EventArgs e)
        {
            var count = 0;
            foreach (Control formControl in this.Controls)
            {
                count += CountAllControls(formControl);
            }

            lblControlsCount.Text = $"Bileşen Adedi: {count}";

            cmbComponents.Items.Add("Button");
            cmbComponents.Items.Add("TextBox");
            cmbComponents.SelectedIndex = 0;
        }

        private int CountAllControls(Control control)
        {
            if (control.Controls.Count > 0)
            {
                return control.Controls.Count + 1;
            }

            return 1;
        }
        private void FrmPositionsAndControls_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Form)
            {
                lblMousePosition.Text = $"[ {e.X} ; {e.Y} ]";
            }
            else if (sender is Panel childControl)
            {
                lblMousePosition.Text = $"[ {e.X + childControl.Left} ; {e.Y + childControl.Top} ]";
            }
        }

        private void SubControls_MouseMove(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            var x = control.Parent.Left + control.Left + e.X;
            var y = control.Parent.Top + control.Top + e.Y;


            lblMousePosition.Text = $"[ {x} ; {y} ]";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selected = cmbComponents.SelectedItem.ToString();
            if (selected == "Button")
            {
                var btn = new Button
                {
                    Text = $"Button {Random.Shared.Next(100, 999)}",
                    Width = 80,
                    Height = 23,
                    Left = Random.Shared.Next(0, pnlPlayGround.Width - 60),
                    Top = Random.Shared.Next(0, pnlPlayGround.Height - 30)
                };
                btn.Click += ReplaceOrDispose;
                pnlPlayGround.Controls.Add(btn);
            }
            else if (selected == "TextBox")
            {
                var txt = new TextBox
                {
                    Text = $"TextBox {Random.Shared.Next(100, 999)}",
                    Width = 80,
                    Height = 23,
                    Left = Random.Shared.Next(0, pnlPlayGround.Width - 60),
                    Top = Random.Shared.Next(0, pnlPlayGround.Height - 30),
                };
                txt.KeyDown += DeleteOnEnter;
                pnlPlayGround.Controls.Add(txt);
            }
        }

        private void ReplaceOrDispose(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.Tag != null)
            {
                btn.Dispose();
                return;
            }

            btn.Tag = true;
            btn.Left = Random.Shared.Next(0, pnlPlayGround.Width - 60);
            btn.Top = Random.Shared.Next(0, pnlPlayGround.Height - 30);
        }

        private void DeleteOnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && sender is TextBox txt && txt.Text == "Sil")
            {
                pnlPlayGround.Controls.Remove(txt);
                txt.Dispose(); // Memory'den de kaldır
            }
        }
    }
}