Console.Clear();
Console.WriteLine("Введите размер массива");
     int size = int.Parse(Console.ReadLine());

void main()
{
    string[] resultArray = returnArray();
    string[] finalResult = finalArray(resultArray);
}
main();

string[] returnArray()
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент {i + 1} массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] finalArray(string[] resultArray)
{
    string[] fArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        if (resultArray[i].Length <= 3)
        {
            fArray[i] = resultArray[i];
            Console.Write($"{fArray[i]}\t ");
        }
    }
    return fArray;
}
