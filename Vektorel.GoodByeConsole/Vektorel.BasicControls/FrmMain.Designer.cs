namespace Vektorel.BasicControls
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCopy = new Button();
            label1 = new Label();
            txtLeft = new TextBox();
            label2 = new Label();
            txtRight = new TextBox();
            SuspendLayout();
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(12, 138);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 0;
            btnCopy.Text = "Aktar";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Kelime";
            // 
            // txtLeft
            // 
            txtLeft.Location = new Point(12, 27);
            txtLeft.Name = "txtLeft";
            txtLeft.Size = new Size(153, 23);
            txtLeft.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Kopyası";
            // 
            // txtRight
            // 
            txtRight.Location = new Point(219, 27);
            txtRight.Name = "txtRight";
            txtRight.ReadOnly = true;
            txtRight.Size = new Size(153, 23);
            txtRight.TabIndex = 4;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 177);
            Controls.Add(txtRight);
            Controls.Add(label2);
            Controls.Add(txtLeft);
            Controls.Add(label1);
            Controls.Add(btnCopy);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "Kelime Türet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCopy;
        private Label label1;
        private TextBox txtLeft;
        private Label label2;
        private TextBox txtRight;
    }
}
