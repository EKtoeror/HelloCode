// Вид 1

void Method1();//ничего не принимает на вход и не возвращает на выходе
{
    Console.WriteLine("Hello, World!");
}
Method1();//вызов метода

// Вид 2

void Method2(string msg);//ничего не возвращает на выходе
{
    Console.WriteLine(msg);
}
//Method2(msg: "Text");//вызов метода
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;//инкримент
    }
}
Method21("Text", count);
//Method21(msg:"Text",count:N); именованные 

// выход из зациклинивания программы Ctrl+C


// Вид 3

int Method3() //не принимает но возвращает
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);//вывод метода

// Вид 4 

int Method4(int count, string text) // и принимает и возвращает
{
    int i = 0;
    string result = "";//пустая строка (=String.Empty)

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res= Method4(count , "text");
Console.WriteLine(res);