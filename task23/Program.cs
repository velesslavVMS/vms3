Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i += 1) // (begin, condition, step)
Console.Write($"{Math.Pow(i, 3)}  ");
