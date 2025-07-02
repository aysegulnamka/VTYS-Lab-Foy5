namespace labfoy5.ekranlar
{
    partial class ekran1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekran1));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textogrenciID = new TextBox();
            textbolumId = new TextBox();
            textsoyad = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(518, 271);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(629, 30);
            button1.Name = "button1";
            button1.Size = new Size(132, 52);
            button1.TabIndex = 3;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(51, 30);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Adı";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(319, 34);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci Soyadı";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(342, 91);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "Bölüm ID";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(51, 91);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 7;
            label5.Text = "Öğrenci ID";
            // 
            // textogrenciID
            // 
            textogrenciID.Location = new Point(158, 88);
            textogrenciID.Name = "textogrenciID";
            textogrenciID.Size = new Size(125, 27);
            textogrenciID.TabIndex = 8;
            // 
            // textbolumId
            // 
            textbolumId.Location = new Point(444, 88);
            textbolumId.Name = "textbolumId";
            textbolumId.Size = new Size(125, 27);
            textbolumId.TabIndex = 9;
            // 
            // textsoyad
            // 
            textsoyad.Location = new Point(444, 34);
            textsoyad.Name = "textsoyad";
            textsoyad.Size = new Size(125, 27);
            textsoyad.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(629, 107);
            button2.Name = "button2";
            button2.Size = new Size(132, 57);
            button2.TabIndex = 11;
            button2.Text = "Öğrenci Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(629, 187);
            button3.Name = "button3";
            button3.Size = new Size(132, 53);
            button3.TabIndex = 12;
            button3.Text = "Öğrenci Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(629, 269);
            button4.Name = "button4";
            button4.Size = new Size(132, 52);
            button4.TabIndex = 13;
            button4.Text = "Öğrenci Listele";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textAd
            // 
            textAd.Location = new Point(158, 30);
            textAd.Name = "textAd";
            textAd.Size = new Size(125, 27);
            textAd.TabIndex = 2;
            textAd.TextChanged += textAd_TextChanged;
            // 
            // ekran1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(785, 419);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textsoyad);
            Controls.Add(textbolumId);
            Controls.Add(textogrenciID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textAd);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ekran1";
            Text = "Öğrenciler";
            Load += ekran1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textogrenciID;
        private TextBox textbolumId;
        private TextBox textsoyad;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textAd;
    }
}