using static System.Console;
Clear();
WriteLine("Введено число:");
int num = 23432;
int i = num;
int result = 0;
int a = num % 10;
num = num / 10;
result += a * 10000;

a = num % 10;
num = num / 10;
result += a * 1000;

a = num % 10;
num = num / 10;
result += a * 100;

a = num % 10;
num = num / 10;
result += a * 10;

a = num % 10;
num = num / 10;
result += a;

if (i>=result) WriteLine($"Число {result} является палиндромом {i} ");
else WriteLine ($"Число {i} не является палиндромом");