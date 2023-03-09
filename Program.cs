// написать программу, которая из имеющегося массива строк, формирует массив из строк
// длина которых меньше либо равна 3 символа
string [] array = new string [4] {"hello", "2", "world", ":)"};
void CheckArray (string [] array)
{
    string [] array2 = new string [array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            {
                array2[count] = array[i];
                count++;
            }
    }
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

PrintArray(array);