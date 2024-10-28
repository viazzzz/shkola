using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class ProfileForm : Form
{
    public ProfileForm()
    {
        InitializeComponent();
    }

    private void ProfileForm_Load(object sender, EventArgs e)
    {
        // Пример данных
        var student = new Student { Id = 1, Name = "Иван Иванов", Class = "10A" };
        lblStudentName.Text = student.Name;
        lblStudentClass.Text = student.Class;
    }
}
