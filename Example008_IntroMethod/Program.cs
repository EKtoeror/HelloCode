// Нахождение максимума из чисел

int Max(int arg1, int arg2, int arg3)/*ввод функции для нахождения
большего из 3ех чисел*/
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}

int a1 = 1;
int a2 = 21;
int a3 = 13;
int b1 = 41;
int b2 = 15;
int b3 = 61;
int c1 = 17;
int c2 = 81;
int c3 = 19;
// Сравнение по три числа
int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);

// int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3)); более компактно

/*int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (b2 > max) max = b2;

if (b3 > max) max = b3;
if (c3 > max) max = c3;
if (b3 > max) max = b3;
*/
Console.WriteLine(max);