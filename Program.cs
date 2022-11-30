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


int n = WriteRead("Введите длину первоначального массива: ")

string[] arrayIn =  CreateFillArr[n];
vivod(arrayIn);
