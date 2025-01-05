namespace Vektorel.BasicControls
{
    partial class FrmMatchScore
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
            label1 = new Label();
            label2 = new Label();
            cmbHome = new ComboBox();
            cmbAway = new ComboBox();
            pnlHomeColor1 = new Panel();
            pnlHomeColor2 = new Panel();
            pnlAwayColor2 = new Panel();
            pnlAwayColor1 = new Panel();
            btnGuess = new Button();
            lblHomeScore = new Label();
            label4 = new Label();
            lblAwayScore = new Label();
            lblHome = new Label();
            lblAway = new Label();
            tmr = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Ev Sahibi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Misafir";
            // 
            // cmbHome
            // 
            cmbHome.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHome.FormattingEnabled = true;
            cmbHome.Location = new Point(14, 29);
            cmbHome.Name = "cmbHome";
            cmbHome.Size = new Size(139, 23);
            cmbHome.TabIndex = 2;
            cmbHome.SelectedIndexChanged += cmbHome_SelectedIndexChanged;
            // 
            // cmbAway
            // 
            cmbAway.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAway.FormattingEnabled = true;
            cmbAway.Location = new Point(185, 29);
            cmbAway.Name = "cmbAway";
            cmbAway.Size = new Size(139, 23);
            cmbAway.TabIndex = 3;
            cmbAway.SelectedIndexChanged += cmbAway_SelectedIndexChanged;
            // 
            // pnlHomeColor1
            // 
            pnlHomeColor1.Location = new Point(14, 58);
            pnlHomeColor1.Name = "pnlHomeColor1";
            pnlHomeColor1.Size = new Size(63, 44);
            pnlHomeColor1.TabIndex = 4;
            // 
            // pnlHomeColor2
            // 
            pnlHomeColor2.Location = new Point(90, 58);
            pnlHomeColor2.Name = "pnlHomeColor2";
            pnlHomeColor2.Size = new Size(63, 44);
            pnlHomeColor2.TabIndex = 5;
            // 
            // pnlAwayColor2
            // 
            pnlAwayColor2.Location = new Point(261, 58);
            pnlAwayColor2.Name = "pnlAwayColor2";
            pnlAwayColor2.Size = new Size(63, 44);
            pnlAwayColor2.TabIndex = 7;
            // 
            // pnlAwayColor1
            // 
            pnlAwayColor1.Location = new Point(185, 58);
            pnlAwayColor1.Name = "pnlAwayColor1";
            pnlAwayColor1.Size = new Size(63, 44);
            pnlAwayColor1.TabIndex = 6;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(132, 128);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(75, 37);
            btnGuess.TabIndex = 8;
            btnGuess.Text = "Tahmin Et";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // lblHomeScore
            // 
            lblHomeScore.AutoSize = true;
            lblHomeScore.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            lblHomeScore.Location = new Point(101, 168);
            lblHomeScore.Name = "lblHomeScore";
            lblHomeScore.Size = new Size(43, 50);
            lblHomeScore.TabIndex = 9;
            lblHomeScore.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            label4.Location = new Point(150, 168);
            label4.Name = "label4";
            label4.Size = new Size(37, 50);
            label4.TabIndex = 10;
            label4.Text = "-";
            // 
            // lblAwayScore
            // 
            lblAwayScore.AutoSize = true;
            lblAwayScore.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            lblAwayScore.Location = new Point(193, 168);
            lblAwayScore.Name = "lblAwayScore";
            lblAwayScore.Size = new Size(43, 50);
            lblAwayScore.TabIndex = 11;
            lblAwayScore.Text = "0";
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Location = new Point(12, 187);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(77, 15);
            lblHome.TabIndex = 12;
            lblHome.Text = "Takım Seçiniz";
            // 
            // lblAway
            // 
            lblAway.AutoSize = true;
            lblAway.Location = new Point(247, 187);
            lblAway.Name = "lblAway";
            lblAway.Size = new Size(77, 15);
            lblAway.TabIndex = 13;
            lblAway.Text = "Takım Seçiniz";
            // 
            // tmr
            // 
            tmr.Tick += tmr_Tick;
            // 
            // FrmMatchScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 221);
            Controls.Add(lblAway);
            Controls.Add(lblHome);
            Controls.Add(lblAwayScore);
            Controls.Add(label4);
            Controls.Add(lblHomeScore);
            Controls.Add(btnGuess);
            Controls.Add(pnlAwayColor2);
            Controls.Add(pnlHomeColor2);
            Controls.Add(pnlAwayColor1);
            Controls.Add(pnlHomeColor1);
            Controls.Add(cmbAway);
            Controls.Add(cmbHome);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMatchScore";
            Text = "Skor Tahmini";
            Load += FrmMatchScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbHome;
        private ComboBox cmbAway;
        private Panel pnlHomeColor1;
        private Panel pnlHomeColor2;
        private Panel pnlAwayColor2;
        private Panel pnlAwayColor1;
        private Button btnGuess;
        private Label lblHomeScore;
        private Label label4;
        private Label lblAwayScore;
        private Label lblHome;
        private Label lblAway;
        private System.Windows.Forms.Timer tmr;
    }
}