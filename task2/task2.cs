/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

int[] arr = RndArray("Задайте длинну массива");
PrintArray(arr);
int sum = 0;
for(int i = 0; i<arr.Length;i++)
{
    if(i % 2 == 1)
    {
        sum = sum + arr[i];
    }
}
    Console.WriteLine($"Сумма нечетных элементов равна{sum}");


int[] RndArray(string message)
{
Console.WriteLine(message);
int length = Convert.ToInt32(Console.ReadLine());
int[] answer = new int[length];
for (int i = 0; i < length; i++)
{
    answer[i] = new Random().Next(1,11);
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