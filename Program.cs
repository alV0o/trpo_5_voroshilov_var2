Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int num = n;
int sum = 0;

if (n <= 0)
{
    Console.WriteLine("Только положительные числа");
    return;
}

while (sum != 1 && sum != 4)
{
    sum = 0;
    while (num > 0)
    {
        sum += (int)Math.Pow(num % 10, 2);
        num /= 10;
    }
    num = sum;
}

if (sum == 4)
{
    Console.WriteLine("Попал в цикл");
}
else
{
    Console.WriteLine("Счастливое число");
}