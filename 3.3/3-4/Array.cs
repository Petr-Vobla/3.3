interface IOneDimesionalArray : IBaseOneDimesionalArray
{
    void DeleteElementsBiggerThan100();
    int[] RemoveDuplicates();
}


public sealed class OneDimesionalArray : IOneDimesionalArray
{
    public int[] OneDimesionalArray;

    public override void Initialize(bool fillByUser = false)
    {
        Console.WriteLine("Создание одномерного массива:");
        Console.Write("Введите длину массива:");
        int length = int.Parse(Console.ReadLine());
        oneDArray = new int[length];

        if (fillByUser)
        {
            for (int i = 0; i < oneDArray.Length; i++)
            {
                Console.Write($"Введите элемент под номером: {i + 1}: ");
                oneDArray[i] = int.Parse(Console.ReadLine());
            }
        }
        else
        {
            Random random = new Random();

            for (int i = 0; i < oneDArray.Length; i++)
            {
                oneDArray[i] = random.Next(1, 100);
            }
        }
    }
    public override void PrintOneDimesionalArray()
    {
        Console.WriteLine("Вывод одномерного массива:");
        foreach (int value in oneDArray)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
    }

    public override double GetAverage()
    {
        double sum = 0;

        foreach (int value in oneDArray)
        {
            sum += value;
        }

        return sum / oneDArray.Length;
    }


    public void DeleteElementsBiggerThan100()
    {
        int Index = 0;
        for (int i = 0; i < oneDArray.Length; i++)
        {
            if (oneDArray[i] < 100)
            {
                if (oneDArray[i] > 100)
                {
                    Index += 1;
                }
            }
        }
        int[] newOneDimesionalArray = new int[Index];

        int NewIndex = 0;

        foreach (int num in oneDArray)
        {
            if (num >= -100 && num <= 100)
            {
                newOneDimesionalArray[NewIndex] = num;
                NewIndex += 1;
            }
        }
        for (int i = 0; i < oneDArray.Length; i++)
        {
            Console.Write(oneDArray[i] + " ");
        }
        Console.WriteLine();
    }



    public int[] RemoveDuplicates()
    {
        int calc = 0;

        int[] OneDimesionalArrayWithOutDublicates = new int[oneDArray.Length];

        for (int i = 0; i < oneDArray.Length; i++)
        {
            OneDimesionalArrayWithOutDublicates[i] = int.MinValue;
        }
        for (int i = 0; i < oneDArray.Length; i++)
        {
            for (int j = 0; j < OneDimesionalArrayWithOutDublicates.Length; j++)
                if (OneDimesionalArrayWithOutDublicates[j] != OneDimesionalArrayWithOutDublicates[i])
                {
                    OneDimesionalArrayWithOutDublicates[calc] = oneDArray[i];
                    calc++;
                }
        }
        int[] NewOneDimesionalArrayWithOutDublicates = new int[calc];
        for (int i = 0; i < NewOneDimesionalArrayWithOutDublicates.Length; i++)
        {
            NewOneDimesionalArrayWithOutDublicates[i] = OneDimesionalArrayWithOutDublicates[i];
        }
        return NewOneDimesionalArrayWithOutDublicates;


    }
}