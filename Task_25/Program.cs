 // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int enterNumberA, enterNumberB;

Console.Write("Введите число A: ");
enterNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
enterNumberB = Convert.ToInt32(Console.ReadLine());

int result = enterNumberA;

for (int i = 2; i <= enterNumberB; i++)
{
    result *= enterNumberA;
}
Console.WriteLine($"{enterNumberA}^{enterNumberB} = {result}");