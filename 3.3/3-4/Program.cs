 using System;
class Program
{
    public static void Main(string[] args)
    {
        
        IBaseArray[] array = new IBaseArray[3];
        array[0] = new OneDimesionalArray();
        array[1] = new Matrix();
        array[2] = new JaggedArray();
        IPrinter[] printObj = new IPrinter[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            printObj[i] = array[i];
        }
        printObj [printObj.Length - 1] = new DaysOfWeek();


        Console.WriteLine("Вывод:");

        for (int i = 0; i < printObj.Length; i++)
        {
            printObj[i].Print();
            array[i].GetAverage();
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
                return; 
     
            if (array[i] is OneDimesionalArray)
            {
                OneDimesionalArray func = (OneDimesionalArray)array[i];
                func.DeleteElementsBiggerThan100();
                func.RemoveDuplicates();
            }
            else if (array[i] is Matrix)
            {
                Matrix func = (Matrix)array[i];
                func.PrintArrayWithEvenReversedRows();
            }
            else if (array[i] is JaggedArray)
            {
                JaggedArray func = (JaggedArray)array[i];
                func.GetAveragesInInnerArrays();
                func.ChangeEvenElements();
            }
        }
    }
}
        
       
}