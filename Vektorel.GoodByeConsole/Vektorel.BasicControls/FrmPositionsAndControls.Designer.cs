namespace Vektorel.BasicControls
{
    partial class FrmPositionsAndControls
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
            stsMenu = new StatusStrip();
            lblMousePosition = new ToolStripStatusLabel();
            lblControlsCount = new ToolStripStatusLabel();
            panel1 = new Panel();
            label1 = new Label();
            cmbComponents = new ComboBox();
            btnAdd = new Button();
            pnlPlayGround = new Panel();
            stsMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // stsMenu
            // 
            stsMenu.Items.AddRange(new ToolStripItem[] { lblMousePosition, lblControlsCount });
            stsMenu.Location = new Point(0, 282);
            stsMenu.Name = "stsMenu";
            stsMenu.Size = new Size(445, 22);
            stsMenu.TabIndex = 0;
            stsMenu.Text = "statusStrip1";
            // 
            // lblMousePosition
            // 
            lblMousePosition.Name = "lblMousePosition";
            lblMousePosition.Size = new Size(42, 17);
            lblMousePosition.Text = "[ 0 ; 0 ]";
            // 
            // lblControlsCount
            // 
            lblControlsCount.Name = "lblControlsCount";
            lblControlsCount.Size = new Size(90, 17);
            lblControlsCount.Text = "Bileşen Adedi: 0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbComponents);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(12, 226);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 35);
            panel1.TabIndex = 1;
            panel1.MouseMove += FrmPositionsAndControls_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Eklenecek Bileşen";
            label1.MouseMove += SubControls_MouseMove;
            // 
            // cmbComponents
            // 
            cmbComponents.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComponents.FormattingEnabled = true;
            cmbComponents.Location = new Point(108, 7);
            cmbComponents.Name = "cmbComponents";
            cmbComponents.Size = new Size(144, 23);
            cmbComponents.TabIndex = 1;
            cmbComponents.MouseMove += SubControls_MouseMove;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(343, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseMove += SubControls_MouseMove;
            // 
            // pnlPlayGround
            // 
            pnlPlayGround.Location = new Point(12, 12);
            pnlPlayGround.Name = "pnlPlayGround";
            pnlPlayGround.Size = new Size(421, 208);
            pnlPlayGround.TabIndex = 2;
            // 
            // FrmPositionsAndControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 304);
            Controls.Add(pnlPlayGround);
            Controls.Add(panel1);
            Controls.Add(stsMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPositionsAndControls";
            Text = "Pozisyon ve Kontrol Listesi";
            Load += FrmPositionsAndControls_Load;
            MouseMove += FrmPositionsAndControls_MouseMove;
            stsMenu.ResumeLayout(false);
            stsMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip stsMenu;
        private ToolStripStatusLabel lblMousePosition;
        private ToolStripStatusLabel lblControlsCount;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbComponents;
        private Button btnAdd;
        private Panel pnlPlayGround;
    }
}