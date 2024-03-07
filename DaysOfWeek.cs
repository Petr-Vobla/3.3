class DaysOfWeek : IPrinter
{
    string[] weekDays = new string[] {"Понедельник", 
                                "Вторник", 
                                "Среда", 
                                "Четверг", 
                                "Пятница", 
                                "Суббота", 
                                "Воскресенье"};

    public void Print()
    {
        foreach (string value in weekDays)
        {
            Console.WriteLine("День недели:");
            Console.WriteLine(value);

        }   
    }
}
