namespace Vektorel.BasicControls
{
    partial class FrmPeople
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
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dtpBirthDate = new DateTimePicker();
            btnSave = new Button();
            lstPeople = new ListBox();
            ctxItems = new ContextMenuStrip(components);
            ctbDelete = new ToolStripMenuItem();
            btnDelete = new Button();
            ctxItems.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Doğum Tarihi";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 38);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(179, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 82);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 23);
            txtLastName.TabIndex = 4;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(12, 126);
            dtpBirthDate.MaxDate = new DateTime(2002, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1945, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(179, 23);
            dtpBirthDate.TabIndex = 5;
            dtpBirthDate.Value = new DateTime(2002, 12, 31, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(116, 167);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lstPeople
            // 
            lstPeople.ContextMenuStrip = ctxItems;
            lstPeople.FormattingEnabled = true;
            lstPeople.ItemHeight = 15;
            lstPeople.Location = new Point(226, 38);
            lstPeople.Name = "lstPeople";
            lstPeople.Size = new Size(170, 229);
            lstPeople.TabIndex = 7;
            lstPeople.KeyDown += lstPeople_KeyDown;
            // 
            // ctxItems
            // 
            ctxItems.Items.AddRange(new ToolStripItem[] { ctbDelete });
            ctxItems.Name = "contextMenuStrip1";
            ctxItems.Size = new Size(87, 26);
            // 
            // ctbDelete
            // 
            ctbDelete.Name = "ctbDelete";
            ctbDelete.Size = new Size(86, 22);
            ctbDelete.Text = "Sil";
            ctbDelete.Click += ctbDelete_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(321, 273);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 321);
            Controls.Add(btnDelete);
            Controls.Add(lstPeople);
            Controls.Add(btnSave);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPeople";
            Text = "Personel Kayıt Formu";
            FormClosing += FrmPeople_FormClosing;
            Load += FrmPeople_Load;
            ctxItems.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtpBirthDate;
        private Button btnSave;
        private ListBox lstPeople;
        private Button btnDelete;
        private ContextMenuStrip ctxItems;
        private ToolStripMenuItem ctbDelete;
    }
}