namespace Vektorel.BasicControls
{
    partial class FrmSmallGame
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            btnLeft = new Button();
            btnRight = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(12, 162);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(75, 23);
            btnLeft.TabIndex = 0;
            btnLeft.Text = "button1";
            btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(523, 162);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(75, 23);
            btnRight.TabIndex = 1;
            btnRight.Text = "button2";
            btnRight.UseVisualStyleBackColor = true;
            // 
            // FrmSmallGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 346);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Name = "FrmSmallGame";
            Text = "FrmSmallGame";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnLeft;
        private Button btnRight;
    }
}