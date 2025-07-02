namespace labfoy5.ekranlar.ekran4
{
    partial class derssilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(derssilme));
            button1 = new Button();
            YariyilTextBox = new TextBox();
            YilTextBox = new TextBox();
            DersIDTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            OgrenciIDTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(87, 255);
            button1.Name = "button1";
            button1.Size = new Size(118, 51);
            button1.TabIndex = 28;
            button1.Text = "Ders Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YariyilTextBox
            // 
            YariyilTextBox.Location = new Point(149, 86);
            YariyilTextBox.Name = "YariyilTextBox";
            YariyilTextBox.Size = new Size(125, 27);
            YariyilTextBox.TabIndex = 27;
            // 
            // YilTextBox
            // 
            YilTextBox.Location = new Point(149, 145);
            YilTextBox.Name = "YilTextBox";
            YilTextBox.Size = new Size(125, 27);
            YilTextBox.TabIndex = 26;
            // 
            // DersIDTextBox
            // 
            DersIDTextBox.Location = new Point(149, 204);
            DersIDTextBox.Name = "DersIDTextBox";
            DersIDTextBox.Size = new Size(125, 27);
            DersIDTextBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(38, 207);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 24;
            label5.Text = "Ders ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(38, 148);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 23;
            label4.Text = "Yıl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(38, 89);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 22;
            label3.Text = "Yarıyıl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(38, 24);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 21;
            label2.Text = "Öğrenci ID";
            // 
            // OgrenciIDTextBox
            // 
            OgrenciIDTextBox.Location = new Point(149, 24);
            OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            OgrenciIDTextBox.Size = new Size(125, 27);
            OgrenciIDTextBox.TabIndex = 20;
            // 
            // derssilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(297, 320);
            Controls.Add(button1);
            Controls.Add(YariyilTextBox);
            Controls.Add(YilTextBox);
            Controls.Add(DersIDTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OgrenciIDTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "derssilme";
            Text = "derssilme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox YariyilTextBox;
        private TextBox YilTextBox;
        private TextBox DersIDTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox OgrenciIDTextBox;
    }
}