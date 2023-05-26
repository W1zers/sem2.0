// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
Console.Write("Введите количество элементов массива ");
int N = Convert.ToInt32(Console.ReadLine());
int[] ar = new int [N];
FillArray(ar);
PrintArray(ar);
for(int i=0; i<N; i++)
ar[i]= ar[i]* -1;
Console.WriteLine();

PrintArray(ar);