// Цикл со счетчиком For

// for(int i =0 /*начало счетчика*/; i<count /* условие счетчика*/; i++ /*шаг*/)


// ПРИМЕРЫ 

int Method4(int count, string text) // и принимает и возвращает
{
    int i = 0;
    string result = "";//пустая строка (=String.Empty)

    /*while (i < count)
    {
        result = result + text;
        i++;
    }*/

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(count, "text");
Console.WriteLine(res);

// Таблица умножения 
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");//интерполяция строк
    }
    Console.WriteLine();//пустая строка
}

//Дан текст,заменить: все пробелы - черточками, "к" на "К", "С" на "с"

string text = "text";

//string s ="text"
//           0123
// s[3] // t

string Replace(string text, char oldValue, char newValue)//char - конкретный символ
{
    string result = String.Empty;

    int size = text.Length;
    for (int i = 0; i < size; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, " ", " --");
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(text, "к", " К");
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(text, "С", " с");
Console.WriteLine(newText);

//Алгоритм сортировки методом выбора

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 1, 1, };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temp = array[i]; //обмен местами двух элементов массива
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);


