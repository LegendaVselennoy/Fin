// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Решение 1


void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}

Random random=new Random();

double[,] FillMas(int m, int n)
{
    
    double[,] mas = new double[m, n];
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            mas[i, j] =random.NextDouble()*10;
        }

    }
    return mas;
}


double[,] mas=FillMas(3,4);
PrintArray(mas);

///////////////////////////////////////////////////////////////////////

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// m=4;n=3.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого числа в массиве нет

//Решение 2

int[,] FillMas(int m, int n)
{
    
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] =new Random().Next(0,15);
        }
    }
    return mas;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}



int[,] position=FillMas(4,3);
PrintArray(position);  
try{
Console.Write("Укажите позицию первого элемента ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите позицию второго элемента ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Результат "+InsertIndexes(a,b));
}catch
{
    Console.Write("Такого числа в массиве нет");
}

int InsertIndexes(int iIndex,int jIndex)
{ 
     int result = position[iIndex,jIndex];
     return result;
}

//////////////////////////////////////////////////////////////////////////

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// Решение 3

Console.WriteLine("Введите строки:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбцы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат");
int [,]arr=new int [n, m];
double []sum=new double [m];
Random random = new Random();

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        arr[i, j] = random.Next(0, 21);

        Console.Write(arr[i, j]+" ");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += arr[j, i];
    }
}

Console.WriteLine("Среднее арифметическое элементов в каждом столбце");
for (int i=0; i<m; i++)
{
    Console.Write(Math.Round((sum[i] / n),2)  + " ");
}