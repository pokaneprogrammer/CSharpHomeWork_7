// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue);     // Преобрадует строку в целое число
    return result;                         // Возвращает результат
}

double[,] TwoDimensionalFillArray(int size1, int size2)
{
    double[,] matrix = new double[size1, size2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 100;
   

        }

    }
    return matrix;
}


void PrintTwoDimensionalArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i < array.GetLength(0) - 1)
        {
            System.Console.Write(" ");
        }

        System.Console.WriteLine();

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]:f2}");
            if (j < array.GetLength(1) - 1)
            {
                System.Console.Write("");
            }
        }

    }
    Console.WriteLine();
}

int ArrayHeight = Prompt("Введите высоту массива :  ");
int ArrayLength = Prompt("Введите длину массива :  ");
double[,] NewTwoDimensionalArray = (TwoDimensionalFillArray(ArrayHeight, ArrayLength));
PrintTwoDimensionalArray(NewTwoDimensionalArray);