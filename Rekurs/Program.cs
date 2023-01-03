//Описать условие выхода!

//Собрать строку с числами от а до b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

string NumbersFor(int a, int b)
{
    if (a <= b) return $"{a}" + NumbersFor(a + 1, b);
    else return String.Empty;
}

//Сумма чисел от 1 до n

int Sum(int n)
{
    int result = 0;
    for (int i = 1; i < n; i++) result += i;
    return result;
}

int Sum(int n)
{
    if (n == 0) return 0;
    else return n + Sum(n - 1);
}

// Факториал числа

int Factorial(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

// Вычислить a в степень n
int Power(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int Power(int a, int n)
{
    if (n == 0) return 1;
    else if(n%2==0) return Power(a*a,n/2);//через формулу
    else return Power(a, n - 1) * a;
}

/* в лекции 8 есть примеры обохода директории
и показано как прописать время работы программы*/
