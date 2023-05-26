// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] array = GenerateArray();

PrintArray(array);

int sumPositiveNumber = GetSumPositiveNumbersInArray(array);
int sumNegativeNumber = GetSumNegativeNumbersInArray(array);

void PrintArray(int[] array)
{
     Console.WriteLine(@"[{0}]", string.Join(",", array));
}                                    

Console.WriteLine($"Сумма положительных элементов массива = {sumPositiveNumber}, сумма отрицательных элементов массива = {sumNegativeNumber}");


int GetSumPositiveNumbersInArray(int[] array)
{
     int sumPositiveNumber = 0;
     for (var i = 0; i < array.Length; i++)
     {
        if(array[i] >= 0)
        {
           sumPositiveNumber += array[i];
        }

     }
     return sumPositiveNumber;
}

int GetSumNegativeNumbersInArray(int[] array)
{
     int sumNegativeNumber = 0;
     for (var i = 0; i < array.Length; i++)
     {
        if(array[i] < 0)
        {
           sumNegativeNumber += array[i];
        }

     }
     return sumNegativeNumber;
}


int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int [length];
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}
