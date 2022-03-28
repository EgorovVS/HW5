/* Задача 1: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. */

int[] arr = RndArray("Задайте длинну массива");
PrintArray(arr);
int count = 0;
for(int i = 0; i<arr.Length;i++)
{
    if(arr[i] % 2 == 0)
    {
        count++;
    }
}
    Console.WriteLine($"Количество нечетных чисел равно {count}");




int[] RndArray(string message)
{
Console.WriteLine(message);
int length = Convert.ToInt32(Console.ReadLine());
int[] answer = new int[length];
for (int i = 0; i < length; i++)
{
    answer[i] = new Random().Next(100, 1000);
}
return answer;
}

void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}