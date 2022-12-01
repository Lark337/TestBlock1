string[] CreateStringArray (int size)
{
    string[] array = new string[size];
    for (int i = 0; i<size; i++)
    {
        Console.Write($"Введите {i+1} строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write ("'" +array[i] + "' ");
    }
    Console.Write("]");
    Console.WriteLine();
}
string[] LessThanThree(string[] array)
{
    int count = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;

}

Console.Write("Введите количество строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArray(size);
ShowArray(array);
string[] newArray = LessThanThree(array);
Console.Write("->");
ShowArray(newArray);
