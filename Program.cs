/*  Написать программу, которая из имеющегося массива строк формирует массив из строк,
    длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
    либо задать на старте выполнения алгоритма. */

int WriteRead(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

string[] CreateFillArr(int d)
{
    string[] arr = new string[d];
    for (int i = 0; i < d; i++) arr[i]= Console.ReadLine();
    return arr;
}

void vivod(string msg, string[] arr)
{
    Console.Write(msg);
    foreach(var i in arr)
    {
        Console.Write(i+" ");
    }
    Console.WriteLine();
}

int CountItem(string[] arr)
{
    int c = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) c++;
    }
    return c;
}

string[] Filter(string[] a)
{
    int j=0;
    string[] b= new string[CountItem(a)];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3) 
        {
            b[j]=a[i];
            j++;
        }
    }
    return b;
}

int n = WriteRead("Введите длину первоначального массива: ");
string[] arrayIn = CreateFillArr(n);
string[] arrayOut = Filter(arrayIn);
Filter(arrayIn);
vivod("Исходный массив: ", arrayIn);
vivod("Сформированный массив: ", arrayOut);
