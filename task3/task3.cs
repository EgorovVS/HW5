/* Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива. */


int[] arr = RndArray("Задайте длинну массива");
PrintArray(arr);
int min = arr[arr.Length-1], max = 0;
for (int i = 0; i < arr.Length-1; i++)
{
    if(arr[i]>max)
    {
        max = arr[i];
    }
    if(arr[i]<min)
    {
        min = arr[i];
    }
}
Console.WriteLine($"Минимальное число = {min}, максимальное число = {max}");
Console.WriteLine($"Разница между минимальным и максимальным равна {max - min}");

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