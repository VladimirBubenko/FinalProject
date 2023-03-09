// написать программу, которая из имеющегося массива строк, формирует массив из строк
// длина которых меньше либо равна 3 символа
string [] array = {"hello", "2", "world", ":)"};
string [] CheckArray (string [] array)
{
    string [] result = new string [array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            {
                result[count] = array[i];
                count++;
            }
    }
    return result;
}

void ShowArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

ShowArray(CheckArray(array));