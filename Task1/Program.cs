int[] FillArray(int count)
{
    int[] array = new int[count];
    Random rnd = new Random();

    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int CountEvenNumber (int[] arr)
{
    int count = 0;
     foreach (int item in arr)
    {
        if (item % 2 == 0)
            count++;
    }
    return count;
}
Console.WriteLine("Введите количество элементов массива");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int[] array = FillArray(number);
PrintArray(array);
Console.WriteLine();
int result = CountEvenNumber (array);
Console.WriteLine(result);