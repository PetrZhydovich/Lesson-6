// Определить сколько чисел больше 0 введено с клавиатуры

void NumbersGreaterZero(string number)
{
    int[] array = new int[5];
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Введите число: ");
       
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    int count = 0;
    int j = 0;
    int size = array.Length;
    while (j < size)
    {
        if (array[j] > 0) { count++; }
        j++;
    }
    Console.Write("Количество введенных чисел больше 0 = " + count);
}

Console.WriteLine("Введите 5 различных целых чисел!");
Console.WriteLine("Нажмите клавишу ENTER");
NumbersGreaterZero(Console.ReadLine());
