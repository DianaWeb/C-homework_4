/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
	System.Console.Write("Введите число 8 раз: ");
	array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine($"Наш массив [{string.Join(", ", array)}]");