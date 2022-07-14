double [] FillArray(int count)
{
    double [] array = new double [count];
    Random rnd = new Random();

    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(-20, 21);
    }
    return array;
}

void PrintArray(double[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

double FindMaxMin(double[] arr)
{
    double max=0;
    double min =0;
    if (arr[0]>arr[1])
        {max = arr[0];
        min = arr[1];}
    else
    {
        max = arr[1];
        min = arr[0];
    }
    for (int i = 2; i < arr.Length; i++)
    {
        if (arr[i]>max)
            max = arr[i];
        else if (arr[i]<min)
            min = arr[i];
    }
    double result = max - min;
    return (result);
}
Console.WriteLine("Введите количество элементов массива");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
double [] array = FillArray(number);
PrintArray(array);
Console.WriteLine();
double result = FindMaxMin (array);
Console.WriteLine(result);