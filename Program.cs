void mainProgram()
{
    Console.WriteLine("Введите строки через пробел:");
    string[] inputArray = Console.ReadLine().Split();

    string[] resultArray = FilterStrings(inputArray);

    Console.WriteLine("Результат:");
    foreach (string str in resultArray)
    {
        Console.WriteLine(str);
    }
}

string[] FilterStrings(string[] inputArray)
{
    int count = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];

    int index = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            resultArray[index] = str;
            index++;
        }
    }

    return resultArray;
}


mainProgram();