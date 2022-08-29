// В двумерном массиве показать позиции числа, заданного пользователем или указать,
// что такого элемента нет

int [,] CreateMatrix (int length, int width, int min, int max)
{
    int[,] matrix = new int [length, width];
    Random random = new Random();
    for (int i=0; i <matrix.GetLength(0); i++)
        for (int j = 0; j <matrix.GetLength(1); j++)
            matrix[i,j] = random.Next(min, max);
    return matrix;        
}

void PrintMatrix(int[,] matrix)
{
     for (int i=0; i <matrix.GetLength(0); i++)
     {
        for (int j = 0; j <matrix.GetLength(1); j++)
            Console.Write($"{matrix [i, j]} \t");
        Console.WriteLine();    
     }
     
}

int [] FindPosition (int[,]matrix, int element)
{
    for (int i=0; i <matrix.GetLength(0); i++)
        for (int j = 0; j <matrix.GetLength(1); j++)
            if (matrix[i,j] == element)
            {
            return new int []{i , j};
            }
    return new int [] {-1,1};              
}

int [,] matrix = CreateMatrix (5,5,0,20);
PrintMatrix(matrix);
Console.WriteLine("Введите число: ");
int element = int.Parse(Console.ReadLine() ?? "0");
int [] position = FindPosition (matrix, element);
if (position [0] <0 || position [1] <0)
    Console.WriteLine("Элемент не найден: ");
else
    Console.WriteLine($" Элемент найден: ({position[0]}, {position[1]})");    