// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Task27();

void Task27()
{

    int number = ReadInt(" ");
    if (number >=9)
    {
    int sum = NumberLen(number);
    SumNumbers(number, sum);
    }
    else 
    {
        Console.WriteLine($"Число некорректное!");
    }
}

// Функция ввода
int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a = a / 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int sum)
{
    int sumA = 0;
    for (int i = 1; i <= sum; i++)
    {
        sumA = sumA + n % 10;
        n = n / 10;
    }
    Console.WriteLine(sumA);
}

