namespace labfoy5.ekranlar
{
    partial class ekran5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekran5));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            OgrenciIDTextBox = new TextBox();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            ListeleButon = new Button();
            YearComboBox = new ComboBox();
            label5 = new Label();
            SemesterComboBox = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(54, 30);
            label1.Name = "label1";
            label1.Size = new Size(284, 52);
            label1.TabIndex = 2;
            label1.Text = "Öğrenci Bazlı Listeleme";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 195);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(339, 221);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(54, 103);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Numarası";
            // 
            // OgrenciIDTextBox
            // 
            OgrenciIDTextBox.Location = new Point(54, 142);
            OgrenciIDTextBox.Margin = new Padding(3, 4, 3, 4);
            OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            OgrenciIDTextBox.Size = new Size(114, 27);
            OgrenciIDTextBox.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(497, 195);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(324, 221);
            dataGridView2.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(485, 25);
            label4.Name = "label4";
            label4.Size = new Size(336, 57);
            label4.TabIndex = 7;
            label4.Text = "Yıl Bazlı Listeleme";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // ListeleButon
            // 
            ListeleButon.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ListeleButon.Location = new Point(714, 114);
            ListeleButon.Name = "ListeleButon";
            ListeleButon.Size = new Size(107, 44);
            ListeleButon.TabIndex = 17;
            ListeleButon.Text = "Listele";
            ListeleButon.UseVisualStyleBackColor = true;
            ListeleButon.Click += ListeleButon_Click;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Location = new Point(560, 100);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(132, 28);
            YearComboBox.TabIndex = 16;
            YearComboBox.SelectedIndexChanged += YearComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(497, 103);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 15;
            label5.Text = "Yıl";
            label5.Click += label5_Click;
            // 
            // SemesterComboBox
            // 
            SemesterComboBox.FormattingEnabled = true;
            SemesterComboBox.Location = new Point(560, 134);
            SemesterComboBox.Name = "SemesterComboBox";
            SemesterComboBox.Size = new Size(132, 28);
            SemesterComboBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(497, 142);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 18;
            label3.Text = "Yarıyıl";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(205, 114);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 20;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ekran5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(847, 437);
            Controls.Add(button1);
            Controls.Add(SemesterComboBox);
            Controls.Add(label3);
            Controls.Add(ListeleButon);
            Controls.Add(YearComboBox);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(OgrenciIDTextBox);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ekran5";
            Text = "Öğrenci-Yıl Bazlı Liste";
            Load += ekran5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox OgrenciIDTextBox;
        private DataGridView dataGridView2;
        private Label label4;
        private Button ListeleButon;
        private ComboBox YearComboBox;
        private Label label5;
        private ComboBox SemesterComboBox;
        private Label label3;
        private Button button1;
    }
}