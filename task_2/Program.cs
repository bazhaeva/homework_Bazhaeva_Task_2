Console.Write("Введите целое число 1 и нажмите enter: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write("Введите целое число 2 и нажмите enter: ");
string userInput2 = Console.ReadLine() ?? "";

int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);

if (number1>number2)
{
    Console.WriteLine($"{number1}, {number2} -> max = {number1} , min = {number2}");
}
else
{
    Console.WriteLine($"{number1}, {number2} -> max = {number2}, min = {number1}");
}