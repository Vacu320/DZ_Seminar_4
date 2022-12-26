// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Task29();

void Task29()
{
	Console.WriteLine("Task29");

	int[] array = GetArray(ReadInt("array length"));

	Console.WriteLine(ArrayToString(array));
}

int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"elemtn {i}");
	}

	return array;
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}