/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int interNumber()
{
	System.Console.Write("Введите число: ");
	int newNumber = Convert.ToInt32(Console.ReadLine());
	return newNumber;
}

int sumNumber(int num)
{
	num = Math.Abs(num);

	int sum = 0;
	while (num > 0)
	{
		sum = sum + num % 10;
		num = num / 10;
	}
	return sum;
}

int number = interNumber();
int sumNum = sumNumber(number);
System.Console.WriteLine($"Сумма цифр числа: {sumNum}");

