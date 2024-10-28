using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class NewsForm : Form
{
    public NewsForm()
    {
        InitializeComponent();
    }

    private void NewsForm_Load(object sender, EventArgs e)
    {
        // Пример данных
        var newsList = new List<News>
        {
            new News { Номер = 1, Заголовок = "Соревнования!!!", Содержание = "Приходите на соревнования по настольному теннису на 3 этаже возле буфета в 12:00!!! (записываться заранее)", Дата = DateTime.Today },
            new News { Номер = 2, Заголовок = "Рукоделия", Содержание = "Наши 3 классы сегодня делали поделки из листьев, можете посмотреть на 1 этаже возле входа", Дата = DateTime.Today },
            new News { Номер = 3, Заголовок = "Аттестация", Содержание = "Сегодня прошла аттестация, многих детей уже наказали на телефон 😬", Дата = DateTime.Today }
        };

        dataGridViewNews.DataSource = newsList;
    }
}
