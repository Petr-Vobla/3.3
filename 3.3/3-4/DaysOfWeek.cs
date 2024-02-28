class DaysOfWeek : IPrinter
    {
        public void Print()
        {
            string[] dayOfWeek = new string["Понедельник", 
                                   "Вторник", 
                                   "Среда", 
                                   "Четверг", 
                                   "Пятница", 
                                   "Суббота", 
                                   "Воскресенье"];
              
          
            
            Console.WriteLine("День недели:");
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DaysOfWeek);

        }
    }
