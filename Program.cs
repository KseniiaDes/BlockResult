// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.


string[] ArrayString(string st)
{
    string[] arrayStr;
    arrayStr = st.Split(' ');
    return arrayStr;
}

string[] NewArray(string[] str)
{
    int size = 0;
    string[] array = new string[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            array[size] = str[i];
            size++;
        }
    }

    string[] newArr = new string[size];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = array[i];
    }

    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


Console.Write("Введите массив строк через пробел: ");
string str = Console.ReadLine();
string[] arrayString = ArrayString(str);
PrintArray(arrayString);
string[] newArray = NewArray(arrayString);
PrintArray(newArray);
