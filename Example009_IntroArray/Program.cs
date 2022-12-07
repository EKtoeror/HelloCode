// Массивы

int Max(int arg1, int arg2, int arg3)/*ввод функции для нахождения
большего из 3ех чисел*/
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}

int[] array = { 11, 21, 13, 41, 15, 61, 17, 81, 19 };//ввод массива

//array[0] = 12;// присвоение элементу массива значения 
//Console.WriteLine(array[4]); вывод в консоль элемента массива

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
