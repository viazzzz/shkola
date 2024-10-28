using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class DiaryForm : Form
{
    public DiaryForm()
    {
        InitializeComponent();
    }

    private void DiaryForm_Load(object sender, EventArgs e)
    {
        // Пример данных
        var diaryEntries = new List<DiaryEntry>
        {
            new DiaryEntry { Номер = 1, Урок = "Математика", Домашка = "Упражнение 5, стр. 20", Дата = DateTime.Today },
            new DiaryEntry { Номер = 2, Урок = "Русский язык", Домашка = "Написать сочинение", Дата = DateTime.Today },
            new DiaryEntry { Номер = 3, Урок = "ОБЖ", Домашка = "Без задания", Дата = DateTime.Today },
            new DiaryEntry { Номер = 4, Урок = "Физ-ра", Домашка = "отжаться 10 раз", Дата = DateTime.Today }
        };

        dataGridViewDiary.DataSource = diaryEntries;
    }
}
