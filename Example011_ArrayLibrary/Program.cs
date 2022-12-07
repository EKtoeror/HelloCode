// 

//метод "void" не возвращает значение

void FillArray(int[] collection)//метод заполнения массива случайными числами от 1до10
{
    int length = collection.Length;//длинна
    int index = 0;//счетчик
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)//метод который будет печатать массив
{
    int count = col.Length;//длинна 
    int position = 0;//счетчик
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //индекс при поиске элемента массива ,которого там нет
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];//создание нового массива с кол-вом элементов 10

FillArray(array);//Заполнить массив
PrintArray(array);//Печать массива
Console.WriteLine();//пустая строка

int pos = IndexOf(array, 4);//результат работы фукнции IndexOf
Console.WriteLine(pos);

