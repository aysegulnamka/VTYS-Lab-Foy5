﻿namespace labfoy5.ekranlar.ekran4
{
    partial class dersdegistirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dersdegistirme));
            button1 = new Button();
            YariyilTextBox = new TextBox();
            YilTextBox = new TextBox();
            SDersIDTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            OgrenciIDTextBox = new TextBox();
            label1 = new Label();
            EDersIDTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(109, 325);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 37;
            button1.Text = "Ders Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YariyilTextBox
            // 
            YariyilTextBox.Location = new Point(172, 77);
            YariyilTextBox.Name = "YariyilTextBox";
            YariyilTextBox.Size = new Size(125, 27);
            YariyilTextBox.TabIndex = 36;
            // 
            // YilTextBox
            // 
            YilTextBox.Location = new Point(172, 142);
            YilTextBox.Name = "YilTextBox";
            YilTextBox.Size = new Size(125, 27);
            YilTextBox.TabIndex = 35;
            // 
            // SDersIDTextBox
            // 
            SDersIDTextBox.Location = new Point(196, 206);
            SDersIDTextBox.Name = "SDersIDTextBox";
            SDersIDTextBox.Size = new Size(125, 27);
            SDersIDTextBox.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(43, 206);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 33;
            label5.Text = "Silinecek Ders ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(43, 142);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 32;
            label4.Text = "Yıl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(43, 77);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 31;
            label3.Text = "Yarıyıl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(43, 20);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 30;
            label2.Text = "Öğrenci ID";
            label2.Click += label2_Click;
            // 
            // OgrenciIDTextBox
            // 
            OgrenciIDTextBox.Location = new Point(172, 20);
            OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            OgrenciIDTextBox.Size = new Size(125, 27);
            OgrenciIDTextBox.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(43, 273);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 38;
            label1.Text = "Eklenecek Ders ID";
            // 
            // EDersIDTextBox
            // 
            EDersIDTextBox.Location = new Point(196, 273);
            EDersIDTextBox.Name = "EDersIDTextBox";
            EDersIDTextBox.Size = new Size(125, 27);
            EDersIDTextBox.TabIndex = 39;
            // 
            // dersdegistirme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(338, 377);
            Controls.Add(EDersIDTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(YariyilTextBox);
            Controls.Add(YilTextBox);
            Controls.Add(SDersIDTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OgrenciIDTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dersdegistirme";
            Text = "dersdegistirme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox YariyilTextBox;
        private TextBox YilTextBox;
        private TextBox SDersIDTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox OgrenciIDTextBox;
        private Label label1;
        private TextBox EDersIDTextBox;
    }
}