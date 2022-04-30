// Пример №1: Двумерные массивы

/*

string[,] table = new string[5, 6];
table[0, 2] = "слово";

for (int rows = 0; rows <5; rows++)
{
    for (int columns = 0; columns <6; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

//пример с числами 1.1:
int [,] matrix = new int [3, 4];
for (int rows = 0; rows <3; rows++)
{
    for (int columns = 0; columns < 4; columns++)
    {
        Console.WriteLine($"{matrix[rows, columns]} ");
    }
Console.WriteLine();
}

//чтобы не вписывать в цикле номера столбцов и строк, применяем команду GetLength
//пример с числами 1.2:

void PrintArray (int[,] matrix)
{   
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
        Console.Write($"{matrix[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            matr[i, y] = new Random().Next(1,10);
        }
    Console.WriteLine();
    }
}

int [,] matrix = new int [3, 4];

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);


// Рисуем картинку:

int [,] pic = new int [,];

void PrintImage(int [,] image)
{   
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int y = 0; y < image.GetLength(1); y++)
        {
            if (image[i, y] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine();
    }
}
PrintImage(pic);


// написать метод, который будет принимать число, факториал которого надо вычеслить.

int Factorial (int n)
{
    // 1! ==1 (один факториал равен единице), поэтому
    // 0! ==1 (запомнить, что 0 факториала это тоже единица)
    if (n == 1) return 1;
    else 
        return n * Factorial(n-1); //т.е.делаем возврат самого метода, т.е.берем текущее значение и в аргументе задаем пред.число
}

Console.WriteLine(Factorial(5));


// Фибоначи метод
// f(1) ==1
// f(2) ==1
// f(n) == f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n ==1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 40; i++)
    Console.Write(Fibonacci(i));

*/