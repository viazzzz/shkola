using System;
using System.Windows.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnDiary_Click(object sender, EventArgs e)
    {
        var diaryForm = new DiaryForm();
        diaryForm.Show();
    }

    private void btnSchedule_Click(object sender, EventArgs e)
    {
        var scheduleForm = new ScheduleForm();
        scheduleForm.Show();
    }

    private void btnNews_Click(object sender, EventArgs e)
    {
        var newsForm = new NewsForm();
        newsForm.Show();
    }

    private void btnProfile_Click(object sender, EventArgs e)
    {
        var profileForm = new ProfileForm();
        profileForm.Show();
    }
}
