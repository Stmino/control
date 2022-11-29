


string[] array = new string[5] { "12344", "11", "12", "1234", "12345"};
string[] newarray = new string[array.Length];
NewArray(array, newarray);
PrintArray(newarray);

void NewArray(string[] array, string[] newarray)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
}
void PrintArray(string[] newarray)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{newarray[j]} ");
    }
    Console.WriteLine();
}
