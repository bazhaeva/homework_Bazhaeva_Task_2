Console.WriteLine("Введите целое число и нажмите enter: ");
string inputN = Console.ReadLine() ?? "";
double numberN = Convert.ToDouble(inputN);
int interim = 1;

Console.Write($" {numberN} -> ");
while (interim <= numberN)
{
    if (interim%2==0)
    {
        Console.Write($" {interim}, ");
    }
    interim=interim+1;
}