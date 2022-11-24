// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[Length];

void FillArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0, 101);

        if (i == Array.Length - 1)
        {
            Array[i] = new Random().Next(0, 101);
            Console.Write('[' + string.Join(",", Array) + ']');
        }
    }
    return;
}
FillArray(Array);
