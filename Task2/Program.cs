int[] FillArray(int count)
{
    int[] array = new int[count];
    Random rnd = new Random();

    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(-20, 21);
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

int CountOddPosititon (int[] arr)
{
    int summ = 0;
     for (int i = 0; i < arr.Length; i++)
     {
        if (i % 2 == 1)
            summ=summ+arr[i];
    }
    return summ;
}
Console.WriteLine("Введите количество элементов массива");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int[] array = FillArray(number);
PrintArray(array);
Console.WriteLine();
int result = CountOddPosititon (array);
Console.WriteLine(result);