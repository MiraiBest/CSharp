string[] CreateStringArray(int _null)
{
    string[] newArr;
    string str = Console.ReadLine()!;

    if (str != "")
    {
        newArr = CreateStringArray(_null + 1);
        newArr[newArr.Length - _null - 1] = str;
    }
    else
    {
        newArr = new string[_null];
    }

    return newArr;
}

int CountSameSizeElement(string[] msg, int size)
{
    int count = 0;

    for (int i = 0; i < msg.Length; i++)
    {
        count += Convert.ToByte(msg[i].Length <= size);
    }

    return count;
}

string[] GetAllStringsBySize(string[] msg, int size)
{
    string[] result = new string[CountSameSizeElement(msg, size)];
    int count = 0;

    for (int i = msg.Length - 1; i >= 0; i--)
    {
        if (msg[i].Length <= size)
        {
            result[count] = msg[i];
            count++;
        }
    }

    return result;
}

void PrintStringArray(string[] txt)
{
    Console.WriteLine("[{0}]", string.Join(", ", txt));
}


Console.Clear();
Console.WriteLine("Вводите элементы массива. Признак окончания ввода - пустая строка");

int size = 3;
string[] text = CreateStringArray(0);
string[] threeSymbTexts = GetAllStringsBySize(text, size);

Console.Write($"Получившийся массив: ");
PrintStringArray(text);
Console.Write($"Введены следующие элементы массива не более чем из {size} знаков: ");
PrintStringArray(threeSymbTexts);
