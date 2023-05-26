// Задание 33: Задайте массив. Напишите программу, которая определяет, присутствует ли
// заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-10, 11);
        //index = index + 1;
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{array[position]},");

        position++;
    }
}
Console.Clear();
Console.Write("Введите количество элементов мвссива ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число ");
int num = Convert.ToInt32(Console.ReadLine());
int[] ar = new int [N];
FillArray(ar);
PrintArray(ar);
Console.WriteLine();
int flag=0;
for(int i=0; i<N; i++)
{
    if(ar[i]==num)
    {
        Console.WriteLine($"Число {num} есть ");
        flag=1;
        break;
    }

}
 if(flag==0)Console.WriteLine($"Числа {num} нет ");int[] array = GenerateArray(-5,5,10);

PrintArray(array);

Console.Write("Enter the integer number: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
bool result = FindNumber(array, number);

Console.WriteLine($"{number} - find number in array. It`s {result}");




int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int [length];

    for (var i = 0; i < array.Length; i++)
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
     Console.WriteLine(@"[{0}]", string.Join(",", array));

if(!isParsed)
{
    Console.WriteLine("Incorrect number");
    return;
}

bool FindNumber(int[] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            break;
        }
    }
    return result;
}
