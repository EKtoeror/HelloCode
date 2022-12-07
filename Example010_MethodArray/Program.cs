// Нахождение позиции элеманта массива по значению

int[] array = { 11, 21, 13, 4, 51, 16, 71, 4, 18, 91, };

int n = array.Length; //определение длины массива 

int find = 4; //искомое значение 

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;//прерывание если условие выполняется
    }
    index++; //index = index +1
}