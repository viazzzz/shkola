using System.Windows.Forms;

partial class ProfileForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblStudentName;
    private Label lblStudentClass;

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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.ImageKey = "(отсутствует)";
            this.lblStudentName.Location = new System.Drawing.Point(38, 41);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(77, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Имя студента";
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Location = new System.Drawing.Point(38, 81);
            this.lblStudentClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(38, 13);
            this.lblStudentClass.TabIndex = 1;
            this.lblStudentClass.Text = "Класс";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Школьное.Properties.Resources.профильформ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(289, 219);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentClass);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfileForm";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
