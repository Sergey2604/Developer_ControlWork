string[] array = { "lkvz", "zrnl", "kvzkdl", "23", "5twta", "ki", "678" };//создание массива

string[] SearchAndFillData(string[] array)
{
    int sizeNewArray = 0;
    int indexNewArray = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count = array[i].Length;
        if (count <= 3) sizeNewArray++;
    }
    string[] newArray = new string[sizeNewArray];
    for (int i = 0; i < array.Length; i++)
    {
        count = array[i].Length;
        if (count <= 3)
        {
            newArray[indexNewArray] = array[i];
            indexNewArray++;
        }
    }
    System.Console.WriteLine($"Старый массив - {string.Join(",", array)}");
    System.Console.WriteLine($"Новый массив - {string.Join(",", newArray)}");
    return newArray;
}
SearchAndFillData(array);