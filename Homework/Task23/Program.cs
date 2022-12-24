using static System.Console;
Clear();
WriteLine("Введите число от 1 до ");
int.TryParse(ReadLine(), out int n);

while(n>0)
{
    WriteLine($"Квадрат числа {n} = {Math.Pow(n, 3)}");
    n--;
}
