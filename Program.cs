 using System;
class Program
{
    public static void Main(string[] args)
    {
        
        IBaseArray[] array = new IBaseArray[3];
        array[0] = new OneDimesionalArray();
        array[1] = new Matrix();
        array[2] = new JaggedArray();

        Console.WriteLine("Вывод:");

        for (int i = 0; i < array.Length; i++)
        {
            array[i].Initialize();
            array[i].Print();
            Console.WriteLine(array[i].GetAverage());
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
                return; 
     
            if (array[i] is IOneDimesionalArray)
            {
                OneDimesionalArray func = (OneDimesionalArray)array[i];
                func.DeleteElementsBiggerThan100();
                func.RemoveDuplicates();
            }
            else if (array[i] is IMatrix)
            {
                Matrix func = (Matrix)array[i];
                func.PrintArrayWithEvenReversedRows();
            }
            else if (array[i] is IJaggedArray jagged)
            {
                jagged.GetAveragesInInnerArrays();
                jagged.ChangeEvenElements();
            }
        }

        IPrinter[] printers = new IPrinter[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            printers[i] = array[i];
        }
        printers [printers.Length - 1] = new DaysOfWeek();

        for (int i = 0; i < printers.Length; i++)
        {
            printers[i].Print();
        }
    }
}