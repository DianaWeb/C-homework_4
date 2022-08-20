/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16

Не использовать Math.Pow() и аналоги! */
System.Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

int res = 1;
for (int i = 1; i <= B; i++)
{
	res = res * A;
}
System.Console.WriteLine($"Число А в степени В равно {res}");