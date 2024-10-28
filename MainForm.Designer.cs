using System;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private Button btnDiary;
    private Button btnSchedule;
    private Button btnNews;
    private Button btnProfile;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.btnDiary = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiary
            // 
            this.btnDiary.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDiary.ForeColor = System.Drawing.Color.White;
            this.btnDiary.Location = new System.Drawing.Point(73, 24);
            this.btnDiary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiary.Name = "btnDiary";
            this.btnDiary.Size = new System.Drawing.Size(197, 35);
            this.btnDiary.TabIndex = 0;
            this.btnDiary.Text = "Электронный дневник";
            this.btnDiary.UseVisualStyleBackColor = false;
            this.btnDiary.Click += new System.EventHandler(this.btnDiary_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(73, 72);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(197, 37);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Расписание";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnNews
            // 
            this.btnNews.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNews.ForeColor = System.Drawing.Color.White;
            this.btnNews.Location = new System.Drawing.Point(73, 122);
            this.btnNews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(197, 36);
            this.btnNews.TabIndex = 2;
            this.btnNews.Text = "Новости";
            this.btnNews.UseVisualStyleBackColor = false;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(73, 173);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(197, 34);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Личный кабинет";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Школьное.Properties.Resources.ГлавнаяФорма;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(345, 258);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnDiary);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

    }
}

