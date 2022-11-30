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

void vivod(string[] arr)
{
    foreach(var i in arr)
    {
        Console.Write(i+" ");
    }
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

void Filter(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        j=0;
        if (arr[i].Length <= 3) 
        {
            arrayOut[j]=arr[i];
            j++;
        }
    }
}

int n = WriteRead("Введите длину первоначального массива: ");
string[] arrayIn = CreateFillArr(n);
string[] arrayOut = new string[CountItem(arrayIn)];
Filter(arrayIn);
vivod(arrayIn);
vivod(arrayOut);
