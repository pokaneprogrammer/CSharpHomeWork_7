// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rowsArray = InputUserNumber("Введите строку в массив");
int columnsArray = InputUserNumber("Введите столбец в массив");

int[,] arrayOfRandomNumbers = CreateArrayOfRandomNumber2D(rowsArray, columnsArray);

PrintArray2D(arrayOfRandomNumbers);

double[] arithmeticMeanArray = ArithmeticMeanOfColumnsInArray(arrayOfRandomNumbers);

PrintArray(arithmeticMeanArray);

// Функция возвращает введеное пользователем число
int InputUserNumber(string message)
{
    // Ожидает ввода от пользователя числа
    do
    {
        Console.Write(message + " => ");
        bool numberCorrect = int.TryParse(Console.ReadLine(), out int userInput);

        if (numberCorrect)
        {
            return userInput;
        }
        else
        {
            Console.WriteLine("Неправильный ввод");
        }
    }
    while (true);
}

// Функция создает массив необходимой длины и заполняет случайными числами
int[,] CreateArrayOfRandomNumber2D(int rows, int columns)
{
    int [,] arrayRandom = new int[rows, columns];

    for (int i = 0; i < arrayRandom.GetLength(0); i++)
    {

        for (int j = 0; j < arrayRandom.GetLength(1); j++)
        {
            arrayRandom[i, j] = new Random().Next(0, 10);
        }
    }

    return arrayRandom;
}

// Метод выводит массив в консоль
void PrintArray2D(int[,] arrayInput)
{
    for (int i = 0; i < arrayInput.GetLength(0); i++)
    {
         Console.Write("[");
         for (int j = 0; j < arrayInput.GetLength(1); j++)
        {
            Console.Write("{0}", arrayInput[i, j]);
            if (j != (arrayInput.GetLength(1) - 1))
            {
                Console.Write("\t ");
            }
        }
        Console.WriteLine("]");
    };
}

// функция считает среднее арифметическое по столбцам двумерного массива
double[] ArithmeticMeanOfColumnsInArray(int[,] arrayInput)
{
    double[] arithmeticMeanArray = new double[arrayInput.GetLength(1)];

    // Суммирование значений по столбцам
    for (int i = 0; i < arrayInput.GetLength(1); i++)
    {
        for (int j = 0; j < arrayInput.GetLength(0); j++)
        {
           arithmeticMeanArray[i] += arrayInput[j, i]; 
        }
    }

    // Деление значений на количество строк
    for (int i = 0; i < arithmeticMeanArray.Length; i++)
    {
       arithmeticMeanArray[i] /= arrayInput.GetLength(0); 
    }

    return arithmeticMeanArray;
}

// Метод выводит массив в консоль
void PrintArray(double[] arrayInput)
{
    Console.WriteLine(" -> ");
    for (int i = 0; i < arrayInput.Length; i++)
    {
     Console.Write($"{arrayInput[i]:f1}");
     if (i < (arrayInput.Length - 1))
     {
        Console.Write("\t ");
     }   
    };
    Console.WriteLine("");
}