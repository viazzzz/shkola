using System.Collections.Generic;

public class Schedule
{
    public int Номер { get; set; }
    public string Класс { get; set; }
    public string Понедельник { get; set; }
    public string Вторник { get; set; }
    public string Среда { get; set; }
    public string Четверг { get; set; }
    public string Пятница { get; set; }
    public List<string> Subjects { get; internal set; }
}
    
