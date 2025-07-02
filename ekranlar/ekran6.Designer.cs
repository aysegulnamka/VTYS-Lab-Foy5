namespace labfoy5.ekranlar
{
    partial class ekran6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekran6));
            dataGridView1 = new DataGridView();
            label2 = new Label();
            DersIDComboBox = new ComboBox();
            ListeleButon = new Button();
            KaydetButon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(569, 190);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(40, 26);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Ders Adı";
            label2.Click += label2_Click;
            // 
            // DersIDComboBox
            // 
            DersIDComboBox.FormattingEnabled = true;
            DersIDComboBox.Location = new Point(119, 26);
            DersIDComboBox.Name = "DersIDComboBox";
            DersIDComboBox.Size = new Size(151, 28);
            DersIDComboBox.TabIndex = 6;
            DersIDComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ListeleButon
            // 
            ListeleButon.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ListeleButon.Location = new Point(298, 26);
            ListeleButon.Name = "ListeleButon";
            ListeleButon.Size = new Size(148, 62);
            ListeleButon.TabIndex = 14;
            ListeleButon.Text = "Dersi Alan Öğrencileri Listele";
            ListeleButon.UseVisualStyleBackColor = true;
            ListeleButon.Click += button4_Click;
            // 
            // KaydetButon
            // 
            KaydetButon.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            KaydetButon.Location = new Point(461, 26);
            KaydetButon.Name = "KaydetButon";
            KaydetButon.Size = new Size(148, 62);
            KaydetButon.TabIndex = 15;
            KaydetButon.Text = "Kaydet";
            KaydetButon.UseVisualStyleBackColor = true;
            KaydetButon.Click += button1_Click;
            // 
            // ekran6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(629, 321);
            Controls.Add(KaydetButon);
            Controls.Add(ListeleButon);
            Controls.Add(DersIDComboBox);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ekran6";
            Text = "Dersi Alan Öğrenci Listeleme";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox DersIDComboBox;
        private Button ListeleButon;
        private Button KaydetButon;
    }
}