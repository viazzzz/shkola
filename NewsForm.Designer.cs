using System.Windows.Forms;

partial class NewsForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dataGridViewNews;

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
            this.dataGridViewNews = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNews)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNews
            // 
            this.dataGridViewNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNews.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewNews.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNews.Name = "dataGridViewNews";
            this.dataGridViewNews.RowTemplate.Height = 24;
            this.dataGridViewNews.Size = new System.Drawing.Size(444, 95);
            this.dataGridViewNews.TabIndex = 0;
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Школьное.Properties.Resources.невсформ1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewNews);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewsForm";
            this.Text = "Новости";
            this.Load += new System.EventHandler(this.NewsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNews)).EndInit();
            this.ResumeLayout(false);

    }
}
