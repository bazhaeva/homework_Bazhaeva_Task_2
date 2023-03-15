// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

Console.WriteLine("Введите целое число №1 и нажмите enter: ");
string InputA = Console.ReadLine() ?? "";
Console.WriteLine("Введите целое число №2 и нажмите enter: ");
string InputB = Console.ReadLine() ?? "";
Console.WriteLine("Введите целое число №3 и нажмите enter: ");
string InputC = Console.ReadLine() ?? "";

int a = Convert.ToInt32(InputA);
int b = Convert.ToInt32(InputB);
int c = Convert.ToInt32(InputC);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write($" {a}, {b}, {c} -> max = {max}");
