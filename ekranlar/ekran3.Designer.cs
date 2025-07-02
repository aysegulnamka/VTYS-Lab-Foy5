namespace labfoy5.ekranlar
{
    partial class ekran3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekran3));
            label2 = new Label();
            textbolumAd = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            textfakulteıd = new TextBox();
            textfakultead = new TextBox();
            textbolumId = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(46, 19);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 5;
            label2.Text = "Bölüm Adı";
            // 
            // textbolumAd
            // 
            textbolumAd.Location = new Point(158, 19);
            textbolumAd.Name = "textbolumAd";
            textbolumAd.Size = new Size(125, 27);
            textbolumAd.TabIndex = 6;
            textbolumAd.TextChanged += textbolumAd_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(486, 256);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(589, 19);
            button1.Name = "button1";
            button1.Size = new Size(102, 60);
            button1.TabIndex = 8;
            button1.Text = "Bölüm Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(329, 22);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 9;
            label3.Text = "Bölüm ID";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(43, 74);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 10;
            label4.Text = "Fakülte Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(329, 74);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 12;
            label6.Text = "Fakülte ID";
            // 
            // textfakulteıd
            // 
            textfakulteıd.Location = new Point(429, 71);
            textfakulteıd.Name = "textfakulteıd";
            textfakulteıd.Size = new Size(125, 27);
            textfakulteıd.TabIndex = 15;
            // 
            // textfakultead
            // 
            textfakultead.Location = new Point(158, 71);
            textfakultead.Name = "textfakultead";
            textfakultead.Size = new Size(125, 27);
            textfakultead.TabIndex = 16;
            // 
            // textbolumId
            // 
            textbolumId.Location = new Point(429, 16);
            textbolumId.Name = "textbolumId";
            textbolumId.Size = new Size(125, 27);
            textbolumId.TabIndex = 17;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(589, 117);
            button3.Name = "button3";
            button3.Size = new Size(102, 57);
            button3.TabIndex = 19;
            button3.Text = "Bölüm Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(589, 213);
            button4.Name = "button4";
            button4.Size = new Size(102, 60);
            button4.TabIndex = 20;
            button4.Text = "Bölüm Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(589, 311);
            button5.Name = "button5";
            button5.Size = new Size(102, 62);
            button5.TabIndex = 21;
            button5.Text = "Bölüm Listele";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ekran3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(709, 398);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textbolumId);
            Controls.Add(textfakultead);
            Controls.Add(textfakulteıd);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textbolumAd);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ekran3";
            Text = "Bölümler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textbolumAd;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textfakulteıd;
        private TextBox textfakultead;
        private TextBox textbolumId;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}