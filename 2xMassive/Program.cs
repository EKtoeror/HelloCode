// Задание двумерного массива = матрицы
/*
string[,]table =new string[2,5];//размер 


table[1,2]="word"; //задание элемента массива


for (int rows = 0; rows < 2; rows++) //цикл строк
{
    for (int colums = 0; colums < 5; colums++) // цикл колонок
    {
        Console.WriteLine($"-{table[rows,colums]}-");
    }
}
*/


void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < 3/*matrix.GetLength(0)-строки*/; rows++)
    {
        for (int colums = 0; colums < 4/*matrix.GetLength(1)-столбцы*/; colums++)
        {
            Console.Write($"{matrix[rows, colums]} ");
        }
        Console.WriteLine();//после вывода элемента столбца текущей строки переход на новую 
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);//[1,9)
        }
    }
}
int[,] matrix/*имя*/= new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

//Закраска

void PrintImage(int[,] image)//печать рисунка (по предоставленным данным)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i,j]} "); 
            if (image[i, j] == 0)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic/*массив с данными рисунка*/[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col/*правило вызова функции*/);//вверх
        FillImage(row, col - 1);//влево
        FillImage(row + 1, col);//вниз
        FillImage(row, col + 1);//вправо
    }
}

PrintImage(pic);//печать функции по данному массиву изображения
FillImage(13, 13);//отпавная точка внутри изображения
PrintImage(pic);//закрашенное изображение(замкнутая область)


//Рекурсия - метод вызывает сам себя

//Опредление факториала рекурсией

int Factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
       return  n * Factorial(n-1);
    }
}
for (int i = 1; i < 40; i++)//будет переполнение типа данных
{
    Console.WriteLine(Factorial(i));
}

//Фибаначи

//F(n)=F(n-1)+F(n-2)
//F(0)=0
//F(1)=1
//F(2)=1

int Fibanachi(int n)
{
    if (n==1 || n==2) return 1;
    else return Fibanachi(n-1)+Fibanachi(n-2);
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibanachi(i));
}



