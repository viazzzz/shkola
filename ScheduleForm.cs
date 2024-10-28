using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class ScheduleForm : Form
{
    public ScheduleForm()
    {
        InitializeComponent();
    }

    private void ScheduleForm_Load(object sender, EventArgs e)
    {
        // Пример данных
        var schedules = new List<Schedule>
        {
            new Schedule { Номер = 1, Класс = "10A", Понедельник = "Обществознание", Вторник = "Математика", Среда = "Химия", Четверг = "Математика", Пятница = "Физ-ра", Subjects = new List<string> { "Математика", "Физика", "Русский язык" } },
            new Schedule { Номер = 2, Класс = "10A", Понедельник = "История", Вторник = "Русский язык", Среда = "Физика", Четверг = "Физика", Пятница = "Физ-ра", Subjects = new List<string> { "Математика", "Физика", "Русский язык" } },
            new Schedule { Номер = 3, Класс = "10A", Понедельник = "Физика", Вторник = "ОБЖ", Среда = "История", Четверг = "Биология", Пятница = "Физ-ра", Subjects = new List<string> { "Математика", "Физика", "Русский язык" } },
            new Schedule { Номер = 4, Класс = "10A", Понедельник = "Немецкий язык", Вторник = "Физ-ра", Среда = "Физ-ра", Четверг = "История",  Subjects = new List<string> { "Математика", "Физика", "Русский язык" } },
            new Schedule { Номер = 5, Класс = "10A", Понедельник = "Биология", Среда = "Литература", Четверг = "Русский язык", Subjects = new List<string> { "Математика", "Физика", "Русский язык" } },
            new Schedule { Номер = 6, Класс = "10A", Понедельник = "Русский язык", Среда = "Английский язык", Subjects = new List<string> { "Математика", "Физика", "Русский язык" } },
        };

        dataGridViewSchedule.DataSource = schedules;
    }
}
