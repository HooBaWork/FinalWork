Console.Clear();
Console.WriteLine("Укажите размер массива");
int size = int.Parse(Console.ReadLine());
string[] resultArray = returnArray();

string[] returnArray()
{
   string[] array = new string[size];
   for(int i = 0;i < size;i++)
   {
    Console.WriteLine($"Введите элемент {i+1} массива");
    array[i] = Console.ReadLine();
   }
   return array;
}
