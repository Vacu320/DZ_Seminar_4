// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Task25();

void Task25()
{
	Console.WriteLine("Task25");

	int numberA = ReadInt("первое число (A)");
	int numberB = ReadInt("второе число (B)");

	Console.WriteLine($"The power {numberB} of number {numberA} is {Pow(numberA, numberB)}");
}

int ReadInt(string argumentName)
{
	Console.Write($"Введите {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int Pow(int firstNumber, int secondNumber)
{
	int result = 1;

	for (int i = 0; i < secondNumber; i++)
	{
		result *= firstNumber;
	}

	return result;
}