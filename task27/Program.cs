// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{
    int count = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        advance = Math.Abs(numberN) - Math.Abs(numberN) % 10;
        result = result + (Math.Abs(numberN) - advance);
        numberN = numberN / 10;

        if (Math.Abs(numberN) < 10) // для работы с отрицательными числами
        {
            result = result + numberN;
            i = count;
        }
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
