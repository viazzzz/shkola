using System.Windows.Forms;

partial class DiaryForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dataGridViewDiary;

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
            this.dataGridViewDiary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDiary
            // 
            this.dataGridViewDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiary.Location = new System.Drawing.Point(9, 11);
            this.dataGridViewDiary.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDiary.Name = "dataGridViewDiary";
            this.dataGridViewDiary.RowTemplate.Height = 24;
            this.dataGridViewDiary.Size = new System.Drawing.Size(443, 119);
            this.dataGridViewDiary.TabIndex = 0;
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Школьное.Properties.Resources.диариформ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewDiary);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DiaryForm";
            this.Text = "Электронный дневник";
            this.Load += new System.EventHandler(this.DiaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiary)).EndInit();
            this.ResumeLayout(false);

    }
}
