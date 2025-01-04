namespace Vektorel.BasicControls
{
    partial class FrmBasicMath
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
            btnSum = new Button();
            txt1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt2 = new TextBox();
            label3 = new Label();
            txtResult = new TextBox();
            btnSub = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            SuspendLayout();
            // 
            // btnSum
            // 
            btnSum.Location = new Point(128, 42);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(46, 36);
            btnSum.TabIndex = 0;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(12, 27);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Sayı 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Sayı 2";
            // 
            // txt2
            // 
            txt2.Location = new Point(12, 71);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Sonuç";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 115);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 5;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(180, 42);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(46, 36);
            btnSub.TabIndex = 7;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(180, 84);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(46, 36);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(128, 84);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(46, 36);
            btnMul.TabIndex = 8;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // FrmBasicMath
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 203);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(txt2);
            Controls.Add(label1);
            Controls.Add(txt1);
            Controls.Add(btnSum);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBasicMath";
            Text = "Basit İşlem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSum;
        private TextBox txt1;
        private Label label1;
        private Label label2;
        private TextBox txt2;
        private Label label3;
        private TextBox txtResult;
        private Button btnSub;
        private Button btnDiv;
        private Button btnMul;
    }
}