string[] InitArray()
{
    Console.Write("Задайте массив строк вводом слов, цифр, знаков через запятую: ");
    return Console.ReadLine().Split(",");
}
int CountLength(string[] array, int n)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}
string[] ResultArray(string[] arr, int n)
{
    string[] arr1 = new string[CountLength(arr, n)];

    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n)
        {
            arr1[j] = arr[i];
            j++;
        }
    }
    return arr1;
}

string[] array = InitArray();
string[] result = ResultArray(array, 3);
Console.WriteLine($"Массив строк, длина которых меньше или равна 3:[{string.Join(", ", result)}]");
