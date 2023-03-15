Console.WriteLine("Введите целое число и нажмите enter: ");
string inputA = Console.ReadLine() ?? "";
double a = Convert.ToDouble(inputA);
//double res = a%2;
if (a%2==0)
{
    Console.WriteLine($"Число {a} четное");
}
else
{
    Console.WriteLine($"Число {a} нечетное");
}
